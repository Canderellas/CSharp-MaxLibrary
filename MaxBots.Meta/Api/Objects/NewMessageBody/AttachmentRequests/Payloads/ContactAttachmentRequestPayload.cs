namespace MaxBots;

public sealed record ContactAttachmentRequestPayload(
    [property: JsonPropertyName(ContactAttachmentRequestPayload.NameField)]
    string? Name = null,
    [property: JsonPropertyName(ContactAttachmentRequestPayload.ContactIdField)]
    string? ContactId = null,
    [property: JsonPropertyName(ContactAttachmentRequestPayload.VcfInfoField)]
    string? VcfInfo = null,
    [property: JsonPropertyName(ContactAttachmentRequestPayload.VcfPhoneField)]
    string? VcfPhone = null
) : AttachmentRequestPayload
{
    public const string NameField = "name";
    public const string ContactIdField = "contact_id";
    public const string VcfInfoField = "vcf_info";
    public const string VcfPhoneField = "vcf_phone";
}