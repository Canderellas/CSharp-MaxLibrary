namespace MaxBots;

public sealed record PatchBotCommandsResponse(
    [property: JsonPropertyName(PatchBotCommandsResponse.CommandsField)]
    IReadOnlyList<BotCommand>? Commands = null
)
{
    public const string CommandsField = "commands";
}