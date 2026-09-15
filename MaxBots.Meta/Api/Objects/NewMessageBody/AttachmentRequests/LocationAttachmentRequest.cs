namespace MaxBots;

public sealed record LocationAttachmentRequest(
    [property: JsonPropertyName(LatitudeField)] double Latitude,
    [property: JsonPropertyName(LongitudeField)] double Longitude
) : AttachmentRequest(TypeValue)
{
    public const string TypeValue = "location";
    public const string LatitudeField = "latitude";
    public const string LongitudeField = "longitude";
}
