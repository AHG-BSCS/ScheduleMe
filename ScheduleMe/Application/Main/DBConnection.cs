namespace ScheduleMe.Tab;

internal static class DBConnection
{
    static internal string databaseConnection = $"{GetBasePath()}\\ScheduleMe.db";

    static internal string GetBasePath()
    {
        return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
    }

   
}
