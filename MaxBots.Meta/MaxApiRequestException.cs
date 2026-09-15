namespace MaxBots;

public sealed class MaxApiRequestException : MaxApiException
{
    public MaxApiRequestException(
        string message,
        int? statusCode = null,
        Exception? innerException = null
    )
        : base(message, innerException)
    {
        StatusCode = statusCode;
    }

    public int? StatusCode { get; }
}
