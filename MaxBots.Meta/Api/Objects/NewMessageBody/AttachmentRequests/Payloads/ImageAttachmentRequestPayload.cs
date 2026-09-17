namespace MaxBots;

public sealed record ImageAttachmentRequestPayload(
    [property: JsonPropertyName(ImageAttachmentRequestPayload.UrlField)]
    string? Url = null,
    [property: JsonPropertyName(ImageAttachmentRequestPayload.TokenField)]
    string? Token = null,
    [property: JsonPropertyName(ImageAttachmentRequestPayload.PhotosField)]
    IReadOnlyList<PhotoToken>? Photos = null
) : AttachmentRequestPayload
{
    public const string UrlField = "url";
    public const string TokenField = "token";
    public const string PhotosField = "photos";
}