using System.Net.Http;

namespace MaxBots;

public sealed class GetChatAdmins : BotApiMethod<ChatMembersResponse>
{
    public const string Path = "chats";

    public GetChatAdmins(long chatId)
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
        get { return $"{Path}/{ChatId}/members/admins"; }
    }
}
