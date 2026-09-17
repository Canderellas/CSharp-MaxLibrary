namespace MaxBots;

public sealed record ChatMember(
    long UserId,
    string FirstName,
    string? LastName = null,
    string? Username = null,
    bool IsBot = false,
    long LastActivityTime = 0,
    string? Description = null,
    string? AvatarUrl = null,
    string? FullAvatarUrl = null,
    [property: JsonPropertyName(ChatMember.IsOwnerField)]
    bool IsOwner = false,
    [property: JsonPropertyName(ChatMember.IsAdminField)]
    bool IsAdmin = false,
    [property: JsonPropertyName(ChatMember.JoinTimeField)]
    long JoinTime = 0,
    [property: JsonPropertyName(ChatMember.PermissionsField)]
    List<ChatAdminPermissions>? Permissions = null,
    [property: JsonPropertyName(ChatMember.AliasField)]
    string? alias = null
) : UserWithPhoto(UserId, FirstName, LastName, Username, IsBot, LastActivityTime, Description,AvatarUrl, FullAvatarUrl)
{
    public const string IsOwnerField = "is_owner";
    public const string IsAdminField = "is_admin";
    public const string JoinTimeField = "join_time";
    public const string PermissionsField = "permissions";
    public const string AliasField = "alias";
}
