namespace MaxBots;

public sealed record ChatMember(
    long UserId,
    string FirstName,
    string? LastName = null,
    string? Username = null,
    bool IsBot = false,
    long LastActivityTime = 0,
    [property: JsonPropertyName(IsOwnerField)] bool IsOwner = false,
    [property: JsonPropertyName(IsAdminField)] bool IsAdmin = false
) : User(UserId, FirstName, LastName, Username, IsBot, LastActivityTime)
{
    public const string IsOwnerField = "is_owner";
    public const string IsAdminField = "is_admin";
}
