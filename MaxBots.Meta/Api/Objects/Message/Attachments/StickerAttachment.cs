namespace MaxBots;

public sealed record StickerAttachment(
    [property: JsonPropertyName(StickerAttachment.PayloadField)]
    StickerAttachmentPayload Payload,
    [property: JsonPropertyName(StickerAttachment.WidthField)]
    int Width,
    [property: JsonPropertyName(StickerAttachment.HeightField)]
    int Height
) : Attachment(TypeValue)
{
    public const string TypeValue = "sticker";
    public const string PayloadField = "payload";
    public const string WidthField = "width";
    public const string HeightField = "height";
}
