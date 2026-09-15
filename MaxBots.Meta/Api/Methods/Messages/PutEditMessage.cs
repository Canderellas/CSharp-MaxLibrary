using System.Net.Http;

namespace MaxBots;

public sealed class PutEditMessage : BotApiMethodSuccess
{
    public const string Path = "messages";
    public const string MessageIdField = "message_id";

    public PutEditMessage(string messageId, NewMessageBody newMessageBody)
    {
        MessageId = messageId;
        NewMessageBody = newMessageBody;
    }

    public string MessageId { get; }
    public NewMessageBody NewMessageBody { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Put; }
    }

    public override string Method
    {
        get { return Path; }
    }

    public override IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        return [MethodQuery.Create(MessageIdField, MessageId)];
    }

    public override object GetBody()
    {
        return NewMessageBody;
    }
}
