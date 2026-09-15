namespace MaxBots;

public sealed record ChatMembersResponse(
    [property: JsonPropertyName(MembersField)] IReadOnlyList<ChatMember> Members,
    [property: JsonPropertyName(MarkerField)] long? Marker = null
)
{
    public const string MembersField = "members";
    public const string MarkerField = "marker";
}
