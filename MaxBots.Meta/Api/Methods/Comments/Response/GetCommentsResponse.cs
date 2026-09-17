namespace MaxBots;

public sealed record GetCommentsResponse(
    [property: JsonPropertyName(GetCommentsResponse.MessagesField)]
    IReadOnlyList<CommentMessage>? Messages = null
)
{
    public const string MessagesField = "messages";
}