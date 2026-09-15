using System.Net.Http;

namespace MaxBots;

public sealed class PostChatActions : BotApiMethodSuccess
{
    public const string Path = "chats";
    public const string ActionField = "action";

    public PostChatActions(long chatId, SenderAction action)
    {
        ChatId = chatId;
        Action = action;
    }

    public long ChatId { get; }
    public SenderAction Action { get; }

    public override string Method
    {
        get { return $"{Path}/{ChatId}/actions"; }
    }

    public override object GetBody()
    {
        return new { action = Action.ToApiValue() };
    }
}
