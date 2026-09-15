namespace MaxBots;

public class MaxApiException(string message, Exception? innerException = null)
    : Exception(message, innerException);
