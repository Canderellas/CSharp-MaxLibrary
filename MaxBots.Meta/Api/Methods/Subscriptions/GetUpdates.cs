using System.Net.Http;

namespace MaxBots;

public sealed class GetUpdates : BotApiMethod<GetUpdatesResponse>
{
    public const string Path = "updates";
    public const string LimitField = "limit";
    public const string TimeoutField = "timeout";
    public const string MarkerField = "marker";
    public const string TypesField = "types";

    public GetUpdates(
        int limit = 2,
        int timeout = 4,
        long? marker = null,
        IReadOnlyList<string>? types = null
    )
    {
        Limit = limit;
        Timeout = timeout;
        Marker = marker;
        Types =
            types
            ??
            [
                "message_created",
                "bot_started",
                "message_edited",
                "message_removed",
                "message_callback",
            ];
    }

    public int Limit { get; }
    public int Timeout { get; }
    public long? Marker { get; }
    public IReadOnlyList<string>? Types { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Get; }
    }

    public override string Method
    {
        get { return Path; }
    }

    public override IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        var types = Types is null ? null : string.Join(',', Types);
        return
        [
            MethodQuery.Create(LimitField, Limit),
            MethodQuery.Create(TimeoutField, Timeout),
            MethodQuery.Create(MarkerField, Marker),
            MethodQuery.Create(TypesField, types),
        ];
    }
}
