namespace MaxBots;

public sealed record Subscription([property: JsonPropertyName(UrlField)] string Url)
{
    public const string UrlField = "url";
}
