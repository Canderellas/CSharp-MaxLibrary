namespace MaxBots;

public sealed record GetSubscriptionsResponse(
    [property: JsonPropertyName(SubscriptionsField)] IReadOnlyList<Subscription> Subscriptions
)
{
    public const string SubscriptionsField = "subscriptions";
}
