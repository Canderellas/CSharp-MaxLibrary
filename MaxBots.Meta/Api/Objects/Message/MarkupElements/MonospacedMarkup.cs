namespace MaxBots;

public sealed record MonospacedMarkup(int From, int Length) : MarkupElement(TypeValue, From, Length)
{
    public const string TypeValue = "monospaced";
}
