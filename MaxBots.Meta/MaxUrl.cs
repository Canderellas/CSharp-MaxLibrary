namespace MaxBots;

/// <summary>The MAX Bot API endpoint. The default is the production endpoint.</summary>
public sealed record MaxUrl(
    string Scheme = "https",
    string Host = "platform-api2.max.ru",
    int Port = 443,
    bool IsTestServer = false
)
{
    public const string TestPathSegment = "test";
    public static MaxUrl Default { get; } = new();

    public Uri CreateUri(string path, IEnumerable<KeyValuePair<string, string?>>? query = null)
    {
        var builder = new UriBuilder(Scheme, Host, Port)
        {
            Path = (IsTestServer ? $"{TestPathSegment}/" : string.Empty) + path.TrimStart('/'),
        };

        if (query is not null)
        {
            var items = new List<string>();

            foreach (var item in query)
            {
                if (item.Value is not null)
                {
                    items.Add(
                        $"{Uri.EscapeDataString(item.Key)}={Uri.EscapeDataString(item.Value)}"
                    );
                }
            }

            builder.Query = string.Join("&", items);
        }

        return builder.Uri;
    }
}
