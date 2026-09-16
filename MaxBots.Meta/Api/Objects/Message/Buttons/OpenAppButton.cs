namespace MaxBots;

public sealed record OpenAppButton(
    string Text,
    [property: JsonPropertyName(OpenAppButton.WebAppField)]
    string WebApp,
    [property: JsonPropertyName(OpenAppButton.ContactIdField)]
    long ContactId,
    [property: JsonPropertyName(OpenAppButton.PayloadField)]
    string Payload
) : InlineKeyboardButton(TypeValue, Text)
{
    public const string TypeValue = "open_app";
    public const string WebAppField = "web_app";
    public const string ContactIdField = "contact_id";
    public const string PayloadField = "payload";
}
