namespace MaxBots;

public sealed record RequestGeoLocationButton(
    string Text,
    [property: JsonPropertyName(RequestGeoLocationButton.QuickField)]
    bool Quick
) : InlineKeyboardButton(TypeValue, Text)
{
    public const string TypeValue = "request_geo_location";
    public const string QuickField = "quick";
}
