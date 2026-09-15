namespace MaxBots;

public sealed record StickerAttachment(
    [property: JsonPropertyName(PayloadField)] StickerAttachmentPayload Payload,
    [property: JsonPropertyName(WidthField)] int Width,
    [property: JsonPropertyName(HeightField)] int Height
) : Attachment(TypeValue)
{
    public const string TypeValue = "sticker";
    public const string PayloadField = "payload";
    public const string WidthField = "width";
    public const string HeightField = "height";
}
