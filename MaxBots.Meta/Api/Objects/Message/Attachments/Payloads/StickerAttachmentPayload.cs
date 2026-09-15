namespace MaxBots;

public sealed record StickerAttachmentPayload(
    [property: JsonPropertyName(UrlField)] string Url,
    [property: JsonPropertyName(CodeField)] string Code
)
{
    public const string UrlField = "url";
    public const string CodeField = "code";
}
