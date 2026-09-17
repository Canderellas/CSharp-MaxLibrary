using System.Net.Http;

namespace MaxBots;

public sealed class PostComment : BotApiMethod<PostCommentResponse>
{
    public const string Path = "messages";
    public const string MessageIdField = "messageId";
    public const string DisableLinkPreviewField = "disable_link_preview";

    public PostComment(
        string messageId,
        NewCommentBody newCommentBody,
        bool? disableLinkPreview = null
    )
    {
        MessageId = messageId;
        NewCommentBody = newCommentBody;
        DisableLinkPreview = disableLinkPreview;
    }

    public string MessageId { get; }
    public NewCommentBody NewCommentBody { get; }
    public bool? DisableLinkPreview { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Post; }
    }

    public override string Method
    {
        get { return $"{Path}/{MessageId}/comments"; }
    }

    public override IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        return
        [
            MethodQuery.Create(MessageIdField, MessageId),
            MethodQuery.Create(DisableLinkPreviewField, DisableLinkPreview),
        ];
    }

    public override object GetBody()
    {
        return NewCommentBody;
    }
}