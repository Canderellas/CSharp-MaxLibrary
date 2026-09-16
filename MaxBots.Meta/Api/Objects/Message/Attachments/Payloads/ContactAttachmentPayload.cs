namespace MaxBots;

public sealed record ContactAttachmentPayload(
    [property: JsonPropertyName(ContactAttachmentPayload.VcfInfoField)]
    string? VcfInfo = null,
    [property: JsonPropertyName(ContactAttachmentPayload.MaxInfoField)]
    User? MaxInfo = null
)
{
    public const string VcfInfoField = "vcf_info";
    public const string MaxInfoField = "max_info";
}
