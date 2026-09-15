namespace MaxBots;

public sealed class PostAnswerToCallback : BotApiMethodSuccess
{
    public const string Path = "answers";
    public const string CallbackIdField = "callback_id";
    public const string MessageField = "message";
    public const string NotificationField = "notification";

    public PostAnswerToCallback(
        string callbackId,
        NewMessageBody? message = null,
        string? notification = null
    )
    {
        CallbackId = callbackId;
        Message = message;
        Notification = notification;
    }

    public string CallbackId { get; }
    public NewMessageBody? Message { get; }
    public string? Notification { get; }

    public override string Method
    {
        get { return Path; }
    }

    public override IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        return [MethodQuery.Create(CallbackIdField, CallbackId)];
    }

    public override object GetBody()
    {
        return new { message = Message, notification = Notification };
    }
}
