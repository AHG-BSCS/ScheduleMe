namespace ScheduleMe.Tab;

internal static class DBConnection
{
    static internal string timelineConnection = $"{GetBasePath()}\\Timelines.db";

    static string GetBasePath()
    {
        string basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        basePath = Path.Combine(basePath, "Downloads");
        return basePath;
    }
}
