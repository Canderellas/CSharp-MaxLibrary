namespace MaxBots;

public sealed record ChatAdmin(
    [property: JsonPropertyName(ChatAdmin.UserIdField)] long UserId,
    [property: JsonPropertyName(ChatAdmin.PermissionsField)] IReadOnlyList<string>? Permissions = null
)
{
    public const string UserIdField = "user_id";
    public const string PermissionsField = "permissions";
}
