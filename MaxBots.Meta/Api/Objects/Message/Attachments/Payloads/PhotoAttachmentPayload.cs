namespace MaxBots;

public sealed record PhotoAttachmentPayload(
    [property: JsonPropertyName(PhotoIdField)] long? PhotoId = null,
    [property: JsonPropertyName(TokenField)] string? Token = null,
    [property: JsonPropertyName(UrlField)] string? Url = null
)
{
    public const string PhotoIdField = "photo_id";
    public const string TokenField = "token";
    public const string UrlField = "url";
}
