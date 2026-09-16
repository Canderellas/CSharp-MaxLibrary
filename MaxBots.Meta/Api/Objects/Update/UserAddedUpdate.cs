namespace MaxBots;

public sealed record UserAddedUpdate(
    long Timestamp,
    [property: JsonPropertyName(UserAddedUpdate.ChatIdField)]
    long ChatId,
    [property: JsonPropertyName(UserAddedUpdate.UserField)]
    User User,
    [property: JsonPropertyName(UserAddedUpdate.InviterIdField)]
    long? InviterId,
    [property: JsonPropertyName(UserAddedUpdate.IsChannelField)]
    bool IsChannel
) : Update(Timestamp)
{
    public const string TypeValue = "user_added";
    public const string ChatIdField = "chat_id";
    public const string UserField = "user";
    public const string InviterIdField = "inviter_id";
    public const string IsChannelField = "is_channel";
}
