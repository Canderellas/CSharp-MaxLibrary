namespace MaxBots;

public sealed record PhotoAttachmentPayload(
    [property: JsonPropertyName(PhotoAttachmentPayload.PhotoIdField)]
    long? PhotoId = null,
    [property: JsonPropertyName(PhotoAttachmentPayload.TokenField)]
    string? Token = null,
    [property: JsonPropertyName(PhotoAttachmentPayload.UrlField)]
    string? Url = null
)
{
    public const string PhotoIdField = "photo_id";
    public const string TokenField = "token";
    public const string UrlField = "url";
}
