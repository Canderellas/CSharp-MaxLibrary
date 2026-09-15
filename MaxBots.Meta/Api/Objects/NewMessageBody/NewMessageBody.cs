namespace MaxBots;

public sealed record NewMessageBody(
    [property: JsonPropertyName(TextField)] string? Text = null,
    [property: JsonPropertyName(AttachmentsField)]
        IReadOnlyList<AttachmentRequest>? Attachments = null,
    [property: JsonPropertyName(LinkField)] NewMessageLink? Link = null,
    [property: JsonPropertyName(NotifyField)] bool Notify = true,
    [property: JsonPropertyName(FormatField)] string? Format = null
)
{
    public const string TextField = "text";
    public const string AttachmentsField = "attachments";
    public const string LinkField = "link";
    public const string NotifyField = "notify";
    public const string FormatField = "format";
}
