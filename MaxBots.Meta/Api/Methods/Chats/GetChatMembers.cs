using System.Net.Http;

namespace MaxBots;

public sealed class GetChatMembers : BotApiMethod<ChatMembersResponse>
{
    public const string Path = "chats";
    public const string UserIdsField = "user_ids";
    public const string MarkerField = "marker";
    public const string CountField = "count";

    public GetChatMembers(
        long chatId,
        IReadOnlyList<long>? userIds = null,
        long? marker = null,
        int? count = 20
    )
    {
        ChatId = chatId;
        UserIds = userIds;
        Marker = marker;
        Count = count;
    }

    public long ChatId { get; }
    public IReadOnlyList<long>? UserIds { get; }
    public long? Marker { get; }
    public int? Count { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Get; }
    }

    public override string Method
    {
        get { return $"{Path}/{ChatId}/members"; }
    }

    public override IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        var userIds = UserIds is null ? null : string.Join(',', UserIds);
        return
        [
            MethodQuery.Create(UserIdsField, userIds),
            MethodQuery.Create(MarkerField, Marker),
            MethodQuery.Create(CountField, Count),
        ];
    }
}
