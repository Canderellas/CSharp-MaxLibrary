namespace MaxBots;

public sealed record NewMessageBody(
    [property: JsonPropertyName(NewMessageBody.TextField)]
    string? Text = null,
    [property: JsonPropertyName(NewMessageBody.AttachmentsField)]
    IReadOnlyList<AttachmentRequest>? Attachments = null,
    [property: JsonPropertyName(NewMessageBody.LinkField)]
    NewMessageLink? Link = null,
    [property: JsonPropertyName(NewMessageBody.NotifyField)] 
    bool Notify = true,
    [property: JsonPropertyName(NewMessageBody.FormatField)] 
    TextFormat? Format = null
)
{
    public const string TextField = "text";
    public const string AttachmentsField = "attachments";
    public const string LinkField = "link";
    public const string NotifyField = "notify";
    public const string FormatField = "format";
}
