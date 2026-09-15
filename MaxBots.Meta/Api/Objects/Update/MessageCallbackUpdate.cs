namespace MaxBots;

public sealed record MessageCallbackUpdate(
    long Timestamp,
    [property: JsonPropertyName(CallbackField)] Callback Callback,
    [property: JsonPropertyName(MessageField)] Message? Message = null,
    [property: JsonPropertyName(UserLocaleField)] string? UserLocale = null
) : Update(Timestamp)
{
    public const string TypeValue = "message_callback";
    public const string CallbackField = "callback";
    public const string MessageField = "message";
    public const string UserLocaleField = "user_locale";
}
