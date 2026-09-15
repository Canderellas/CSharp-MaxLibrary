namespace MaxBots;

public sealed record UserRemovedUpdate(
    long Timestamp,
    [property: JsonPropertyName(ChatIdField)] long ChatId,
    [property: JsonPropertyName(UserField)] User User,
    [property: JsonPropertyName(AdminIdField)] long AdminId,
    [property: JsonPropertyName(IsChannelField)] bool IsChannel
) : Update(Timestamp)
{
    public const string TypeValue = "user_removed";
    public const string ChatIdField = "chat_id";
    public const string UserField = "user";
    public const string AdminIdField = "admin_id";
    public const string IsChannelField = "is_channel";
}
