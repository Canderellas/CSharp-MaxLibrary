namespace MaxBots;

public sealed record BotStartedUpdate(
    long Timestamp,
    [property: JsonPropertyName(ChatIdField)] long ChatId,
    [property: JsonPropertyName(UserField)] User User,
    [property: JsonPropertyName(PayloadField)] string? Payload = null,
    [property: JsonPropertyName(UserLocaleField)] string? UserLocale = null
) : Update(Timestamp)
{
    public const string TypeValue = "bot_started";
    public const string ChatIdField = "chat_id";
    public const string UserField = "user";
    public const string PayloadField = "payload";
    public const string UserLocaleField = "user_locale";
}
