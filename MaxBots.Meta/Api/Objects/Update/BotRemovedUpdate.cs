namespace MaxBots;

public sealed record BotRemovedUpdate(
    long Timestamp,
    [property: JsonPropertyName(BotRemovedUpdate.UserField)] 
    User User,
    [property: JsonPropertyName(BotRemovedUpdate.ChatIdField)] 
    long ChatId,
    [property: JsonPropertyName(BotRemovedUpdate.IsChannelField)]
    bool IsChannel
) : Update(Timestamp)
{
    public const string TypeValue = "bot_removed";
    public const string UserField = "user";
    public const string ChatIdField = "chat_id";
    public const string IsChannelField = "is_channel";
}
