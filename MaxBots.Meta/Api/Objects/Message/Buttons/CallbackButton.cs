namespace MaxBots;

public sealed record CallbackButton(
    string Text,
    [property: JsonPropertyName(CallbackButton.PayloadField)]
    string Payload,
    [property: JsonPropertyName(CallbackButton.IntentField)]
    Intent? Intent = Intent.Default
) : InlineKeyboardButton(TypeValue, Text)
{
    public const string TypeValue = "callback";
    public const string PayloadField = "payload";
    public const string IntentField = "intent";
}
