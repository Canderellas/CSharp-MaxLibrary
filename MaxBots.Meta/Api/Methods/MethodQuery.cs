using System.Globalization;

namespace MaxBots;

internal static class MethodQuery
{
    public static KeyValuePair<string, string?> Create(string name, object? value)
    {
        return new KeyValuePair<string, string?>(name, Format(value));
    }

    public static string? Format(object? value)
    {
        if (value is null)
        {
            return null;
        }

        if (value is bool boolean)
        {
            return boolean ? "true" : "false";
        }

        return Convert.ToString(value, CultureInfo.InvariantCulture);
    }
}
