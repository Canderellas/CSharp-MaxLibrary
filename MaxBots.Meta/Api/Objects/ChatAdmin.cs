namespace MaxBots;

public sealed record ChatAdmin(
    [property: JsonPropertyName(UserIdField)] long UserId,
    [property: JsonPropertyName(PermissionsField)] IReadOnlyList<string>? Permissions = null
)
{
    public const string UserIdField = "user_id";
    public const string PermissionsField = "permissions";
}
