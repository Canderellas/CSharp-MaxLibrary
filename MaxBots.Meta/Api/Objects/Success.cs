namespace MaxBots;

public record Success(
    [property: JsonPropertyName(Success.SuccessField)]
    bool IsSuccess = true,
    [property: JsonPropertyName(Success.MessageField)]
    string? Message = null
)
{
    public const string SuccessField = "success";
    public const string MessageField = "message";
}
