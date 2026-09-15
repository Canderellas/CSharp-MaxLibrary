namespace MaxBots;

public sealed record BotInfo(
    long UserId,
    string FirstName,
    string? LastName = null,
    string? Username = null,
    bool IsBot = true,
    long LastActivityTime = 0,
    [property: JsonPropertyName(DescriptionField)] string? Description = null,
    [property: JsonPropertyName(AvatarUrlField)] string? AvatarUrl = null,
    [property: JsonPropertyName(FullAvatarUrlField)] string? FullAvatarUrl = null,
    [property: JsonPropertyName(CommandsField)] IReadOnlyList<BotCommand>? Commands = null
) : User(UserId, FirstName, LastName, Username, IsBot, LastActivityTime)
{
    public const string DescriptionField = "description";
    public const string AvatarUrlField = "avatar_url";
    public const string FullAvatarUrlField = "full_avatar_url";
    public const string CommandsField = "commands";
}
