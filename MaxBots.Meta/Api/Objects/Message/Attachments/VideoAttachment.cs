namespace MaxBots;

public sealed record VideoAttachment(
    [property: JsonPropertyName(PayloadField)] MediaAttachmentPayload Payload,
    [property: JsonPropertyName(ThumbnailField)] VideoThumbnail? Thumbnail = null,
    [property: JsonPropertyName(WidthField)] int? Width = null,
    [property: JsonPropertyName(HeightField)] int? Height = null,
    [property: JsonPropertyName(DurationField)] int? Duration = null
) : Attachment(TypeValue)
{
    public const string TypeValue = "video";
    public const string PayloadField = "payload";
    public const string ThumbnailField = "thumbnail";
    public const string WidthField = "width";
    public const string HeightField = "height";
    public const string DurationField = "duration";
}
