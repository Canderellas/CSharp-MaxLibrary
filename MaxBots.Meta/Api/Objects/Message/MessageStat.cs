namespace MaxBots;

public sealed record MessageStat(
    [property: JsonPropertyName(MessageStat.ViewsField)]
    int? Views = null
)
{
    public const string ViewsField = "views";
}
