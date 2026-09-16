namespace MaxBots;

public sealed record UserWithPhoto(
    long UserId,
    string FirstName,
    string? LastName = null,
    string? Username = null,
    bool IsBot = false,
    long LastActivityTime = 0,
    [property: JsonPropertyName(UserWithPhoto.AvatarUrlField)]
    string? PhotoUrl = null
) : User(UserId, FirstName, LastName, Username, IsBot, LastActivityTime)
{
    public const string AvatarUrlField = "avatar_url";
}
