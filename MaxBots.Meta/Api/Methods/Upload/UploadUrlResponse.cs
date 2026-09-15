namespace MaxBots;

public sealed record UploadUrlResponse([property: JsonPropertyName(UrlField)] string Url)
{
    public const string UrlField = "url";
}
