using System.Net.Http;

namespace MaxBots;

public sealed class PutEditComment : BotApiMethodSuccess
{
    public const string Path = "messages";
    public const string MessageIdField = "messageId";
    public const string CommentIdField = "comment_id";

    public PutEditComment(
        string messageId,
        string commentId,
        NewCommentBody newCommentBody
    )
    {
        MessageId = messageId;
        CommentId = commentId;
        NewCommentBody = newCommentBody;
    }

    public string MessageId { get; }
    public string CommentId { get; }
    public NewCommentBody NewCommentBody { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Put; }
    }

    public override string Method
    {
        get { return $"{Path}/{MessageId}/comments"; }
    }

    public override IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        return [MethodQuery.Create(CommentIdField, CommentId)];
    }

    public override object GetBody()
    {
        return NewCommentBody;
    }
}