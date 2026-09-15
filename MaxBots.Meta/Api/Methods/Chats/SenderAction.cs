namespace MaxBots;

public enum SenderAction
{
    TypingOn,
    SendingPhoto,
    SendingVideo,
    SendingAudio,
    SendingFile,
    MarkSeen,
}

public static class SenderActionExtensions
{
    public static string ToApiValue(this SenderAction action)
    {
        switch (action)
        {
            case SenderAction.TypingOn:
                return "typing_on";
            case SenderAction.SendingPhoto:
                return "sending_photo";
            case SenderAction.SendingVideo:
                return "sending_video";
            case SenderAction.SendingAudio:
                return "sending_audio";
            case SenderAction.SendingFile:
                return "sending_file";
            case SenderAction.MarkSeen:
                return "mark_seen";
            default:
                throw new ArgumentOutOfRangeException(nameof(action), action, null);
        }
    }
}
