namespace MaxBots;

public sealed class PostSubscriptions : BotApiMethodSuccess
{
    public const string Path = "subscriptions";
    public const string UrlField = "url";
    public const string UpdateTypesField = "updates_types";
    public const string SecretField = "secret";

    public PostSubscriptions(
        string url,
        IReadOnlyList<string>? updates = null,
        string? secret = null
    )
    {
        Url = url;
        Updates = updates;
        Secret = secret;
    }

    public string Url { get; }
    public IReadOnlyList<string>? Updates { get; }
    public string? Secret { get; }

    public override string Method
    {
        get { return Path; }
    }

    public override object GetBody()
    {
        return new
        {
            url = Url,
            updates_types = Updates,
            secret = Secret,
        };
    }
}
