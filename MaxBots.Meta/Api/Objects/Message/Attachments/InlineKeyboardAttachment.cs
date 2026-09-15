namespace MaxBots;

public sealed record InlineKeyboardAttachment(
    [property: JsonPropertyName(PayloadField)] InlineKeyboard Payload
) : Attachment(TypeValue)
{
    public const string TypeValue = "inline_keyboard";
    public const string PayloadField = "payload";
}
