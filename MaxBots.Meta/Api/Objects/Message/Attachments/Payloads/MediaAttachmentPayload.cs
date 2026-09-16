namespace MaxBots;

public sealed record MediaAttachmentPayload(
    [property: JsonPropertyName(MediaAttachmentPayload.UrlField)]
    string Url,
    [property: JsonPropertyName(MediaAttachmentPayload.TokenField)]
    string Token
)
{
    public const string UrlField = "url";
    public const string TokenField = "token";
}
