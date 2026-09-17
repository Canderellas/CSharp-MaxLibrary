namespace MaxBots;

public sealed record Recipient(
    [property: JsonPropertyName(Recipient.ChatIdField)] 
    long ChatId,
    [property: JsonPropertyName(Recipient.ChatTypeField)] 
    ChatType? ChatType = null
)
{
    public const string ChatIdField = "chat_id";
    public const string ChatTypeField = "chat_type";
}
