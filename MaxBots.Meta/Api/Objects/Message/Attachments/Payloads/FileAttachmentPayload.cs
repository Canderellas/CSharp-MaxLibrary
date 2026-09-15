namespace MaxBots;

public sealed record FileAttachmentPayload(
    [property: JsonPropertyName(UrlField)] string Url,
    [property: JsonPropertyName(TokenField)] string Token
)
{
    public const string UrlField = "url";
    public const string TokenField = "token";
}
