namespace MaxBots;

public sealed record Image(
    [property: JsonPropertyName(Image.UrlField)]
    string Url
)
{
    public const string UrlField = "url";
}
