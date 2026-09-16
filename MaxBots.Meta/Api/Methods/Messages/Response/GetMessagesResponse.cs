namespace MaxBots;

public sealed record GetMessagesResponse(
    [property: JsonPropertyName(GetMessagesResponse.MessagesField)]
    IReadOnlyList<Message> Messages
)
{
    public const string MessagesField = "messages";
}
