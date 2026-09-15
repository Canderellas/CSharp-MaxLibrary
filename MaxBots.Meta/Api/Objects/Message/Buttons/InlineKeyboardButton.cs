namespace MaxBots;

[JsonPolymorphic(TypeDiscriminatorPropertyName = TypeField)]
[JsonDerivedType(typeof(CallbackButton), CallbackButton.TypeValue)]
[JsonDerivedType(typeof(LinkButton), LinkButton.TypeValue)]
[JsonDerivedType(typeof(MessageButton), MessageButton.TypeValue)]
[JsonDerivedType(typeof(RequestContactButton), RequestContactButton.TypeValue)]
[JsonDerivedType(typeof(RequestGeoLocationButton), RequestGeoLocationButton.TypeValue)]
[JsonDerivedType(typeof(OpenAppButton), OpenAppButton.TypeValue)]
public abstract record InlineKeyboardButton(
    [property: JsonIgnore] string Type,
    [property: JsonPropertyName(TextField)] string Text
)
{
    public const string TypeField = "type";
    public const string TextField = "text";
}
