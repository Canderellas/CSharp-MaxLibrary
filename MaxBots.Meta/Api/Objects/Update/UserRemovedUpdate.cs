namespace MaxBots;

public sealed record UserRemovedUpdate(
    long Timestamp,
    [property: JsonPropertyName(UserRemovedUpdate.ChatIdField)]
    long ChatId,
    [property: JsonPropertyName(UserRemovedUpdate.UserField)]
    User User,
    [property: JsonPropertyName(UserRemovedUpdate.AdminIdField)]
    long AdminId,
    [property: JsonPropertyName(UserRemovedUpdate.IsChannelField)]
    bool IsChannel
) : Update(Timestamp)
{
    public const string TypeValue = "user_removed";
    public const string ChatIdField = "chat_id";
    public const string UserField = "user";
    public const string AdminIdField = "admin_id";
    public const string IsChannelField = "is_channel";
}
