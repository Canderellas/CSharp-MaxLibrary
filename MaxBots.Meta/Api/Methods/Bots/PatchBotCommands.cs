using System.Net.Http;

namespace MaxBots;

public sealed class PatchBotCommands : BotApiMethod<PatchBotCommandsResponse>
{
    public const string Path = "me/commands";
    public const string CommandsField = "commands";

    public PatchBotCommands(IReadOnlyList<BotCommand>? commands = null)
    {
        Commands = commands ?? [];
    }

    public IReadOnlyList<BotCommand> Commands { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Patch; }
    }

    public override string Method
    {
        get { return Path; }
    }

    public override object GetBody()
    {
        return new { commands = Commands };
    }
}