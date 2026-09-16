namespace MaxBots;

public sealed record LinkMarkup(
    int From,
    int Length,
    [property: JsonPropertyName(LinkMarkup.UrlField)]
    string Url
) : MarkupElement(TypeValue, From, Length)
{
    public const string TypeValue = "link";
    public const string UrlField = "url";
}
