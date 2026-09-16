namespace MaxBots;

public sealed record FileAttachmentRequest(
    [property: JsonPropertyName(FileAttachmentRequest.PayloadField)]
    object Payload
) : AttachmentRequest(TypeValue)
{
    public const string TypeValue = "file";
    public const string PayloadField = "payload";
}
