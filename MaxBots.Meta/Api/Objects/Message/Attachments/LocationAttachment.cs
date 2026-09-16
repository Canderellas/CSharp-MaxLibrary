namespace MaxBots;

public sealed record LocationAttachment(
    [property: JsonPropertyName(LocationAttachment.LatitudeField)]
    double Latitude,
    [property: JsonPropertyName(LocationAttachment.LongitudeField)]
    double Longitude
) : Attachment(TypeValue)
{
    public const string TypeValue = "location";
    public const string LatitudeField = "latitude";
    public const string LongitudeField = "longitude";
}
