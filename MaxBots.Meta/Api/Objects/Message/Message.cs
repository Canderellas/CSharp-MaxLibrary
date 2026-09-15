namespace MaxBots;

public sealed record Message(
    [property: JsonPropertyName(SenderField)] User? Sender,
    [property: JsonPropertyName(RecipientField)] Recipient? Recipient,
    [property: JsonPropertyName(TimestampField)] long Timestamp,
    [property: JsonPropertyName(LinkField)] LinkedMessage? Link = null,
    [property: JsonPropertyName(BodyField)] MessageBody? Body = null,
    [property: JsonPropertyName(StatField)] MessageStat? Stat = null,
    [property: JsonPropertyName(UrlField)] string? Url = null
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
