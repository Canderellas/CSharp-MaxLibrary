namespace MaxBots;

public sealed record CommentLinkedMessage(
    [property: JsonPropertyName(CommentLinkedMessage.TypeField)]
    MessageLinkType Type,
    [property: JsonPropertyName(CommentLinkedMessage.SenderField)]
    User? Sender,
    [property: JsonPropertyName(CommentLinkedMessage.MessageField)]
    CommentMessageBody Message,
    [property: JsonPropertyName(CommentLinkedMessage.ChatIdField)]
    long? ChatId = null
)
{
    public const string TypeField = "type";
    public const string SenderField = "sender";
    public const string ChatIdField = "chat_id";
    public const string MessageField = "message";
}