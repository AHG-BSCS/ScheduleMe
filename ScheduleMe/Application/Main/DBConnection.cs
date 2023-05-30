namespace ScheduleMe.Tab;

internal static class DBConnection
{
    static internal string timelineConnection = $"{GetBasePath()}\\timelines.db";
    static internal string calendarConnection = $"{GetBasePath()}\\calendar.db";

    static internal string GetBasePath()
    {
        return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
    }
}
