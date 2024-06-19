namespace UsingIndention.Extensions;

public static class TimeSpanExtensions
{
    public static string ToReadableTime(this TimeSpan time, TimeInterval maximalVisibleUnit = TimeInterval.Hour)
    {
        if (time.Days > 0 && maximalVisibleUnit >= TimeInterval.Day)
        {
            return $"{time.Days:D1}d {time.Hours:D2}h {time.Minutes:D2}m {time.Seconds:D2}s";
        }
        else if (time.Hours > 0 && maximalVisibleUnit >= TimeInterval.Hour)
        {
            return $"{time.Hours:D1}h {time.Minutes:D2}m {time.Seconds:D2}s";
        }
        else if (time.Minutes > 0 && maximalVisibleUnit >= TimeInterval.Minute)
        {
            return $"{time.Minutes:D1}m {time.Seconds:D2}s";
        }
        else if (time.Seconds > 0 && maximalVisibleUnit >= TimeInterval.Second)
        {
            return $"{time.Seconds:D2}s";
        }

        return string.Empty;
    }
}

public enum TimeInterval
{
    Second,
    Minute,
    Hour,
    Day
}

