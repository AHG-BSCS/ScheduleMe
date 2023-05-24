using LiteDB;

namespace ScheduleMe.Tab;

internal class Event
{
    public string EventTitle { get; set; }
    public string EventDescription { get; set; }

    private DateTime _startDate = DateTime.Now;
    private DateTime _endDate = DateTime.Now.AddDays(1);
    private int _eventColor = Color.FromArgb(15, 76, 129).ToArgb();

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

    public int EventColor
    {
        get { return _eventColor; }
        set { _eventColor = value; }
    }
}
