namespace MaxBots;

public sealed record StickerAttachmentRequestPayload(
    [property: JsonPropertyName(StickerAttachmentRequestPayload.CodeField)]
    string Code
) : AttachmentRequestPayload
{
    public const string CodeField = "code";
}