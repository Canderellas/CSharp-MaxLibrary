namespace MaxBots;

public sealed record Recipient(
    [property: JsonPropertyName(ChatIdField)] long ChatId,
    [property: JsonPropertyName(ChatTypeField)] string? ChatType = null
)
{
    public const string ChatIdField = "chat_id";
    public const string ChatTypeField = "chat_type";
}
