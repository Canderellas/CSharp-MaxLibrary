namespace MaxBots;

public sealed record VideoThumbnail(
    [property: JsonPropertyName(VideoThumbnail.UrlField)]
    string Url
)
{
    public const string UrlField = "url";
}
