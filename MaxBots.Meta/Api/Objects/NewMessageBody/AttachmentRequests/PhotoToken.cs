namespace MaxBots;

public sealed record PhotoToken([property: JsonPropertyName(TokenField)] string Token)
{
    public const string TokenField = "token";
}
