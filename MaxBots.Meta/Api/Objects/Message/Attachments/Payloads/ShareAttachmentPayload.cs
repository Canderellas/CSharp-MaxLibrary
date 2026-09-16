namespace MaxBots;

public sealed record ShareAttachmentPayload(
    [property: JsonPropertyName(ShareAttachmentPayload.UrlField)]
    string Url,
    [property: JsonPropertyName(ShareAttachmentPayload.TokenField)]
    string Token
)
{
    public const string UrlField = "url";
    public const string TokenField = "token";
}
