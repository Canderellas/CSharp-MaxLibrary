namespace MaxBots;

public sealed record OpenAppButton(
    string Text,
    [property: JsonPropertyName(WebAppField)] string WebApp,
    [property: JsonPropertyName(ContactIdField)] long ContactId,
    [property: JsonPropertyName(PayloadField)] string Payload
) : InlineKeyboardButton(TypeValue, Text)
{
    public const string TypeValue = "open_app";
    public const string WebAppField = "web_app";
    public const string ContactIdField = "contact_id";
    public const string PayloadField = "payload";
}
