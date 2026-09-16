namespace MaxBots;

public sealed record BotStoppedUpdate(
    long Timestamp,
    [property: JsonPropertyName(BotStoppedUpdate.ChatIdField)] 
    long ChatId,
    [property: JsonPropertyName(BotStoppedUpdate.UserField)] 
    User User,
    [property: JsonPropertyName(BotStoppedUpdate.UserLocaleField)]
    string? UserLocale = null
) : Update(Timestamp)
{
    public const string TypeValue = "bot_stopped";
    public const string ChatIdField = "chat_id";
    public const string UserField = "user";
    public const string UserLocaleField = "user_locale";
}
