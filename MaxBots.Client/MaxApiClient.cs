using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MaxBots;

/// <summary>Asynchronous HTTP client for the MAX Bot API.</summary>
public sealed class MaxApiClient : IMaxApiClient
{
    private readonly HttpClient _httpClient;
    private readonly bool _disposeHttpClient;

    public string BotToken { get; }
    public MaxUrl Endpoint { get; }
    public JsonSerializerOptions JsonOptions { get; }

    public MaxApiClient(
        string botToken,
        HttpClient? httpClient = null,
        MaxUrl? endpoint = null,
        JsonSerializerOptions? jsonOptions = null
    )
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(botToken);
        BotToken = botToken;
        Endpoint = endpoint ?? MaxUrl.Default;
        _disposeHttpClient = httpClient is null;
        _httpClient = httpClient ?? new HttpClient();
        JsonOptions =
            jsonOptions
            ?? new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNameCaseInsensitive = true,
                AllowOutOfOrderMetadataProperties = true
            };
    }

    private async Task<T> SendAsync<T>(
        HttpMethod method,
        string path,
        object? body,
        IEnumerable<KeyValuePair<string, string?>>? query = null,
        CancellationToken cancellationToken = default
    )
    {
        using var request = new HttpRequestMessage(method, Endpoint.CreateUri(path, query));
        request.Headers.TryAddWithoutValidation(AuthorizationHeader, BotToken);
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(ApplicationJsonMediaType));
        if (body is not null)
            request.Content = new StringContent(
                JsonSerializer.Serialize(body, JsonOptions),
                Encoding.UTF8,
                ApplicationJsonMediaType
            );

        using var response = await _httpClient
            .SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
            .ConfigureAwait(false);
        var json = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
            throw new MaxApiRequestException(
                $"MAX API returned {(int)response.StatusCode} ({response.ReasonPhrase}): {json}",
                (int)response.StatusCode
            );
        if (string.IsNullOrWhiteSpace(json))
            throw new MaxApiRequestException(
                "MAX API returned an empty response.",
                (int)response.StatusCode
            );
        try
        {
            Console.WriteLine(json);
            return JsonSerializer.Deserialize<T>(json, JsonOptions)
                ?? throw new MaxApiRequestException(
                    "MAX API returned a null response.",
                    (int)response.StatusCode
                );
        }
        catch (JsonException ex)
        {
            throw new MaxApiRequestException(
                $"Could not deserialize the MAX API response: {ex.Message}",
                (int)response.StatusCode,
                ex
            );
        }
    }

    /// <summary>Executes a typed API method from the Meta module.</summary>
    public Task<TResponse> ExecuteAsync<TResponse>(
        BotApiMethod<TResponse> method,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(method);

        return SendAsync<TResponse>(
            method.HttpMethod,
            method.Method,
            method.GetBody(),
            method.GetQueryParameters(),
            cancellationToken
        );
    }

    private const string AuthorizationHeader = "Authorization";
    private const string ApplicationJsonMediaType = "application/json";

    public void Dispose()
    {
        if (_disposeHttpClient)
        {
            _httpClient.Dispose();
        }
    }
}
