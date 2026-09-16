namespace MaxBots;

public sealed record MessageBody(
    [property: JsonPropertyName(MessageBody.MessageIdField)]
    string MessageId,
    [property: JsonPropertyName(MessageBody.SequenceField)]
    long Sequence,
    [property: JsonPropertyName(MessageBody.TextField)]
    string? Text = null,
    [property: JsonPropertyName(MessageBody.AttachmentsField)]
    IReadOnlyList<Attachment>? Attachments = null,
    [property: JsonPropertyName(MessageBody.MarkupField)]
    IReadOnlyList<MarkupElement>? Markup = null
)
{
    public const string MessageIdField = "mid";
    public const string SequenceField = "seq";
    public const string TextField = "text";
    public const string AttachmentsField = "attachments";
    public const string MarkupField = "markup";
}
