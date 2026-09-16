namespace MaxBots;

public sealed record UserMentionMarkup(
    int From,
    int Length,
    [property: JsonPropertyName(UserMentionMarkup.UserIdField)]
    long UserId
) : MarkupElement(TypeValue, From, Length)
{
    public const string TypeValue = "user_mention";
    public const string UserIdField = "user_id";
}
