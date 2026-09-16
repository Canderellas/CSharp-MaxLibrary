namespace MaxBots;

public sealed record ImageAttachmentRequest(
    [property: JsonPropertyName(ImageAttachmentRequest.PayloadField)]
    object Payload
) : AttachmentRequest(TypeValue)
{
    public const string TypeValue = "image";
    public const string PayloadField = "payload";
}
