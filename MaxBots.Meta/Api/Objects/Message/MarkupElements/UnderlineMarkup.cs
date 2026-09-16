namespace MaxBots;

public sealed record UnderlineMarkup(
    int From,
    int Length
) : MarkupElement(TypeValue, From, Length)
{
    public const string TypeValue = "underline";
}
