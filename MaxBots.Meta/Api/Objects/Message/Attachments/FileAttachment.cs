namespace MaxBots;

public sealed record FileAttachment(
    [property: JsonPropertyName(PayloadField)] FileAttachmentPayload Payload,
    [property: JsonPropertyName(FileNameField)] string FileName,
    [property: JsonPropertyName(SizeField)] long Size
) : Attachment(TypeValue)
{
    public const string TypeValue = "file";
    public const string PayloadField = "payload";
    public const string FileNameField = "filename";
    public const string SizeField = "size";
}
