namespace MaxBots;

public sealed record VideoAttachment(
    [property: JsonPropertyName(VideoAttachment.PayloadField)]
    MediaAttachmentPayload Payload,
    [property: JsonPropertyName(VideoAttachment.ThumbnailField)]
    VideoThumbnail? Thumbnail = null,
    [property: JsonPropertyName(VideoAttachment.WidthField)]
    int? Width = null,
    [property: JsonPropertyName(VideoAttachment.HeightField)]
    int? Height = null,
    [property: JsonPropertyName(VideoAttachment.DurationField)]
    int? Duration = null
) : Attachment(TypeValue)
{
    public const string TypeValue = "video";
    public const string PayloadField = "payload";
    public const string ThumbnailField = "thumbnail";
    public const string WidthField = "width";
    public const string HeightField = "height";
    public const string DurationField = "duration";
}
