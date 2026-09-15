namespace MaxBots;

public sealed record GetAllChatsResponse(
    [property: JsonPropertyName(ChatsField)] IReadOnlyList<Chat> Chats,
    [property: JsonPropertyName(MarkerField)] long? Marker = null
)
{
    public const string ChatsField = "chats";
    public const string MarkerField = "marker";
}
