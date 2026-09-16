namespace MaxBots;

public sealed record UploadedInfoPayload(
    [property: JsonPropertyName(UploadedInfoPayload.TokenField)]
    string Token,
    [property: JsonPropertyName(UploadedInfoPayload.TypeField)] 
    string Type
)
{
    public const string TokenField = "token";
    public const string TypeField = "type";
}
