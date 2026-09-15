namespace MaxBots;

public sealed record MessageBody(
    [property: JsonPropertyName(MessageIdField)] string MessageId,
    [property: JsonPropertyName(SequenceField)] long Sequence,
    [property: JsonPropertyName(TextField)] string? Text = null,
    [property: JsonPropertyName(AttachmentsField)] IReadOnlyList<Attachment>? Attachments = null,
    [property: JsonPropertyName(MarkupField)] IReadOnlyList<MarkupElement>? Markup = null
)
{
    public const string MessageIdField = "mid";
    public const string SequenceField = "seq";
    public const string TextField = "text";
    public const string AttachmentsField = "attachments";
    public const string MarkupField = "markup";
}
