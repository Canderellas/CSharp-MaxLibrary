namespace MaxBots;

public sealed class PostChatMembers : BotApiMethod<PostChatMembersResponse>
{
    public const string Path = "chats";
    public const string ChatIdField = "chatId";
    public const string UserIdsField = "user_ids";

    public PostChatMembers(long chatId, IReadOnlyList<long> userIds)
    {
        ChatId = chatId;
        UserIds = userIds;
    }

    public long ChatId { get; }
    public IReadOnlyList<long> UserIds { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Post; }
    }

    public override string Method
    {
        get { return $"{Path}/{ChatId}/members"; }
    }

    public override object GetBody()
    {
        return new { user_ids = UserIds };
    }
}