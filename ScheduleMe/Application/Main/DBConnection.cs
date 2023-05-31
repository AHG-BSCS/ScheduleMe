namespace ScheduleMe.Tab;

internal static class DBConnection
{
    static internal string databaseConnection_timeline = $"{GetBasePath()}\\ScheduleMe\\ScheduleMe_timeline.db";
    static internal string databaseConnection_timetable = $"{GetBasePath()}\\ScheduleMe\\ScheduleMe_timetable.db";
    static internal string databaseConnection_note = $"{GetBasePath()}\\ScheduleMe\\ScheduleMe_notes.db";
    static internal string databaseConnection_calendar = $"{GetBasePath()}\\ScheduleMe\\ScheduleMe_calendar.db";

    static internal string GetBasePath()
    {
        return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
    }
}
