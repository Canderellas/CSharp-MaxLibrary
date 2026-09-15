namespace MaxBots;

public sealed record ShareAttachmentRequest(
    [property: JsonPropertyName(PayloadField)] object Payload
) : AttachmentRequest(TypeValue)
{
    public const string TypeValue = "share";
    public const string PayloadField = "payload";
}
