namespace MaxBots;

public sealed record BotCommand(
    [property: JsonPropertyName(NameField)] string Name,
    [property: JsonPropertyName(DescriptionField)] string Description
)
{
    public const string NameField = "name";
    public const string DescriptionField = "description";
}
