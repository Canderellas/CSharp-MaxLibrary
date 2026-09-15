namespace MaxBots;

[JsonPolymorphic(TypeDiscriminatorPropertyName = TypeField)]
[JsonDerivedType(typeof(StrongMarkup), StrongMarkup.TypeValue)]
[JsonDerivedType(typeof(EmphasizedMarkup), EmphasizedMarkup.TypeValue)]
[JsonDerivedType(typeof(UnderlineMarkup), UnderlineMarkup.TypeValue)]
[JsonDerivedType(typeof(StrikethroughMarkup), StrikethroughMarkup.TypeValue)]
[JsonDerivedType(typeof(MonospacedMarkup), MonospacedMarkup.TypeValue)]
[JsonDerivedType(typeof(LinkMarkup), LinkMarkup.TypeValue)]
[JsonDerivedType(typeof(UserMentionMarkup), UserMentionMarkup.TypeValue)]
public abstract record MarkupElement(
    [property: JsonIgnore] string Type,
    [property: JsonPropertyName(FromField)] int From,
    [property: JsonPropertyName(LengthField)] int Length
)
{
    public const string TypeField = "type";
    public const string FromField = "from";
    public const string LengthField = "length";
}
