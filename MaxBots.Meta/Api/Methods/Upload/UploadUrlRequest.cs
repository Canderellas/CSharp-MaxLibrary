using System.Net.Http;

namespace MaxBots;

public sealed class UploadUrlRequest : BotApiMethod<UploadUrlResponse>
{
    public const string Path = "uploads";
    public const string TypeField = "type";

    public UploadUrlRequest(UploadType type)
    {
        Type = type;
    }

    public UploadType Type { get; }

    public override HttpMethod HttpMethod
    {
        get { return HttpMethod.Post; }
    }

    public override string Method
    {
        get { return Path; }
    }

    public override IEnumerable<KeyValuePair<string, string?>> GetQueryParameters()
    {
        return [MethodQuery.Create(TypeField, Type.ToApiValue())];
    }
}
