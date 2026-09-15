namespace MaxBots;

/// <summary>Consumes a batch of updates received by long polling.</summary>
public interface ILongPollingUpdateConsumer
{
    Task ConsumeAsync(IReadOnlyList<Update> updates, CancellationToken cancellationToken = default);
}
