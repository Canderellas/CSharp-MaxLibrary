namespace MaxBots;

public sealed record NewCommentBody(
    [property: JsonPropertyName(NewCommentBody.TextField)]
    string? Text = null,
    [property: JsonPropertyName(NewCommentBody.LinkField)]
    NewMessageLink? Link = null,
    [property: JsonPropertyName(NewCommentBody.FormatField)]
    TextFormat? Format = null
)
{
    public const string TextField = "text";
    public const string LinkField = "link";
    public const string FormatField = "format";
}