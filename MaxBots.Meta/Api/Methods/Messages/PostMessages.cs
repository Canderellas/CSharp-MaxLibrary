namespace MaxBots;

public sealed class PostMessages : BotApiMethod<PostMessageResponse>
{
    public const string Path = "messages";
    public const string UserIdField = "user_id";
    public const string ChatIdField = "chat_id";
    public const string DisableLinkPreviewField = "disable_link_preview";

    public PostMessages(
        long? userId = null,
        long? chatId = null,
        bool? disableLinkPreview = null,
        NewMessageBody? newMessageBody = null
    )
    {
        UserId = userId;
        ChatId = chatId;
        DisableLinkPreview = disableLinkPreview;
        NewMessageBody = newMessageBody ?? new NewMessageBody();
    }

    public long? UserId { get; }
    public long? ChatId { get; }
    public bool? DisableLinkPreview { get; }
    public NewMessageBody NewMessageBody { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Post; }
    }

    public override string Method
    {
        get { return Path; }
    }

    public override IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        return
        [
            MethodQuery.Create(UserIdField, UserId),
            MethodQuery.Create(ChatIdField, ChatId),
            MethodQuery.Create(DisableLinkPreviewField, DisableLinkPreview),
        ];
    }

    public override object GetBody()
    {
        return NewMessageBody;
    }
}