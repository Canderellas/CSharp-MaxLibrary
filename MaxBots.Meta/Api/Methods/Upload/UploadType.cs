namespace MaxBots;

public enum UploadType
{
    [JsonStringEnumMemberName("image")]
    Image,

    [JsonStringEnumMemberName("video")]
    Video,

    [JsonStringEnumMemberName("audio")]
    Audio,

    [JsonStringEnumMemberName("file")]
    File,
}