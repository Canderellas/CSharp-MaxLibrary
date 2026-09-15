namespace MaxBots;

public record User(
    [property: JsonPropertyName(User.UserIdField)] long UserId,
    [property: JsonPropertyName(User.FirstNameField)] string FirstName,
    [property: JsonPropertyName(User.LastNameField)] string? LastName = null,
    [property: JsonPropertyName(User.UsernameField)] string? Username = null,
    [property: JsonPropertyName(User.IsBotField)] bool IsBot = false,
    [property: JsonPropertyName(User.LastActivityTimeField)] long LastActivityTime = 0
)
{
    public const string UserIdField = "user_id";
    public const string FirstNameField = "first_name";
    public const string LastNameField = "last_name";
    public const string UsernameField = "username";
    public const string IsBotField = "is_bot";
    public const string LastActivityTimeField = "last_activity_time";
}
