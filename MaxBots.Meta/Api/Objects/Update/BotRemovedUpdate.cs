namespace MaxBots;

public sealed record BotRemovedUpdate(
    long Timestamp,
    [property: JsonPropertyName(UserField)] User User,
    [property: JsonPropertyName(ChatIdField)] long ChatId,
    [property: JsonPropertyName(IsChannelField)] bool IsChannel
) : Update(Timestamp)
{
    public const string TypeValue = "bot_removed";
    public const string UserField = "user";
    public const string ChatIdField = "chat_id";
    public const string IsChannelField = "is_channel";
}
