namespace MaxBots;

public sealed record InlineKeyboardAttachmentRequest(
    [property: JsonPropertyName(InlineKeyboardAttachmentRequest.PayloadField)]
    InlineKeyboard Payload
) : AttachmentRequest(TypeValue)
{
    public const string TypeValue = "inline_keyboard";
    public const string PayloadField = "payload";
}
