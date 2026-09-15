namespace MaxBots;

public sealed record ApiResponse<T>(
    [property: JsonPropertyName(ApiResponse<T>.OkField)] bool? Ok = null,
    [property: JsonPropertyName(ApiResponse<T>.ErrorCodeField)] int? ErrorCode = null,
    [property: JsonPropertyName(ApiResponse<T>.DescriptionField)] string? Description = null,
    [property: JsonPropertyName(ApiResponse<T>.ParametersField)] ResponseParameters? Parameters = null,
    [property: JsonPropertyName(ApiResponse<T>.ResultField)] T? Result = default
)
{
    public const string OkField = "ok";
    public const string ErrorCodeField = "error_code";
    public const string DescriptionField = "description";
    public const string ParametersField = "parameters";
    public const string ResultField = "result";
}
