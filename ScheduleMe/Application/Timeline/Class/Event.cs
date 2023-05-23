using LiteDB;

namespace ScheduleMe.Tab;

internal class Event
{
    public string EventTitle { get; set; }
    public string EventDescription { get; set; }
    public Color EventColor { get; set; }

    private DateTime _startDate = DateTime.Now;
    private DateTime _endDate = DateTime.Now.AddDays(1);

    public DateTime EventStartDate
    {
        get { return _startDate; }
        set { _startDate = value; }
    }

    public DateTime EventEndDate
    {
        get { return _endDate; }
        set { _endDate = value; }
    }
}
