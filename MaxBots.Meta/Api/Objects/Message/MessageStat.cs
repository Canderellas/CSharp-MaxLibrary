namespace MaxBots;

public sealed record MessageStat([property: JsonPropertyName(ViewsField)] int? Views = null)
{
    public const string ViewsField = "views";
}
