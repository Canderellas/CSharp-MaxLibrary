namespace MaxBots;

public sealed record MessageRemovedUpdate(
    long Timestamp,
    [property: JsonPropertyName(MessageRemovedUpdate.MessageIdField)]
    string MessageId,
    [property: JsonPropertyName(MessageRemovedUpdate.ChatIdField)]
    long ChatId,
    [property: JsonPropertyName(MessageRemovedUpdate.UserIdField)]
    long UserId
) : Update(Timestamp)
{
    public const string TypeValue = "message_removed";
    public const string MessageIdField = "message_id";
    public const string ChatIdField = "chat_id";
    public const string UserIdField = "user_id";
}
