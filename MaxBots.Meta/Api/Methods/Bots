using System.Net.Http;

namespace MaxBots;

public sealed class GetBotInfo : BotApiMethod<BotInfo>
{
    public const string Path = "me";

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Get; }
    }

    public override string Method
    {
        get { return Path; }
    }
}
