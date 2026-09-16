namespace MaxBots;

public sealed record FileAttachment(
    [property: JsonPropertyName(FileAttachment.PayloadField)]
    FileAttachmentPayload Payload,
    [property: JsonPropertyName(FileAttachment.FileNameField)]
    string FileName,
    [property: JsonPropertyName(FileAttachment.SizeField)]
    long Size
) : Attachment(TypeValue)
{
    public const string TypeValue = "file";
    public const string PayloadField = "payload";
    public const string FileNameField = "filename";
    public const string SizeField = "size";
}
