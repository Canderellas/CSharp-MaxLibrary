namespace MaxBots;

/// <summary>One independently running MAX bot polling session.</summary>
public sealed class BotSession : IAsyncDisposable
{
    private readonly MaxApiClient _client;
    private readonly ILongPollingUpdateConsumer _consumer;
    private readonly ExponentialBackoff _backoff;
    private readonly TimeSpan _idleDelay;
    private CancellationTokenSource? _stopSource;
    private Task? _pollingTask;

    public BotSession(
        MaxApiClient client,
        ILongPollingUpdateConsumer consumer,
        TimeSpan? idleDelay = null,
        ExponentialBackoff? backoff = null
    )
    {
        _client = client;
        _consumer = consumer;
        _idleDelay = idleDelay ?? TimeSpan.FromMilliseconds(300);
        _backoff = backoff ?? new ExponentialBackoff();
    }

    public bool IsRunning
    {
        get { return _pollingTask is { IsCompleted: false }; }
    }

    public void Start()
    {
        if (IsRunning)
        {
            throw new MaxApiException("The bot session is already running.");
        }

        _stopSource?.Dispose();
        _stopSource = new CancellationTokenSource();
        _pollingTask = RunAsync(_stopSource.Token);
    }

    public async Task StopAsync()
    {
        if (_stopSource is null)
        {
            return;
        }

        await _stopSource.CancelAsync().ConfigureAwait(false);

        if (_pollingTask is null)
        {
            return;
        }

        try
        {
            await _pollingTask.ConfigureAwait(false);
        }
        catch (OperationCanceledException)
        {
            // Expected after cancellation.
        }
    }

    public async ValueTask DisposeAsync()
    {
        await StopAsync().ConfigureAwait(false);
        _stopSource?.Dispose();
        _client.Dispose();
    }

    private async Task RunAsync(CancellationToken cancellationToken)
    {
        long? marker = null;

        while (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                Console.WriteLine("123");
                var getUpdates = new GetUpdates(marker: marker);
                var response = await _client
                    .ExecuteAsync(getUpdates, cancellationToken)
                    .ConfigureAwait(false);

                marker = response.Marker ?? marker;

                if (response.Updates.Count > 0)
                {
                    await _consumer
                        .ConsumeAsync(response.Updates, cancellationToken)
                        .ConfigureAwait(false);
                }

                _backoff.Reset();

                if (response.Updates.Count == 0)
                {
                    await Task.Delay(_idleDelay, cancellationToken).ConfigureAwait(false);
                }
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                break;
            }
            catch (Exception) when (!cancellationToken.IsCancellationRequested)
            {
                await Task.Delay(_backoff.NextDelay(), cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
