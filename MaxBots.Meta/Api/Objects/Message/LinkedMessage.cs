namespace MaxBots;

public sealed record LinkedMessage(
    [property: JsonPropertyName(LinkedMessage.TypeField)]
    string Type,
    [property: JsonPropertyName(LinkedMessage.SenderField)]
    User? Sender = null,
    [property: JsonPropertyName(LinkedMessage.MessageIdField)]
    string? MessageId = null
)
{
    public const string TypeField = "type";
    public const string SenderField = "sender";
    public const string MessageIdField = "message_id";
}
