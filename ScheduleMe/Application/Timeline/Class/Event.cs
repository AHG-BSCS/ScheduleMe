using LiteDB;

namespace ScheduleMe.Tab;

internal class Event : TimelineTab
{
    public string EventTitle { get; set; }
    public string EventDescription { get; set; }
    public Color Color { get; set; }
    public DateTime EventStartDate { get; set; }
    public DateTime EventEndDate { get; set; }
}
