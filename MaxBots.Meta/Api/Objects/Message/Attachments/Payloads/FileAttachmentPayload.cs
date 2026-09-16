namespace MaxBots;

public sealed record FileAttachmentPayload(
    [property: JsonPropertyName(FileAttachmentPayload.UrlField)]
    string Url,
    [property: JsonPropertyName(FileAttachmentPayload.TokenField)]
    string Token
)
{
    public const string UrlField = "url";
    public const string TokenField = "token";
}
