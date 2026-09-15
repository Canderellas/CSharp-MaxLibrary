namespace MaxBots;

public sealed record Chat(
    [property: JsonPropertyName(ChatIdField)] long ChatId,
    [property: JsonPropertyName(TypeField)] string? Type = null,
    [property: JsonPropertyName(StatusField)] string? Status = null,
    [property: JsonPropertyName(TitleField)] string? Title = null,
    [property: JsonPropertyName(IconField)] Image? Icon = null,
    [property: JsonPropertyName(LastEventTimeField)] long? LastEventTime = null,
    [property: JsonPropertyName(ParticipantsCountField)] int? ParticipantsCount = null
)
{
    public const string ChatIdField = "chat_id";
    public const string TypeField = "type";
    public const string StatusField = "status";
    public const string TitleField = "title";
    public const string IconField = "icon";
    public const string LastEventTimeField = "last_event_time";
    public const string ParticipantsCountField = "participants_count";
}
