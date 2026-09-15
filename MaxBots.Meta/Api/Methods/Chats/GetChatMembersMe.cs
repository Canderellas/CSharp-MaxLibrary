using System.Net.Http;

namespace MaxBots;

public sealed class GetChatMembersMe : BotApiMethod<ChatMember>
{
    public const string Path = "chats";

    public GetChatMembersMe(long chatId)
    {
        ChatId = chatId;
    }

    public long ChatId { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Get; }
    }

    public override string Method
    {
        get { return $"{Path}/{ChatId}/members/me"; }
    }
}
