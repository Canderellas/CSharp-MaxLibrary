using System.Net.Http;

namespace MaxBots;

/// <summary>Base class for API methods which return a <see cref="Success"/> result.</summary>
public abstract class BotApiMethodSuccess : BotApiMethod<Success>
{
    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Post; }
    }
}
