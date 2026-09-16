namespace MaxBots;

public sealed record UploadUrlResponse(
    [property: JsonPropertyName(UploadUrlResponse.UrlField)]
    string Url
)
{
    public const string UrlField = "url";
}
