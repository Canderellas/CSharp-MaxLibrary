namespace MaxBots;

public sealed record ShareAttachmentRequestPayload(
    [property: JsonPropertyName(ShareAttachmentRequestPayload.UrlField)]
    string? Url = null,
    [property: JsonPropertyName(ShareAttachmentRequestPayload.TokenField)]
    string? Token = null
) : AttachmentRequestPayload
{
    public const string UrlField = "url";
    public const string TokenField = "token";
}