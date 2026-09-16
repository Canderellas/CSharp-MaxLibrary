namespace MaxBots;

public sealed record ChatMembersResponse(
    [property: JsonPropertyName(ChatMembersResponse.MembersField)]
    IReadOnlyList<ChatMember> Members,
    [property: JsonPropertyName(ChatMembersResponse.MarkerField)]
    long? Marker = null
)
{
    public const string MembersField = "members";
    public const string MarkerField = "marker";
}
