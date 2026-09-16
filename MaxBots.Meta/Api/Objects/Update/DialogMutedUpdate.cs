namespace MaxBots;

public sealed record DialogMutedUpdate(
    long Timestamp,
    [property: JsonPropertyName(DialogMutedUpdate.ChatIdField)]
    long ChatId,
    [property: JsonPropertyName(DialogMutedUpdate.UserField)]
    User User,
    [property: JsonPropertyName(DialogMutedUpdate.MutedUntilField)] 
    long MutedUntil,
    [property: JsonPropertyName(DialogMutedUpdate.UserLocaleField)] 
    string? UserLocale = null
) : Update(Timestamp)
{
    public const string TypeValue = "dialog_muted";
    public const string ChatIdField = "chat_id";
    public const string UserField = "user";
    public const string MutedUntilField = "muted_until";
    public const string UserLocaleField = "user_locale";
}
