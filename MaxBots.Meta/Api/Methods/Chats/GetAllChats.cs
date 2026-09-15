using System.Net.Http;

namespace MaxBots;

public sealed class GetAllChats : BotApiMethod<GetAllChatsResponse>
{
    public const string Path = "chats";
    public const string CountField = "count";
    public const string MarkerField = "marker";

    public GetAllChats(int? count = 50, long? marker = null)
    {
        Count = count;
        Marker = marker;
    }

    public int? Count { get; }
    public long? Marker { get; }

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
        return [MethodQuery.Create(CountField, Count), MethodQuery.Create(MarkerField, Marker)];
    }
}
