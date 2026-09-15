using System.Net.Http;

namespace MaxBots;

public sealed class DeleteMessage : BotApiMethodSuccess
{
    public const string Path = "messages";
    public const string MessageIdField = "message_id";

    public DeleteMessage(string messageId)
    {
        MessageId = messageId;
    }

    public string MessageId { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Delete; }
    }

    public override string Method
    {
        get { return Path; }
    }

    public override IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        return [MethodQuery.Create(MessageIdField, MessageId)];
    }
}
