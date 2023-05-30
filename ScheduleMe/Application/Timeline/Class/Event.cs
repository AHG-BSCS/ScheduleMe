namespace ScheduleMe.Tab;

internal class Event
{
    public string EventTitle { get; set; }
    public string EventDescription { get; set; }

    public DateTime EventStartDate { get; set; } = DateTime.Now;
    public DateTime EventEndDate { get; set; } = DateTime.Now.AddDays(1);

    public int EventColor { get; set; } = MainDesigner.ThemeColor.ToArgb();
}
