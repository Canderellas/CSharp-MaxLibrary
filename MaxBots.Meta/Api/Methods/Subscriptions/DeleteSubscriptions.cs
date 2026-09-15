using System.Net.Http;

namespace MaxBots;

public sealed class DeleteSubscriptions : BotApiMethodSuccess
{
    public const string Path = "subscriptions";
    public const string UrlField = "url";

    public DeleteSubscriptions(string url)
    {
        Url = url;
    }

    public string Url { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Delete; }
    }

    public override string Method
    {
        get { return Path; }
    }

    public override IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        return [MethodQuery.Create(UrlField, Url)];
    }
}
