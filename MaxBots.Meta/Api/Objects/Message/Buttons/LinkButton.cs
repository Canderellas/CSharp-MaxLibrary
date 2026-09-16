namespace MaxBots;

public sealed record LinkButton(
    string Text, 
    [property: JsonPropertyName(LinkButton.UrlField)]
    string Url
) : InlineKeyboardButton(TypeValue, Text)
{
    public const string TypeValue = "link";
    public const string UrlField = "url";
}
    