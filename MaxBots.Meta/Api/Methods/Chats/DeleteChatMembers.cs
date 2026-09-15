using System.Net.Http;

namespace MaxBots;

public sealed class DeleteChatMembers : BotApiMethodSuccess
{
    public const string Path = "chats";
    public const string UserIdField = "user_id";
    public const string BlockField = "block";

    public DeleteChatMembers(long chatId, long userId, bool? block = null)
    {
        ChatId = chatId;
        UserId = userId;
        Block = block;
    }

    public long ChatId { get; }
    public long UserId { get; }
    public bool? Block { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Delete; }
    }

    public override string Method
    {
        get { return $"{Path}/{ChatId}/members"; }
    }

    public override IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        return [MethodQuery.Create(UserIdField, UserId), MethodQuery.Create(BlockField, Block)];
    }
}
