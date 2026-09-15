using System.Net.Http;

namespace MaxBots;

public sealed class GetChatPinMessage : BotApiMethod<Message>
{
    public const string Path = "chats";

    public GetChatPinMessage(long chatId)
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
        get { return $"{Path}/{ChatId}/pin"; }
    }
}
