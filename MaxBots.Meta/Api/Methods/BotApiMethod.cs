using System.Net.Http;

namespace MaxBots;

/// <summary>
/// Base class for a MAX Bot API request. Each derived method owns its HTTP verb,
/// API path, query arguments, request payload and response type.
/// </summary>
public abstract class BotApiMethod<TResponse>
{
    public abstract HttpMethod HttpMethod { get; }

    public abstract string Method { get; }

    public virtual IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        return Array.Empty<KeyValuePair<string, string?>>();
    }

    public virtual object? GetBody()
    {
        return null;
    }
}
