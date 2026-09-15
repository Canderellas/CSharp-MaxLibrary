namespace MaxBots;

public sealed record CallbackButton(
    string Text,
    [property: JsonPropertyName(PayloadField)] string Payload,
    [property: JsonPropertyName(IntentField)] string? Intent = "default"
) : InlineKeyboardButton(TypeValue, Text)
{
    public const string TypeValue = "callback";
    public const string PayloadField = "payload";
    public const string IntentField = "intent";
}
