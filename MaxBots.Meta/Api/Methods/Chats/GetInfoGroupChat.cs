using System.Net.Http;

namespace MaxBots;

public sealed class GetInfoGroupChat : BotApiMethod<Chat>
{
    public const string Path = "chats";
    public const string ChatIdField = "chat_id";

    public GetInfoGroupChat(long chatId)
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
        get { return $"{Path}/{ChatId}"; }
    }
}
