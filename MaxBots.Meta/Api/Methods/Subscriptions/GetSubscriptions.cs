using System.Net.Http;

namespace MaxBots;

public sealed class GetSubscriptions : BotApiMethod<GetSubscriptionsResponse>
{
    public const string Path = "subscriptions";

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Get; }
    }

    public override string Method
    {
        get { return Path; }
    }
}
