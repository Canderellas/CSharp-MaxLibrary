namespace MaxBots;

public sealed record PhotoToken(
    [property: JsonPropertyName(PhotoToken.TokenField)] 
    string Token
)
{
    public const string TokenField = "token";
}
