namespace MaxBots;

public sealed record CommentMessageBody(
    [property: JsonPropertyName(CommentMessageBody.MessageIdField)]
    string MessageId,
    [property: JsonPropertyName(CommentMessageBody.SeqField)]
    long Seq,
    [property: JsonPropertyName(CommentMessageBody.TextField)]
    string? Text = null,
    [property: JsonPropertyName(CommentMessageBody.MarkupElementField)]
    IReadOnlyList<MarkupElement>? MarkupElement = null
)
{
    public const string MessageIdField = "mid";
    public const string SeqField = "seq";
    public const string TextField = "text";
    public const string AttachmentsField = "attachments";
    public const string MarkupElementField = "markup";
}