namespace MaxBots;

public sealed record FailedPostMessageResponse(
    [property: JsonPropertyName(FailedPostMessageResponse.CodeField)]
    string? Code = null,
    [property: JsonPropertyName(FailedPostMessageResponse.MessageField)]
    string? Message = null
)
{
    public const string CodeField = "code";
    public const string MessageField = "message";
}