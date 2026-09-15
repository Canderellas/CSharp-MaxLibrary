namespace MaxBots;

public sealed record Subscription([property: JsonPropertyName(Subscription.UrlField)] string Url)
{
    public const string UrlField = "url";
}
