using System.Net.Http;

namespace MaxBots;

public sealed class PutChatPinMessage : BotApiMethod<Message>
{
    public const string Path = "chats";
    public const string MessageIdField = "message_id";
    public const string NotifyField = "notify";

    public PutChatPinMessage(long chatId, string messageId, bool notify = true)
    {
        ChatId = chatId;
        MessageId = messageId;
        Notify = notify;
    }

    public long ChatId { get; }
    public string MessageId { get; }
    public bool Notify { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Put; }
    }

    public override string Method
    {
        get { return $"{Path}/{ChatId}/pin"; }
    }

    public override object GetBody()
    {
        return new { message_id = MessageId, notify = Notify };
    }
}
