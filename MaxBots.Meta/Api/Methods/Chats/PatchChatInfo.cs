using System.Net.Http;

namespace MaxBots;

public sealed class PatchChatInfo : BotApiMethod<Chat>
{
    public const string Path = "chats";
    public const string IconField = "icon";
    public const string TitleField = "title";
    public const string PinField = "pin";
    public const string NotifyField = "notify";

    public PatchChatInfo(
        long chatId,
        object? icon = null,
        string? title = null,
        string? pin = null,
        bool? notify = null
    )
    {
        ChatId = chatId;
        Icon = icon;
        Title = title;
        Pin = pin;
        Notify = notify;
    }

    public long ChatId { get; }
    public object? Icon { get; }
    public string? Title { get; }
    public string? Pin { get; }
    public bool? Notify { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Patch; }
    }

    public override string Method
    {
        get { return $"{Path}/{ChatId}"; }
    }

    public override object GetBody()
    {
        return new
        {
            icon = Icon,
            title = Title,
            pin = Pin,
            notify = Notify,
        };
    }
}
