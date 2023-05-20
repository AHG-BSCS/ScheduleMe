using LiteDB;

namespace ScheduleMe.Tab;

internal class Event
{
    public string EventTitle { get; set; }
    public string EventDescription { get; set; }
    public Color EventColor { get; set; }
    public DateTime EventStartDate { get; set; }
    public DateTime EventEndDate { get; set; }
}
