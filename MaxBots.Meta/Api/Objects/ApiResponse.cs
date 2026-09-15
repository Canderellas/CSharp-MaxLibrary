namespace MaxBots;

public sealed record ApiResponse<T>(
    [property: JsonPropertyName(OkField)] bool? Ok = null,
    [property: JsonPropertyName(ErrorCodeField)] int? ErrorCode = null,
    [property: JsonPropertyName(DescriptionField)] string? Description = null,
    [property: JsonPropertyName(ParametersField)] ResponseParameters? Parameters = null,
    [property: JsonPropertyName(ResultField)] T? Result = default
)
{
    public const string OkField = "ok";
    public const string ErrorCodeField = "error_code";
    public const string DescriptionField = "description";
    public const string ParametersField = "parameters";
    public const string ResultField = "result";
}
