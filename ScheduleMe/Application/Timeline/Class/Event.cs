namespace ScheduleMe.Tab;

internal class Event
{
    public string EventTitle { get; set; }
    public string EventDescription { get; set; }

    public DateTime EventStartDate { get; set; }
    public DateTime EventEndDate { get; set; }

    public int EventColor { get; set; } = MainDesigner.ThemeColor.ToArgb();
}
