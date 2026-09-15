namespace MaxBots;

public sealed class PostChatMembers : BotApiMethodSuccess
{
    public const string Path = "chats";
    public const string UserIdsField = "user_ids";

    public PostChatMembers(long chatId, IReadOnlyList<long> userIds)
    {
        ChatId = chatId;
        UserIds = userIds;
    }

    public long ChatId { get; }
    public IReadOnlyList<long> UserIds { get; }

    public override string Method
    {
        get { return $"{Path}/{ChatId}/members"; }
    }

    public override object GetBody()
    {
        return new { user_ids = UserIds };
    }
}
