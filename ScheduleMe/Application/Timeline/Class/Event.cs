namespace ScheduleMe.Tab;

internal class Event : TimelineTab
{
    public string eventTitle { get; set; }
    public string eventDescription { get; set; }
    public Color color { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
}
