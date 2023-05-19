using LiteDB;
using System.IO;

namespace ScheduleMe.Tab;

public partial class Timeline : Form
{
    private string timelineConnection = @"C:\Users\Jhondale\Documents\CODE\C#\GitHub\ScheduleMe\ScheduleMe\Database\Timelines.db";
    public ObjectId Id;
    private byte columnSize = 42;
    private short currentDateTimePosition = 0;

    public Timeline()
    {
        InitializeComponent();
    }

    private void Timeline_Load(object sender, EventArgs e)
    {
        /*
        DateTime startDate = new DateTime(2023, 4, 1);
        DateTime endDate = new DateTime(2023, 6, 20);

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
            new Tuple<DateTime, DateTime>(new DateTime(2023, 5, 16), new DateTime(2023, 5, 19)),
        };
        events.Sort();
        PopulateEvents(events, startDate);
        */

        // Load all the Timeline in the database
        using (var timelineDB = new LiteDatabase(timelineConnection))
        {
            var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
            var timelineTabs = timelines.FindAll();

            foreach (TimelineTab tab in timelineTabs)
            {
                addNewTab(tab.TimelineName);
                PopulateDates(tab.TimelineStartDate, tab.TimelineEndDate);
            }
        }
    }

    private void PopulateDates(DateTime startDate, DateTime endDate)
    {
        Label firstMonth = new Label();
        firstMonth.Text = startDate.ToString("MMMM yyyy");
        firstMonth.Font = new Font("Dubai", 10, FontStyle.Bold);
        firstMonth.Location = new Point(0, 0);
        firstMonth.AutoSize = true;
        panelTimelineContainer.Controls.Add(firstMonth);

        for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            if (currentDate.Day == 1) // This can produce overlapping month if the first day is 1 but can't be notice
            {
                Label nextMonths = new Label();
                nextMonths.Text = currentDate.ToString("MMMM yyyy");
                nextMonths.Font = new Font("Dubai", 10, FontStyle.Bold);
                nextMonths.Location = new Point(columnSize * (currentDate - startDate).Days, 0);
                nextMonths.AutoSize = true;
                panelTimelineContainer.Controls.Add(nextMonths);
            }

            DatesLabelBase dayDates = new DatesLabelBase();
            dayDates.Day = currentDate.ToString("ddd");
            dayDates.Date = currentDate.Day.ToString();
            dayDates.Location = new Point(columnSize * (currentDate - startDate).Days, firstMonth.Height - 5);
            panelTimelineContainer.Controls.Add(dayDates);

            Panel line = new Panel();
            line.BackColor = Color.Black;
            line.Width = 1;
            line.Height = panelTimelineContainer.Height - 58;
            line.Location = new Point(dayDates.Left + dayDates.Width / 2, dayDates.Height);
            panelTimelineContainer.Controls.Add(line);

            if (currentDate.DayOfYear == DateTime.Now.DayOfYear && currentDate.Year == DateTime.Now.Year)
            {
                Panel timeIndicatorLine = new Panel();
                timeIndicatorLine.BackColor = Color.FromArgb(15, 76, 129);
                timeIndicatorLine.Width = 3;
                timeIndicatorLine.Height = panelTimelineContainer.Height - 35;
                timeIndicatorLine.Location = new Point((dayDates.Left + dayDates.Width / 2)
                    + ((int)((float)columnSize * (float)(DateTime.Now.Hour / 24.0))),
                    dayDates.Height - 22);
                panelTimelineContainer.Controls.Add(timeIndicatorLine);
                timeIndicatorLine.BringToFront();

                Label timeIndicatorText = new Label();
                timeIndicatorText.BackColor = Color.FromArgb(15, 76, 129);
                timeIndicatorText.ForeColor = Color.White;
                timeIndicatorText.Text = DateTime.Now.ToString("hh:mm tt");
                timeIndicatorText.Font = new Font("Dubai", 8, FontStyle.Bold);
                timeIndicatorText.Location = new Point(timeIndicatorLine.Left, timeIndicatorLine.Top - 14);
                timeIndicatorText.AutoSize = true;
                panelTimelineContainer.Controls.Add(timeIndicatorText);
                timeIndicatorText.BringToFront();

                line.Width = 2;
                currentDateTimePosition = (short)timeIndicatorLine.Left;
            }
        }
    }

    private void PopulateEvents(List<Tuple<DateTime, DateTime>> eventDates, DateTime startDate)
    {
        short tempIncrement = 1;
        int lowestBottom = 0;

        foreach (Tuple<DateTime, DateTime> eventDate in eventDates)
        {
            int eventDuration = (int)(eventDate.Item2 - eventDate.Item1).TotalDays;
            int eventsXAxis = panelTimelineContainer.HorizontalScroll.Value
                        + (eventDate.Item1 - startDate).Days
                        * columnSize;

            EventButtonBase newEvent = new EventButtonBase();
            newEvent.StartDate = eventDate.Item1;
            newEvent.EndDate = eventDate.Item2;
            newEvent.Event = "Event " + tempIncrement++;
            newEvent.Width = eventDuration * columnSize + 4;
            newEvent.Location = new Point(eventsXAxis + 17, 70);

            panelTimelineContainer.Controls.Add(newEvent);
            ArrangeEventsOverlap(newEvent, ref lowestBottom);
        }
        panelTimelineContainer.Height = lowestBottom + 30;
    }

    private void ArrangeEventsOverlap(EventButtonBase newEvent, ref int lowestBottom)
    {
        int previousEventTop = 0;
        int previousOverFlowBottom = 0;
        int noOverflowTop = 0;
        int noOverflowCounter = 0;

        foreach (EventButtonBase previousEvent in panelTimelineContainer.Controls)
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

    private void addNewTab(string timelineName)
    {
        TimelineTabBase newTimelineTab = new TimelineTabBase();
        newTimelineTab.tabName = timelineName;
        newTimelineTab.Location = new Point(timelineAddTab.Left, timelineAddTab.Top);
        panelTimelineTab.Controls.Add(newTimelineTab);
        newTimelineTab.BringToFront();

        timelineAddTab.Location = new Point(newTimelineTab.Right, newTimelineTab.Top);
        newTimelineTab.Dock = DockStyle.Left;
    }

    private void currentDate_Click(object sender, EventArgs e)
    {
        Screen screen = Screen.PrimaryScreen;
        short screenWidth = (short)screen.Bounds.Width;
        panelTimelineContainer.AutoScrollPosition = new Point(currentDateTimePosition - (screenWidth / 2));
    }

    private void additionalInfo_Click(object sender, EventArgs e)
    {
        // Optional feature for now
    }

    private void timelineAddTab_Click(object sender, EventArgs e)
    {
        AddTimelineTab addTimelineTab = new AddTimelineTab();
        addTimelineTab.ShowDialog();

        // Load the new added timeline
        using (var timelineDB = new LiteDatabase(timelineConnection))
        {
            var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
            var newtTab = new TimelineTab();
            newtTab = timelines.FindById(addTimelineTab.Id);

            addNewTab(newtTab.TimelineName);
            PopulateDates(newtTab.TimelineStartDate, newtTab.TimelineEndDate);
        }
    }
}
