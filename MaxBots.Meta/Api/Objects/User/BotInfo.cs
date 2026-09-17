namespace MaxBots;

public sealed record BotInfo(
    long UserId,
    string FirstName,
    string? LastName = null,
    string? Username = null,
    bool IsBot = true,
    long LastActivityTime = 0,
    string? Description = null,
    string? AvatarUrl = null,
    string? FullAvatarUrl = null,
    [property: JsonPropertyName(BotInfo.CommandsField)]
    IReadOnlyList<BotCommand>? Commands = null
) : UserWithPhoto(UserId, FirstName, LastName, Username, IsBot, LastActivityTime, Description,AvatarUrl, FullAvatarUrl)
{
    public const string DescriptionField = "description";
    public const string AvatarUrlField = "avatar_url";
    public const string FullAvatarUrlField = "full_avatar_url";
    public const string CommandsField = "commands";
}
