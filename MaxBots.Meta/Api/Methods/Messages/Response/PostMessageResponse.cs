namespace MaxBots;

public sealed record PostMessageResponse(
    [property: JsonPropertyName(PostMessageResponse.MessageField)]
    Message Message
)
{
    public const string MessageField = "message";
}
