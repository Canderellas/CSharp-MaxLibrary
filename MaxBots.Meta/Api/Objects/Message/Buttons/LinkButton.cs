namespace MaxBots;

public sealed record LinkButton(string Text, [property: JsonPropertyName(UrlField)] string Url)
    : InlineKeyboardButton(TypeValue, Text)
{
    public const string TypeValue = "link";
    public const string UrlField = "url";
}
