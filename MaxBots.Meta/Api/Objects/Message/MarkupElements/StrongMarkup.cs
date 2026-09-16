namespace MaxBots;

public sealed record StrongMarkup(
    int From,
    int Length
) : MarkupElement(TypeValue, From, Length)
{
    public const string TypeValue = "strong";
}
