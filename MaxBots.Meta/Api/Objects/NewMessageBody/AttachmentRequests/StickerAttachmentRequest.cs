namespace MaxBots;

public sealed record StickerAttachmentRequest(
    [property: JsonPropertyName(PayloadField)] object Payload
) : AttachmentRequest(TypeValue)
{
    public const string TypeValue = "sticker";
    public const string PayloadField = "payload";
}
