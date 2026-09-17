namespace MaxBots;

public sealed record CommentMessage(
    [property: JsonPropertyName(CommentMessage.TimestampField)]
    long Timestamp,
    [property: JsonPropertyName(CommentMessage.SenderField)]
    User? Sender = null,
    [property: JsonPropertyName(CommentMessage.RecipientField)]
    Recipient? Recipient = null,
    [property: JsonPropertyName(CommentMessage.LinkField)]
    CommentLinkedMessage? Link = null,
    [property: JsonPropertyName(CommentMessage.BodyField)]
    CommentMessageBody? Body = null
)
{
    public const string SenderField = "sender";
    public const string RecipientField = "recipient";
    public const string TimestampField = "timestamp";
    public const string LinkField = "link";
    public const string BodyField = "body";
}