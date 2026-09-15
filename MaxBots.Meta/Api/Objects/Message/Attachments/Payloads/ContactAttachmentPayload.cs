namespace MaxBots;

public sealed record ContactAttachmentPayload(
    [property: JsonPropertyName(VcfInfoField)] string? VcfInfo = null,
    [property: JsonPropertyName(MaxInfoField)] User? MaxInfo = null
)
{
    public const string VcfInfoField = "vcf_info";
    public const string MaxInfoField = "max_info";
}
