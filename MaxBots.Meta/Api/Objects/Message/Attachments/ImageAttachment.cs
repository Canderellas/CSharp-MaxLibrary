namespace MaxBots;

public sealed record ImageAttachment(
    [property: JsonPropertyName(PayloadField)] PhotoAttachmentPayload Payload
) : Attachment(TypeValue)
{
    public const string TypeValue = "image";
    public const string PayloadField = "payload";
}
