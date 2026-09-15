namespace MaxBots;

public sealed record ChatTitleChangedUpdate(
    long Timestamp,
    [property: JsonPropertyName(ChatIdField)] long ChatId,
    [property: JsonPropertyName(UserField)] User User,
    [property: JsonPropertyName(TitleField)] string Title
) : Update(Timestamp)
{
    public const string TypeValue = "chat_title_changed";
    public const string ChatIdField = "chat_id";
    public const string UserField = "user";
    public const string TitleField = "title";
}
