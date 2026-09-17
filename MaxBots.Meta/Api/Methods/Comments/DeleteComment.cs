using System.Net.Http;

namespace MaxBots;

public sealed class DeleteComment : BotApiMethodSuccess
{
    public const string Path = "messages";
    public const string MessageIdField = "messageId";
    public const string CommentIdField = "comment_id";

    public DeleteComment(string messageId, string commentId)
    {
        MessageId = messageId;
        CommentId = commentId;
    }

    public string MessageId { get; }
    public string CommentId { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Delete; }
    }

    public override string Method
    {
        get { return $"{Path}/{MessageId}/comments"; }
    }

    public override IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        return [MethodQuery.Create(CommentIdField, CommentId)];
    }
}