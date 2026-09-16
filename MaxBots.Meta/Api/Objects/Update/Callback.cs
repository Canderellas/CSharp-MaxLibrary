namespace MaxBots;

public sealed record Callback(
    [property: JsonPropertyName(Callback.TimestampField)] 
    long Timestamp,
    [property: JsonPropertyName(Callback.CallbackIdField)] 
    string CallbackId,
    [property: JsonPropertyName(Callback.PayloadField)] 
    string Payload,
    [property: JsonPropertyName(Callback.UserField)] 
    User User
)
{
    public const string TimestampField = "timestamp";
    public const string CallbackIdField = "callback_id";
    public const string PayloadField = "payload";
    public const string UserField = "user";
}
