using System.Net.Http;

namespace MaxBots;

public sealed class DeleteAdmin : BotApiMethodSuccess
{
    public const string Path = "chats";

    public DeleteAdmin(long chatId, long userId)
    {
        ChatId = chatId;
        UserId = userId;
    }

    public long ChatId { get; }
    public long UserId { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Delete; }
    }

    public override string Method
    {
        get { return $"{Path}/{ChatId}/members/admins/{UserId}"; }
    }
}
