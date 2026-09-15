namespace MaxBots;

public sealed record GetMessagesResponse(
    [property: JsonPropertyName(MessagesField)] IReadOnlyList<Message> Messages
)
{
    public const string MessagesField = "messages";
}
