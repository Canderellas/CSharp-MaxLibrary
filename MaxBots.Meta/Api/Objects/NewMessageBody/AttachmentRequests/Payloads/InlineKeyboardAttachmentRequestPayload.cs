namespace MaxBots;

public sealed record InlineKeyboardAttachmentRequestPayload(
    [property: JsonPropertyName(InlineKeyboardAttachmentRequestPayload.ButtonsField)]
    IReadOnlyList<IReadOnlyList<InlineKeyboardButton>> Buttons
) : AttachmentRequestPayload
{
    public const string ButtonsField = "buttons";
}