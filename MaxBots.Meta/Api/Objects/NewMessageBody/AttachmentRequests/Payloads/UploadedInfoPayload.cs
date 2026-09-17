namespace MaxBots;

public sealed record UploadedInfoPayload(
    [property: JsonPropertyName(UploadedInfoPayload.TokenField)]
    string Token
) : AttachmentRequestPayload
{
    public const string TokenField = "token";
}