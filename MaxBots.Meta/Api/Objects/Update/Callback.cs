namespace MaxBots;

public sealed record Callback(
    [property: JsonPropertyName(TimestampField)] long Timestamp,
    [property: JsonPropertyName(CallbackIdField)] string CallbackId,
    [property: JsonPropertyName(PayloadField)] string Payload,
    [property: JsonPropertyName(UserField)] User User
)
{
    public const string TimestampField = "timestamp";
    public const string CallbackIdField = "callback_id";
    public const string PayloadField = "payload";
    public const string UserField = "user";
}
