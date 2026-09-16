namespace MaxBots;

public sealed record MessageCallbackUpdate(
    long Timestamp,
    [property: JsonPropertyName(MessageCallbackUpdate.CallbackField)]
    Callback Callback,
    [property: JsonPropertyName(MessageCallbackUpdate.MessageField)]
    Message? Message = null,
    [property: JsonPropertyName(MessageCallbackUpdate.UserLocaleField)]
    string? UserLocale = null
) : Update(Timestamp)
{
    public const string TypeValue = "message_callback";
    public const string CallbackField = "callback";
    public const string MessageField = "message";
    public const string UserLocaleField = "user_locale";
}
