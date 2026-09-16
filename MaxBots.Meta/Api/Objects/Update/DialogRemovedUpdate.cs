namespace MaxBots;

public sealed record DialogRemovedUpdate(
    long Timestamp,
    [property: JsonPropertyName(DialogRemovedUpdate.ChatIdField)]
    long ChatId,
    [property: JsonPropertyName(DialogRemovedUpdate.UserField)] 
    User User,
    [property: JsonPropertyName(DialogRemovedUpdate.UserLocaleField)]
    string? UserLocale = null
) : Update(Timestamp)
{
    public const string TypeValue = "dialog_removed";
    public const string ChatIdField = "chat_id";
    public const string UserField = "user";
    public const string UserLocaleField = "user_locale";
}
