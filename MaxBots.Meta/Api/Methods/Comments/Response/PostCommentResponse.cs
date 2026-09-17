namespace MaxBots;

public sealed record PostCommentResponse(
    [property: JsonPropertyName(PostCommentResponse.MessageField)]
    CommentMessage? Message = null
)
{
    public const string MessageField = "message";
}