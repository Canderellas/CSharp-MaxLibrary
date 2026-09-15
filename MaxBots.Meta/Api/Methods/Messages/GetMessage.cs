using System.Net.Http;

namespace MaxBots;

public sealed class GetMessage : BotApiMethod<Message>
{
    public const string Path = "messages";

    public GetMessage(string messageId)
    {
        MessageId = messageId;
    }

    public string MessageId { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Get; }
    }

    public override string Method
    {
        get { return $"{Path}/{MessageId}"; }
    }
}
