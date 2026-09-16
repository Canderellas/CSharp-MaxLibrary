namespace MaxBots;

public sealed record GetUpdatesResponse(
    [property: JsonPropertyName(GetUpdatesResponse.UpdatesField)]
    IReadOnlyList<Update> Updates,
    [property: JsonPropertyName(GetUpdatesResponse.MarkerField)]
    long? Marker = null
)
{
    public const string UpdatesField = "updates";
    public const string MarkerField = "marker";
}
