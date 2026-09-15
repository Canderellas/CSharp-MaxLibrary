namespace MaxBots;

public sealed class PostChatAdmins : BotApiMethodSuccess
{
    public const string Path = "chats";
    public const string AdminsField = "admins";
    public const string MarkerField = "marker";

    public PostChatAdmins(long chatId, IReadOnlyList<ChatAdmin> admins, long? marker = null)
    {
        ChatId = chatId;
        Admins = admins;
        Marker = marker;
    }

    public long ChatId { get; }
    public IReadOnlyList<ChatAdmin> Admins { get; }
    public long? Marker { get; }

    public override string Method
    {
        get { return $"{Path}/{ChatId}/members/admins"; }
    }

    public override object GetBody()
    {
        return new { admins = Admins, marker = Marker };
    }
}
