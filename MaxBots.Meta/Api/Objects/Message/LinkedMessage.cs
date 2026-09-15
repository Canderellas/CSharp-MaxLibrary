namespace MaxBots;

public sealed record LinkedMessage(
    [property: JsonPropertyName(TypeField)] string Type,
    [property: JsonPropertyName(SenderField)] User? Sender = null,
    [property: JsonPropertyName(MessageIdField)] string? MessageId = null
)
{
    public const string TypeField = "type";
    public const string SenderField = "sender";
    public const string MessageIdField = "message_id";
}
