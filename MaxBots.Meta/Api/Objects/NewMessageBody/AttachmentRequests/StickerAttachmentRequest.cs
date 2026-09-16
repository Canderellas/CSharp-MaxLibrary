namespace MaxBots;

public sealed record StickerAttachmentRequest(
    [property: JsonPropertyName(StickerAttachmentRequest.PayloadField)]
    object Payload
) : AttachmentRequest(TypeValue)
{
    public const string TypeValue = "sticker";
    public const string PayloadField = "payload";
}
