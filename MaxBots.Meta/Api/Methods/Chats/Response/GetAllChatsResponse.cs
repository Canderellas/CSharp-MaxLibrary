namespace MaxBots;

public sealed record GetAllChatsResponse(
    [property: JsonPropertyName(GetAllChatsResponse.ChatsField)]
    IReadOnlyList<Chat> Chats,
    [property: JsonPropertyName(GetAllChatsResponse.MarkerField)]
    long? Marker = null
)
{
    public const string ChatsField = "chats";
    public const string MarkerField = "marker";
}
