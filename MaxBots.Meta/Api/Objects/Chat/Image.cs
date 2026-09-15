namespace MaxBots;

public sealed record Image([property: JsonPropertyName(UrlField)] string Url)
{
    public const string UrlField = "url";
}
