using LiteDB;

namespace ScheduleMe.Tab;

internal class TimelineTab
{
    [BsonId]
    public ObjectId Id { get; set; }

    public string TimelineName { get; set; }
    public string Description { get; set; }
    public DateTime TimelineStartDate { get; set; }
    public DateTime TimelineEndDate { get; set; }

    private List<Event> _events = new List<Event>();

    public List<Event> Events
    {
        get { return _events; }
        set { _events = value; }
    }
    // Logo if possible
}
