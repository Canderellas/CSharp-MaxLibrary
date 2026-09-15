namespace MaxBots;

[JsonPolymorphic(TypeDiscriminatorPropertyName = UpdateTypeField)]
[JsonDerivedType(typeof(MessageCreatedUpdate), MessageCreatedUpdate.TypeValue)]
[JsonDerivedType(typeof(MessageCallbackUpdate), MessageCallbackUpdate.TypeValue)]
[JsonDerivedType(typeof(MessageEditedUpdate), MessageEditedUpdate.TypeValue)]
[JsonDerivedType(typeof(MessageRemovedUpdate), MessageRemovedUpdate.TypeValue)]
[JsonDerivedType(typeof(BotAddedUpdate), BotAddedUpdate.TypeValue)]
[JsonDerivedType(typeof(BotRemovedUpdate), BotRemovedUpdate.TypeValue)]
[JsonDerivedType(typeof(DialogMutedUpdate), DialogMutedUpdate.TypeValue)]
[JsonDerivedType(typeof(DialogUnmutedUpdate), DialogUnmutedUpdate.TypeValue)]
[JsonDerivedType(typeof(DialogClearedUpdate), DialogClearedUpdate.TypeValue)]
[JsonDerivedType(typeof(DialogRemovedUpdate), DialogRemovedUpdate.TypeValue)]
[JsonDerivedType(typeof(UserAddedUpdate), UserAddedUpdate.TypeValue)]
[JsonDerivedType(typeof(UserRemovedUpdate), UserRemovedUpdate.TypeValue)]
[JsonDerivedType(typeof(BotStartedUpdate), BotStartedUpdate.TypeValue)]
[JsonDerivedType(typeof(BotStoppedUpdate), BotStoppedUpdate.TypeValue)]
[JsonDerivedType(typeof(ChatTitleChangedUpdate), ChatTitleChangedUpdate.TypeValue)]
public abstract record Update([property: JsonPropertyName(TimestampField)] long Timestamp)
{
    public const string UpdateTypeField = "update_type";
    public const string TimestampField = "timestamp";
}
