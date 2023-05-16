namespace ScheduleMe.Tab;

public partial class Timeline : Form
{
    public Timeline()
    {
        InitializeComponent();
    }

    private int columnSize = 42;

    private void PopulateDates(DateTime startDate, DateTime endDate)
    {
        for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            DayDates dayDates = new DayDates();
            dayDates.Day = currentDate.ToString("ddd");
            dayDates.Date = currentDate.Day.ToString();
            dayDates.Location = new Point(columnSize * (currentDate - startDate).Days, 5);
            panelTimelineContainer.Controls.Add(dayDates);

            Panel linePanel = new Panel();
            linePanel.BackColor = Color.Black;
            linePanel.Width = 1;
            linePanel.Height = panelTimelineContainer.Height - 58;
            linePanel.Location = new Point(dayDates.Left + dayDates.Width / 2, dayDates.Height);
            panelTimelineContainer.Controls.Add(linePanel);
        }
    }

    private void PopulateEvents(List<Tuple<DateTime, DateTime>> eventDates, DateTime startDate)
    {
        int tempIncrement = 1;
        int lowestBottom = 0;

        foreach (Tuple<DateTime, DateTime> eventDate in eventDates)
        {
            int eventDuration = (int)(eventDate.Item2 - eventDate.Item1).TotalDays;
            int eventsXAxis = panelTimelineContainer.HorizontalScroll.Value
                        + (eventDate.Item1 - startDate).Days
                        * columnSize;

            Events newEvent = new Events();
            newEvent.StartDate = eventDate.Item1;
            newEvent.EndDate = eventDate.Item2;
            newEvent.Event = "Event " + tempIncrement++;
            newEvent.Width = eventDuration * columnSize + 1;
            newEvent.Location = new Point(eventsXAxis + 17, 55);

            panelTimelineContainer.Controls.Add(newEvent);
            ArrangeEventsOverlap(newEvent, ref lowestBottom);
        }
        panelTimelineContainer.Height = lowestBottom + 30;
    }
    
    private void ArrangeEventsOverlap(Events newEvent, ref int lowestBottom)
    {
        int previousEventTop = 0;
        int previousOverFlowBottom = 0;
        int noOverflowTop = 0;
        int noOverflowCounter = 0;

        foreach (Events previousEvent in panelTimelineContainer.Controls)
        {
            if (previousEvent != newEvent && newEvent.Top <= previousEvent.Top) // Not the same object and newEvent is above previousEvent
            {
                if ((newEvent.StartDate > previousEvent.StartDate && newEvent.StartDate < previousEvent.EndDate) // Possible Overflows
                    || (newEvent.StartDate >= previousEvent.StartDate && newEvent.EndDate <= previousEvent.StartDate)
                    || (newEvent.StartDate <= previousEvent.StartDate && newEvent.EndDate > previousEvent.StartDate)
                    || (newEvent.StartDate <= previousEvent.StartDate && newEvent.EndDate >= previousEvent.EndDate))
                {
                    if (newEvent.Bottom > previousEvent.Bottom || noOverflowTop < newEvent.Top) // Ignore bringing the event to the bottom of upper events
                    {
                        newEvent.Top = previousEvent.Bottom + 10;
                        previousEventTop = previousEvent.Top;
                    }
                    else if (newEvent.Bottom == previousEvent.Bottom) // if newEvent and previousEvent is the same row
                    newEvent.Top = previousOverFlowBottom;
                    
                    else if (previousEvent.Top > previousEventTop) // if previousEvent is lower than prev-Prev
                    {
                        newEvent.Top = noOverflowTop;
                        previousOverFlowBottom = previousEvent.Bottom + 10;
                    }
                }
                else if (noOverflowTop <= previousEvent.Top || newEvent.Top <= noOverflowTop) // Get previous top if no Overflow: to be used if there is overflow at some point
                {
                    noOverflowTop = previousEvent.Top;
                    noOverflowCounter++;
                }
            }
        }
        lowestBottom = Math.Max(newEvent.Bottom, lowestBottom);
    }

    private void Timeline_Load(object sender, EventArgs e)
    {
        List<Tuple<DateTime, DateTime>> events = new List<Tuple<DateTime, DateTime>>()
        {
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 6), new DateTime(2023, 4, 9)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 4), new DateTime(2023, 4, 8)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 5), new DateTime(2023, 4, 7)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 2), new DateTime(2023, 4, 4)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 3), new DateTime(2023, 4, 6)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 1), new DateTime(2023, 4, 5)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 1), new DateTime(2023, 4, 2)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 1), new DateTime(2023, 4, 3)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 6), new DateTime(2023, 4, 16)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 11), new DateTime(2023, 4, 17)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 12), new DateTime(2023, 4, 16)),
        };

        events.Sort();
        PopulateEvents(events, new DateTime(2023, 4, 1));
        PopulateDates(new DateTime(2023, 4, 1), new DateTime(2023, 4, 30));
    }
}
