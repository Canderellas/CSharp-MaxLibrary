namespace MaxBots;

public sealed record MessageEditedUpdate(
    long Timestamp,
    [property: JsonPropertyName(MessageField)] Message Message,
    [property: JsonPropertyName(UserLocaleField)] string? UserLocale = null
) : Update(Timestamp)
{
    public const string TypeValue = "message_edited";
    public const string MessageField = "message";
    public const string UserLocaleField = "user_locale";
}
