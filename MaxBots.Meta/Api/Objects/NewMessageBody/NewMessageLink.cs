namespace MaxBots;

public sealed record NewMessageLink(
    [property: JsonPropertyName(NewMessageLink.TypeField)]
    string Type,
    [property: JsonPropertyName(NewMessageLink.UrlField)] 
    string? Url = null,
    [property: JsonPropertyName(NewMessageLink.MessageIdField)] 
    string? MessageId = null
)
{
    public const string TypeField = "type";
    public const string UrlField = "url";
    public const string MessageIdField = "mid";
}
