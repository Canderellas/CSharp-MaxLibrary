namespace MaxBots;

public sealed record MessageCreatedUpdate(
    long Timestamp,
    [property: JsonPropertyName(MessageField)] Message? Message = null,
    [property: JsonPropertyName(UserLocaleField)] string? UserLocale = null
) : Update(Timestamp)
{
    public const string TypeValue = "message_created";
    public const string MessageField = "message";
    public const string UserLocaleField = "user_locale";
}
