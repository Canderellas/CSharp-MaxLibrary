namespace MaxBots;

public sealed record ShareAttachment(
    [property: JsonPropertyName(PayloadField)] ShareAttachmentPayload Payload,
    [property: JsonPropertyName(TitleField)] string? Title = null,
    [property: JsonPropertyName(DescriptionField)] string? Description = null,
    [property: JsonPropertyName(ImageUrlField)] string? ImageUrl = null
) : Attachment(TypeValue)
{
    public const string TypeValue = "share";
    public const string PayloadField = "payload";
    public const string TitleField = "title";
    public const string DescriptionField = "description";
    public const string ImageUrlField = "image_url";
}
