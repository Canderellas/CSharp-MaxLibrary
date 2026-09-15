namespace MaxBots;

public sealed record NewMessageLink(
    [property: JsonPropertyName(TypeField)] string Type,
    [property: JsonPropertyName(UrlField)] string? Url = null,
    [property: JsonPropertyName(MessageIdField)] string? MessageId = null
)
{
    public const string TypeField = "type";
    public const string UrlField = "url";
    public const string MessageIdField = "mid";
}
