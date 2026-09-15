namespace MaxBots;

/// <summary>A convenient delegate-based update consumer.</summary>
public sealed class DelegateUpdateConsumer(
    Func<IReadOnlyList<Update>, CancellationToken, Task> handler
) : ILongPollingUpdateConsumer
{
    public Task ConsumeAsync(
        IReadOnlyList<Update> updates,
        CancellationToken cancellationToken = default
    )
    {
        return handler(updates, cancellationToken);
    }
}
