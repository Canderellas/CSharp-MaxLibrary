using System.Net.Http;

namespace MaxBots;

public sealed class GetComment : BotApiMethod<CommentMessage>
{
    public const string Path = "messages";
    public const string MessageIdField = "message_id";
    public const string CommentIdField = "comment_id";

    public GetComment(string messageId, string commentId)
    {
        MessageId = messageId;
        CommentId = commentId;
    }

    public string MessageId { get; }
    public string CommentId { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Get; }
    }

    public override string Method
    {
        get { return $"{Path}/{MessageId}/comments/{CommentId}"; }
    }
}