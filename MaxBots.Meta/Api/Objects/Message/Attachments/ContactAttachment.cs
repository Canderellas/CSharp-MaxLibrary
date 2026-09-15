namespace MaxBots;

public sealed record ContactAttachment(
    [property: JsonPropertyName(PayloadField)] ContactAttachmentPayload Payload
) : Attachment(TypeValue)
{
    public const string TypeValue = "contact";
    public const string PayloadField = "payload";
}
