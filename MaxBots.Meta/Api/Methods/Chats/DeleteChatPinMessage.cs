using System.Net.Http;

namespace MaxBots;

public sealed class DeleteChatPinMessage : BotApiMethodSuccess
{
    public const string Path = "chats";

    public DeleteChatPinMessage(long chatId)
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
        get { return $"{Path}/{ChatId}/pin"; }
    }
}
