namespace MaxBots;

public record UserWithPhoto(
    long UserId,
    string FirstName,
    string? LastName = null,
    string? Username = null,
    bool IsBot = false,
    long LastActivityTime = 0,
    [property: JsonPropertyName(BotInfo.DescriptionField)]
    string? Description = null,
    [property: JsonPropertyName(UserWithPhoto.AvatarUrlField)]
    string? AvatarUrl = null,
    [property: JsonPropertyName(UserWithPhoto.FullAvatarUrlField)]
    string? FullAvatarUrl = null
) : User(UserId, FirstName, LastName, Username, IsBot, LastActivityTime)
{
    public const string AvatarUrlField = "avatar_url";
    public const string FullAvatarUrlField = "full_avatar_url";
}
