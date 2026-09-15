namespace MaxBots;

public sealed record AudioAttachmentRequest(
    [property: JsonPropertyName(PayloadField)] object Payload
) : AttachmentRequest(TypeValue)
{
    public const string TypeValue = "audio";
    public const string PayloadField = "payload";
}
