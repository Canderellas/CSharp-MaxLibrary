namespace MaxBots;

public sealed record VideoAttachmentRequest(
    [property: JsonPropertyName(VideoAttachmentRequest.PayloadField)]
    object Payload
) : AttachmentRequest(TypeValue)
{
    public const string TypeValue = "video";
    public const string PayloadField = "payload";
}
