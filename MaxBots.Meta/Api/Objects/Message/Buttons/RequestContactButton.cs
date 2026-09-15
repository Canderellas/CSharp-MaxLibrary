namespace MaxBots;

public sealed record RequestContactButton(string Text) : InlineKeyboardButton(TypeValue, Text)
{
    public const string TypeValue = "request_contact";
}
