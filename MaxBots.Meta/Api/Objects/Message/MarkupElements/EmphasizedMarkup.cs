namespace MaxBots;

public sealed record EmphasizedMarkup(int From, int Length) : MarkupElement(TypeValue, From, Length)
{
    public const string TypeValue = "emphasized";
}
