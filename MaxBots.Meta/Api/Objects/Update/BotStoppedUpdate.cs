namespace MaxBots;

public sealed record BotStoppedUpdate(
    long Timestamp,
    [property: JsonPropertyName(ChatIdField)] long ChatId,
    [property: JsonPropertyName(UserField)] User User,
    [property: JsonPropertyName(UserLocaleField)] string? UserLocale = null
) : Update(Timestamp)
{
    public const string TypeValue = "bot_stopped";
    public const string ChatIdField = "chat_id";
    public const string UserField = "user";
    public const string UserLocaleField = "user_locale";
}
