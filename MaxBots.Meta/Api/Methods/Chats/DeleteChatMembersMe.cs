using System.Net.Http;

namespace MaxBots;

public sealed class DeleteChatMembersMe : BotApiMethodSuccess
{
    public const string Path = "chats";

    public DeleteChatMembersMe(long chatId)
    {
        ChatId = chatId;
    }

    public long ChatId { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Delete; }
    }

    public override string Method
    {
        get { return $"{Path}/{ChatId}/members/me"; }
    }
}
