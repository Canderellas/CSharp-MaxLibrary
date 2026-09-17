namespace MaxBots;

public sealed record Chat(
    [property: JsonPropertyName(Chat.ChatIdField)]
    long ChatId,
    [property: JsonPropertyName(Chat.TypeField)]
    ChatType? Type = null,
    [property: JsonPropertyName(Chat.StatusField)]
    ChatStatus? Status = null,
    [property: JsonPropertyName(Chat.TitleField)]
    string? Title = null,
    [property: JsonPropertyName(Chat.IconField)]
    Image? Icon = null,
    [property: JsonPropertyName(Chat.LastEventTimeField)]
    long? LastEventTime = null,
    [property: JsonPropertyName(Chat.ParticipantsCountField)]
    int? ParticipantsCount = null
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
