namespace MaxBots;

public sealed record PostMessageResponse([property: JsonPropertyName(MessageField)] Message Message)
{
    public const string MessageField = "message";
}
