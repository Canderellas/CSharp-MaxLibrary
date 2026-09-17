namespace MaxBots;

public sealed class GetChatPinMessage : BotApiMethod<GetChatPinMessageResponse>
{
    public const string Path = "chats";
    public const string ChatIdField = "chatId";

    public GetChatPinMessage(string chatId)
    {
        ChatId = chatId;
    }

    public string ChatId { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Get; }
    }

    public override string Method
    {
        get { return $"{Path}/{ChatId}/pin"; }
    }
}