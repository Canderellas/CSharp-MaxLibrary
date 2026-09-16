namespace MaxBots;

[JsonPolymorphic(TypeDiscriminatorPropertyName = AttachmentRequest.TypeField)]
[JsonDerivedType(typeof(ImageAttachmentRequest), ImageAttachmentRequest.TypeValue)]
[JsonDerivedType(typeof(VideoAttachmentRequest), VideoAttachmentRequest.TypeValue)]
[JsonDerivedType(typeof(AudioAttachmentRequest), AudioAttachmentRequest.TypeValue)]
[JsonDerivedType(typeof(FileAttachmentRequest), FileAttachmentRequest.TypeValue)]
[JsonDerivedType(typeof(StickerAttachmentRequest), StickerAttachmentRequest.TypeValue)]
[JsonDerivedType(typeof(ContactAttachmentRequest), ContactAttachmentRequest.TypeValue)]
[JsonDerivedType(typeof(ShareAttachmentRequest), ShareAttachmentRequest.TypeValue)]
[JsonDerivedType(
    typeof(InlineKeyboardAttachmentRequest),
    InlineKeyboardAttachmentRequest.TypeValue
)]
[JsonDerivedType(typeof(LocationAttachmentRequest), LocationAttachmentRequest.TypeValue)]
public abstract record AttachmentRequest([property: JsonIgnore] string Type)
{
    public const string TypeField = "type";
}
