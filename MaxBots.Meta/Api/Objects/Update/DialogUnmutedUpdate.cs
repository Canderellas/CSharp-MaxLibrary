namespace MaxBots;

public sealed record DialogUnmutedUpdate(
    long Timestamp,
    [property: JsonPropertyName(DialogUnmutedUpdate.ChatIdField)]
    long ChatId,
    [property: JsonPropertyName(DialogUnmutedUpdate.UserField)] 
    User User,
    [property: JsonPropertyName(DialogUnmutedUpdate.UserLocaleField)] 
    string? UserLocale = null
) : Update(Timestamp)
{
    public const string TypeValue = "dialog_unmuted";
    public const string ChatIdField = "chat_id";
    public const string UserField = "user";
    public const string UserLocaleField = "user_locale";
}
