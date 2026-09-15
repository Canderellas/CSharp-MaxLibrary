using System.Collections.Concurrent;

namespace MaxBots;

/// <summary>Registers and manages multiple long-polling bots.</summary>
public sealed class MaxBotsLongPollingApplication : IAsyncDisposable
{
    private readonly ConcurrentDictionary<string, BotSession> _sessions = new(
        StringComparer.Ordinal
    );

    public bool IsRunning { get; private set; } = true;

    public BotSession RegisterBot(
        string botToken,
        ILongPollingUpdateConsumer consumer,
        HttpClient? httpClient = null,
        MaxUrl? endpoint = null
    )
    {
        Console.WriteLine("123");
        var client = new MaxApiClient(botToken, httpClient, endpoint);
        var session = new BotSession(client, consumer);

        if (!_sessions.TryAdd(botToken, session))
        {
            client.Dispose();
            throw new MaxApiException("A bot with this token is already registered.");
        }

        if (IsRunning)
        {
            Console.WriteLine("123");
            session.Start();
        }

        return session;
    }

    public async Task UnregisterBotAsync(string botToken)
    {
        if (!_sessions.TryRemove(botToken, out var session))
        {
            throw new MaxApiException("The bot is not registered.");
        }

        await session.DisposeAsync().ConfigureAwait(false);
    }

    public void Start()
    {
        if (IsRunning)
        {
            throw new MaxApiException("The application is already running.");
        }

        IsRunning = true;

        foreach (var session in GetStoppedSessions())
        {
            session.Start();
        }
    }

    public async Task StopAsync()
    {
        if (!IsRunning)
        {
            return;
        }

        IsRunning = false;
        var stopTasks = new List<Task>();

        foreach (var session in _sessions.Values)
        {
            stopTasks.Add(session.StopAsync());
        }

        await Task.WhenAll(stopTasks).ConfigureAwait(false);
    }

    public async ValueTask DisposeAsync()
    {
        await StopAsync().ConfigureAwait(false);

        foreach (var session in _sessions.Values)
        {
            await session.DisposeAsync().ConfigureAwait(false);
        }

        _sessions.Clear();
    }

    private IEnumerable<BotSession> GetStoppedSessions()
    {
        foreach (var session in _sessions.Values)
        {
            if (!session.IsRunning)
            {
                yield return session;
            }
        }
    }
}
