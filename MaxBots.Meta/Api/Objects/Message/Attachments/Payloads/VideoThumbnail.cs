namespace MaxBots;

public sealed record VideoThumbnail([property: JsonPropertyName(UrlField)] string Url)
{
    public const string UrlField = "url";
}
