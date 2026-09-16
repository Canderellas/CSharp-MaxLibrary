namespace MaxBots;

public sealed record ContactAttachmentRequest(
    [property: JsonPropertyName(ContactAttachmentRequest.PayloadField)]
    object Payload
) : AttachmentRequest(TypeValue)
{
    public const string TypeValue = "contact";
    public const string PayloadField = "payload";
}
