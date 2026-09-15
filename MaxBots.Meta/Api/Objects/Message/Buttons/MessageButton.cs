namespace MaxBots;

public sealed record MessageButton(string Text) : InlineKeyboardButton(TypeValue, Text)
{
    public const string TypeValue = "message";
}
