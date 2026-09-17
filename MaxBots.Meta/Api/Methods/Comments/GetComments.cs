using System.Net.Http;

namespace MaxBots;

public sealed class GetComments : BotApiMethod<GetCommentsResponse>
{
    public const string Path = "messages";
    public const string MessageIdField = "messageId";
    public const string CommentsIdsField = "comment_ids";
    public const string BeforeField = "before";
    public const string AfterField = "after";
    public const string CountField = "count";

    public GetComments(
        long messageId,
        IReadOnlyList<string>? commentIds = null,
        long? before = null,
        long? after = null,
        long? count = 50
    )
    {
        MessageId = messageId;
        CommentIds = commentIds;
        Before = before;
        After = after;
        Count = count;
    }

    public long MessageId { get; }
    public IReadOnlyList<string>? CommentIds { get; }
    public long? Before { get; }
    public long? After { get; }
    public long? Count { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Get; }
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
            MethodQuery.Create(CommentsIdsField, CommentIds is null ? null : string.Join(",", CommentIds)),
            MethodQuery.Create(BeforeField, Before),
            MethodQuery.Create(AfterField, After),
            MethodQuery.Create(CountField, Count),
        ];
    }
}