namespace MaxBots;

[JsonPolymorphic(TypeDiscriminatorPropertyName = Attachment.TypeField)]
[JsonDerivedType(typeof(ImageAttachment), ImageAttachment.TypeValue)]
[JsonDerivedType(typeof(AudioAttachment), AudioAttachment.TypeValue)]
[JsonDerivedType(typeof(VideoAttachment), VideoAttachment.TypeValue)]
[JsonDerivedType(typeof(FileAttachment), FileAttachment.TypeValue)]
[JsonDerivedType(typeof(StickerAttachment), StickerAttachment.TypeValue)]
[JsonDerivedType(typeof(ContactAttachment), ContactAttachment.TypeValue)]
[JsonDerivedType(typeof(ShareAttachment), ShareAttachment.TypeValue)]
[JsonDerivedType(typeof(LocationAttachment), LocationAttachment.TypeValue)]
[JsonDerivedType(typeof(InlineKeyboardAttachment), InlineKeyboardAttachment.TypeValue)]
public abstract record Attachment([property: JsonIgnore] string Type)
{
    public const string TypeField = "type";
}
