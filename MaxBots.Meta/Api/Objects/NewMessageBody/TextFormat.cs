namespace MaxBots;

public enum TextFormat
{
    [JsonStringEnumMemberName("markdown")]
    Markdown,

    [JsonStringEnumMemberName("html")]
    Html,
}