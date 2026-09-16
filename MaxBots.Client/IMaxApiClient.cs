using System.Text.Json;

namespace MaxBots;

public interface IMaxApiClient : IDisposable
{
    /// <summary>Bot token used to authorize requests.</summary>
    string BotToken { get; }

    /// <summary>Base endpoint (scheme, host, port) of the MAX API.</summary>
    MaxUrl Endpoint { get; }

    /// <summary>Serializer options used for request/response bodies.</summary>
    JsonSerializerOptions JsonOptions { get; }

    /// <summary>Executes a typed API method from the Meta module.</summary>
    Task<TResponse> ExecuteAsync<TResponse>(
        BotApiMethod<TResponse> method,
        CancellationToken cancellationToken = default
    );
}