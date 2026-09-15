using System.Net.Http;

namespace MaxBots;

public sealed class GetMessages : BotApiMethod<GetMessagesResponse>
{
    public const string Path = "messages";
    public const string ChatIdField = "chat_id";
    public const string MessageIdsField = "message_ids";
    public const string FromField = "from";
    public const string ToField = "to";
    public const string CountField = "count";

    public GetMessages(
        long? chatId = null,
        IReadOnlyList<string>? messageIds = null,
        long? from = null,
        long? to = null,
        long? count = null
    )
    {
        ChatId = chatId;
        MessageIds = messageIds;
        From = from;
        To = to;
        Count = count;
    }

    public long? ChatId { get; }
    public IReadOnlyList<string>? MessageIds { get; }
    public long? From { get; }
    public long? To { get; }
    public long? Count { get; }

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
        var messageIds = MessageIds is null ? null : string.Join(',', MessageIds);
        return
        [
            MethodQuery.Create(ChatIdField, ChatId),
            MethodQuery.Create(MessageIdsField, messageIds),
            MethodQuery.Create(FromField, From),
            MethodQuery.Create(ToField, To),
            MethodQuery.Create(CountField, Count),
        ];
    }
}
