namespace MaxBots;

public sealed record ContactAttachmentRequest(
    [property: JsonPropertyName(PayloadField)] object Payload
) : AttachmentRequest(TypeValue)
{
    public const string TypeValue = "contact";
    public const string PayloadField = "payload";
}
