namespace MaxBots;

public sealed record ShareAttachment(
    [property: JsonPropertyName(ShareAttachment.PayloadField)]
    ShareAttachmentPayload Payload,
    [property: JsonPropertyName(ShareAttachment.TitleField)]
    string? Title = null,
    [property: JsonPropertyName(ShareAttachment.DescriptionField)]
    string? Description = null,
    [property: JsonPropertyName(ShareAttachment.ImageUrlField)]
    string? ImageUrl = null
) : Attachment(TypeValue)
{
    public const string TypeValue = "share";
    public const string PayloadField = "payload";
    public const string TitleField = "title";
    public const string DescriptionField = "description";
    public const string ImageUrlField = "image_url";
}
