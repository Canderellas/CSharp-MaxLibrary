namespace MaxBots;

public sealed record BotCommand(
    [property: JsonPropertyName(BotCommand.NameField)]
    string Name,
    [property: JsonPropertyName(BotCommand.DescriptionField)]
    string Description
)
{
    public const string NameField = "name";
    public const string DescriptionField = "description";
}
