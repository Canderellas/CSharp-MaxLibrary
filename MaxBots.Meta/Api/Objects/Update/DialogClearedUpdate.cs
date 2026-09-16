namespace MaxBots;

public sealed record DialogClearedUpdate(
    long Timestamp,
    [property: JsonPropertyName(DialogClearedUpdate.ChatIdField)]
    long ChatId,
    [property: JsonPropertyName(DialogClearedUpdate.UserField)] 
    User User,
    [property: JsonPropertyName(DialogClearedUpdate.UserLocaleField)]
    string? UserLocale = null
) : Update(Timestamp)
{
    public const string TypeValue = "dialog_cleared";
    public const string ChatIdField = "chat_id";
    public const string UserField = "user";
    public const string UserLocaleField = "user_locale";
}
