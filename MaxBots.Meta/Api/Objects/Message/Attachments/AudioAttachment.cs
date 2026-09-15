namespace MaxBots;

public sealed record AudioAttachment(
    [property: JsonPropertyName(PayloadField)] MediaAttachmentPayload Payload,
    [property: JsonPropertyName(TranscriptionField)] string? Transcription = null
) : Attachment(TypeValue)
{
    public const string TypeValue = "audio";
    public const string PayloadField = "payload";
    public const string TranscriptionField = "transcription";
}
