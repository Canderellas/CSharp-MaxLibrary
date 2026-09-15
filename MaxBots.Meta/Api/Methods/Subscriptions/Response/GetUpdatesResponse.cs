namespace MaxBots;

public sealed record GetUpdatesResponse(
    [property: JsonPropertyName(UpdatesField)] IReadOnlyList<Update> Updates,
    [property: JsonPropertyName(MarkerField)] long? Marker = null
)
{
    public const string UpdatesField = "updates";
    public const string MarkerField = "marker";
}
