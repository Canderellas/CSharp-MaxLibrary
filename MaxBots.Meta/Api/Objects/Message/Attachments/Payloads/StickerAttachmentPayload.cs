namespace MaxBots;

public sealed record StickerAttachmentPayload(
    [property: JsonPropertyName(StickerAttachmentPayload.UrlField)]
    string Url,
    [property: JsonPropertyName(StickerAttachmentPayload.CodeField)]
    string Code
)
{
    public const string UrlField = "url";
    public const string CodeField = "code";
}
