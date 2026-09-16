namespace MaxBots;

public sealed record Message(
    [property: JsonPropertyName(Message.SenderField)]
    User? Sender,
    [property: JsonPropertyName(Message.RecipientField)]
    Recipient? Recipient,
    [property: JsonPropertyName(Message.TimestampField)]
    long Timestamp,
    [property: JsonPropertyName(Message.LinkField)]
    LinkedMessage? Link = null,
    [property: JsonPropertyName(Message.BodyField)]
    MessageBody? Body = null,
    [property: JsonPropertyName(Message.StatField)]
    MessageStat? Stat = null,
    [property: JsonPropertyName(Message.UrlField)]
    string? Url = null
)
{
    public const string SenderField = "sender";
    public const string RecipientField = "recipient";
    public const string TimestampField = "timestamp";
    public const string LinkField = "link";
    public const string BodyField = "body";
    public const string StatField = "stat";
    public const string UrlField = "url";
}
