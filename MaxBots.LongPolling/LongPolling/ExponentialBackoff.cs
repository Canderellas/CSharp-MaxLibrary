namespace MaxBots;

/// <summary>Exponential retry delay used after a transient API failure.</summary>
public sealed class ExponentialBackoff
{
    private readonly TimeSpan _initialDelay;
    private readonly TimeSpan _maxDelay;
    private TimeSpan _nextDelay;

    public ExponentialBackoff(TimeSpan? initialDelay = null, TimeSpan? maxDelay = null)
    {
        _initialDelay = initialDelay ?? TimeSpan.FromSeconds(1);
        _maxDelay = maxDelay ?? TimeSpan.FromSeconds(30);
        _nextDelay = _initialDelay;
    }

    public TimeSpan NextDelay()
    {
        var delay = _nextDelay;
        var nextMilliseconds = Math.Min(
            _nextDelay.TotalMilliseconds * 2,
            _maxDelay.TotalMilliseconds
        );

        _nextDelay = TimeSpan.FromMilliseconds(nextMilliseconds);
        return delay;
    }

    public void Reset()
    {
        _nextDelay = _initialDelay;
    }
}
