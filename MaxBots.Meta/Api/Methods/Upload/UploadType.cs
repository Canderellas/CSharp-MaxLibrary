namespace MaxBots;

public enum UploadType
{
    Image,
    Video,
    Audio,
    File,
}

public static class UploadTypeExtensions
{
    public static string ToApiValue(this UploadType type)
    {
        switch (type)
        {
            case UploadType.Image:
                return "image";
            case UploadType.Video:
                return "video";
            case UploadType.Audio:
                return "audio";
            case UploadType.File:
                return "file";
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }
    }
}
