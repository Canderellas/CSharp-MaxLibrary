using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace MaxBots;

public sealed class MaxUploadClient : IMaxUploadClient
{
    private readonly HttpClient _httpClient;
    private readonly bool _disposeHttpClient;
    private readonly JsonSerializerOptions _jsonOptions;

    public MaxUploadClient(
        HttpClient? httpClient = null,
        JsonSerializerOptions? jsonOptions = null
    )
    {
        _disposeHttpClient = httpClient is null;
        _httpClient = httpClient ?? new HttpClient();
        _jsonOptions = jsonOptions ?? new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNameCaseInsensitive = true
        };
    }

    public Task<UploadFileResponse> UploadFileAsync(
        string uploadUrl,
        Stream fileStream,
        string fileName,
        CancellationToken cancellationToken = default
    )
    {
        return UploadAsync<UploadFileResponse>(
            uploadUrl, fileStream, fileName, parseXml: false, cancellationToken);
    }

    public Task<UploadImageResponse> UploadImageAsync(
        string uploadUrl,
        Stream fileStream,
        string fileName,
        CancellationToken cancellationToken = default
    )
    {
        return UploadAsync<UploadImageResponse>(
            uploadUrl, fileStream, fileName, parseXml: false, cancellationToken);
    }

    public Task<UploadVideoResponse> UploadVideoAsync(
        string uploadUrl,
        Stream fileStream,
        string fileName,
        CancellationToken cancellationToken = default
    )
    {
        return UploadAsync<UploadVideoResponse>(
            uploadUrl, fileStream, fileName, parseXml: true, cancellationToken);
    }

    public Task<UploadAudioResponse> UploadAudioAsync(
        string uploadUrl,
        Stream fileStream,
        string fileName,
        CancellationToken cancellationToken = default
    )
    {
        return UploadAsync<UploadAudioResponse>(
            uploadUrl, fileStream, fileName, parseXml: true, cancellationToken);
    }

    private async Task<T> UploadAsync<T>(
        string uploadUrl,
        Stream fileStream,
        string fileName,
        bool parseXml,
        CancellationToken cancellationToken
    )
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(uploadUrl);
        ArgumentNullException.ThrowIfNull(fileStream);
        ArgumentException.ThrowIfNullOrWhiteSpace(fileName);

        using var content = new MultipartFormDataContent();
        var streamContent = new StreamContent(fileStream);
        streamContent.Headers.ContentType = new MediaTypeHeaderValue(GetMediaType(fileName));
        content.Add(streamContent, "data", fileName);

        using var request = new HttpRequestMessage(HttpMethod.Post, uploadUrl)
        {
            Content = content
        };

        using var response = await _httpClient
            .SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
            .ConfigureAwait(false);

        var body = await response.Content
            .ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
            throw new MaxApiRequestException(
                $"Upload server returned {(int)response.StatusCode} ({response.ReasonPhrase}): {body}",
                (int)response.StatusCode
            );

        if (string.IsNullOrWhiteSpace(body))
            throw new MaxApiRequestException(
                "Upload server returned an empty response.",
                (int)response.StatusCode
            );

        if (parseXml && body.TrimStart().StartsWith('<'))
        {
            var retval = ParseRetvalXml(body);
            return (T)CreateXmlResponse<T>(retval);
        }

        try
        {
            return JsonSerializer.Deserialize<T>(body, _jsonOptions)
                ?? throw new MaxApiRequestException(
                    "Upload server returned a null response.",
                    (int)response.StatusCode
                );
        }
        catch (JsonException ex)
        {
            throw new MaxApiRequestException(
                $"Could not deserialize the upload response: {ex.Message}",
                (int)response.StatusCode,
                ex
            );
        }
    }

    private static int ParseRetvalXml(string xml)
    {
        try
        {
            var doc = XDocument.Parse(xml);
            var text = doc.Root?.Value;
            return int.TryParse(text, out var value) ? value : 0;
        }
        catch (Exception ex)
        {
            throw new MaxApiRequestException(
                $"Could not parse XML upload response: {ex.Message}"
            );
        }
    }

    private static object CreateXmlResponse<T>(int retval)
    {
        if (typeof(T) == typeof(UploadAudioResponse))
            return new UploadAudioResponse(retval);

        if (typeof(T) == typeof(UploadVideoResponse))
            return new UploadVideoResponse(retval);

        throw new MaxApiRequestException(
            $"XML response is not supported for type {typeof(T).Name}."
        );
    }

    private static string GetMediaType(string fileName)
    {
        var extension = Path.GetExtension(fileName).ToLowerInvariant();
        return extension switch
        {
            ".jpg" or ".jpeg" => "image/jpeg",
            ".png"            => "image/png",
            ".gif"            => "image/gif",
            ".webp"           => "image/webp",
            ".mp4"            => "video/mp4",
            ".mov"            => "video/quicktime",
            ".mp3"            => "audio/mpeg",
            ".ogg"            => "audio/ogg",
            ".wav"            => "audio/wav",
            ".pdf"            => "application/pdf",
            ".doc"            => "application/msword",
            ".docx"           => "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
            ".xls"            => "application/vnd.ms-excel",
            ".xlsx"           => "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            ".zip"            => "application/zip",
            ".txt"            => "text/plain",
            _                 => "application/octet-stream",
        };
    }

    public void Dispose()
    {
        if (_disposeHttpClient)
        {
            _httpClient.Dispose();
        }
    }
}