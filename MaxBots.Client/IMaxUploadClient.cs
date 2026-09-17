namespace MaxBots;

public interface IMaxUploadClient : IDisposable
{
    /// <summary>Uploads a file and returns file metadata.</summary>
    Task<UploadFileResponse> UploadFileAsync(
        string uploadUrl,
        Stream fileStream,
        string fileName,
        CancellationToken cancellationToken = default
    );

    /// <summary>Uploads an image and returns photo tokens.</summary>
    Task<UploadImageResponse> UploadImageAsync(
        string uploadUrl,
        Stream fileStream,
        string fileName,
        CancellationToken cancellationToken = default
    );

    /// <summary>Uploads a video. Response may be XML (&lt;retval&gt;0|1&lt;/retval&gt;) or JSON.</summary>
    Task<UploadVideoResponse> UploadVideoAsync(
        string uploadUrl,
        Stream fileStream,
        string fileName,
        CancellationToken cancellationToken = default
    );

    /// <summary>Uploads an audio file. Response may be XML (&lt;retval&gt;0|1&lt;/retval&gt;) or JSON.</summary>
    Task<UploadAudioResponse> UploadAudioAsync(
        string uploadUrl,
        Stream fileStream,
        string fileName,
        CancellationToken cancellationToken = default
    );
}