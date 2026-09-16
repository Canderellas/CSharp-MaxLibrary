namespace MaxBots;

public sealed record GetSubscriptionsResponse(
    [property: JsonPropertyName(GetSubscriptionsResponse.SubscriptionsField)]
    IReadOnlyList<Subscription> Subscriptions
)
{
    public const string SubscriptionsField = "subscriptions";
}
