namespace dotnetcore_web_api.Models.Enums;

public enum TimeFormat
{
    DD_MM_YYYY_HH_MM_SS,
    DD_MM_YYYY_HH_MM,
    DD_MM_YYYY,
    MMMM_D_YYYY,
}

public static class TimeFormatExtensions
{
    // Java patterns kept verbatim. Note: .NET uses different format tokens
    // (e.g. "dd-MM-yyyy HH:mm:ss" works the same; "MMMM d, yyyy" works the same).
    public static string GetVal(this TimeFormat format) => format switch
    {
        TimeFormat.DD_MM_YYYY_HH_MM_SS => "dd-MM-yyyy HH:mm:ss",
        TimeFormat.DD_MM_YYYY_HH_MM => "dd-MM-yyyy HH:mm",
        TimeFormat.DD_MM_YYYY => "dd-MM-yyyy",
        TimeFormat.MMMM_D_YYYY => "MMMM d, yyyy",
        _ => string.Empty,
    };
}
