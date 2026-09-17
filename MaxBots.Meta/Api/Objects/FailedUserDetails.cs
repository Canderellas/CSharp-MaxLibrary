namespace MaxBots;

public sealed record FailedUserDetails(
    [property: JsonPropertyName(FailedUserDetails.ErrorCodeField)]
    string ErrorCode,
    [property: JsonPropertyName(FailedUserDetails.UserIdsField)]
    IReadOnlyList<long> UserIds
)
{
    public const string ErrorCodeField = "error_code";
    public const string UserIdsField = "user_ids";
}