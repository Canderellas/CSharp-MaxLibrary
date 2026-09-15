namespace MaxBots;

public sealed record UploadedInfoPayload(
    [property: JsonPropertyName(TokenField)] string Token,
    [property: JsonPropertyName(TypeField)] string Type
)
{
    public const string TokenField = "token";
    public const string TypeField = "type";
}
