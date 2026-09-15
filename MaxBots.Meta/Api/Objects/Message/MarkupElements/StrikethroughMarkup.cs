namespace MaxBots;

public sealed record StrikethroughMarkup(int From, int Length)
    : MarkupElement(TypeValue, From, Length)
{
    public const string TypeValue = "strikethrough";
}
