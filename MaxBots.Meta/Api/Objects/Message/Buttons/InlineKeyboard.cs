namespace MaxBots;

public sealed record InlineKeyboard(
    [property: JsonPropertyName(ButtonsField)]
        IReadOnlyList<IReadOnlyList<InlineKeyboardButton>> Buttons
)
{
    public const string ButtonsField = "buttons";
}
