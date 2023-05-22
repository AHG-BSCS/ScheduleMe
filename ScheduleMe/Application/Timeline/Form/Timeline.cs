using LiteDB;

namespace ScheduleMe.Tab;

public partial class Timeline : Form
{
    public ObjectId Id;
    private byte columnSize = 42;
    private short currentDateTimePosition = 0;

    public Timeline()
    {
        InitializeComponent();
    }

    private void Timeline_Load(object sender, EventArgs e)
    {
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
            var timelineTabs = timelines.FindAll();
            if (timelineTabs.Count() != 0)
            {
                // Load all the Timeline Tabs
                foreach (var tab in timelineTabs)
                {
                    addNewTab(tab.TimelineName, tab.Id);
                }

                // Load the first Timeline.Event List only
                TimelineTab firstToLoad = timelineTabs.First();

                if (firstToLoad.Events != null)
                {
                    // Need to improve the sorting or the overlapping method. Too difficult
                    firstToLoad.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                    PopulateEvents(firstToLoad.Events, firstToLoad.TimelineStartDate, firstToLoad.Id);
                }
                PopulateDates(firstToLoad.TimelineStartDate, firstToLoad.TimelineEndDate);
            }
        }
    }

    public void PopulateDates(DateTime startDate, DateTime endDate)
    {
        Label firstMonth = new Label();
        firstMonth.Text = startDate.ToString("MMMM yyyy");
        firstMonth.Font = new Font("Dubai", 10, FontStyle.Bold);
        firstMonth.Location = new Point(0, 0);
        firstMonth.AutoSize = true;
        panelTimelineContainer.Controls.Add(firstMonth);

        for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            // This can produce overlapping month if the first day is 1 but can't be notice
            if (currentDate.Day == 1)
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

            // I was planning to move this outside later
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

    internal void PopulateEvents(List<Event> events, DateTime startDate, ObjectId id)
    {
        short tempIncrement = 1;
        int lowestBottom = 0;

        foreach (Event eventDate in events)
        {
            int eventDuration = (int)(eventDate.EventEndDate - eventDate.EventStartDate).TotalDays;
            int eventsXAxis = panelTimelineContainer.HorizontalScroll.Value
                        + (eventDate.EventStartDate - startDate).Days
                        * columnSize;

            // Set other event property here
            EventButtonBase newEvent = new EventButtonBase();
            newEvent.StartDate = eventDate.EventStartDate;
            newEvent.EndDate = eventDate.EventEndDate;
            newEvent.Id = id;
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

        foreach (EventButtonBase previousEvent in panelTimelineContainer.Controls.OfType<EventButtonBase>())
        {
            // Not the same object and newEvent is above previousEvent
            if (previousEvent != newEvent && newEvent.Top <= previousEvent.Top)
            {
                // Possible overflows
                if ((newEvent.StartDate > previousEvent.StartDate && newEvent.StartDate < previousEvent.EndDate)
                    || (newEvent.StartDate >= previousEvent.StartDate && newEvent.EndDate <= previousEvent.StartDate)
                    || (newEvent.StartDate <= previousEvent.StartDate && newEvent.EndDate > previousEvent.StartDate)
                    || (newEvent.StartDate <= previousEvent.StartDate && newEvent.EndDate >= previousEvent.EndDate))
                {
                    // Ignore bringing the event to the bottom of upper events
                    if (newEvent.Bottom > previousEvent.Bottom || noOverflowTop < newEvent.Top)
                    {
                        newEvent.Top = previousEvent.Bottom + 10;
                        previousEventTop = previousEvent.Top;
                    }
                    // if newEvent and previousEvent is the same row
                    else if (newEvent.Bottom == previousEvent.Bottom)
                        newEvent.Top = previousOverFlowBottom;

                    // if previousEvent is lower than prev-Prev
                    else if (previousEvent.Top > previousEventTop)
                    {
                        newEvent.Top = noOverflowTop;
                        previousOverFlowBottom = previousEvent.Bottom + 10;
                    }
                }
                // Get previous top if no Overflow: to be used if there is overflow at some point
                else if (noOverflowTop <= previousEvent.Top || newEvent.Top <= noOverflowTop)
                {
                    noOverflowTop = previousEvent.Top;
                    noOverflowCounter++;
                }
            }
        }
        lowestBottom = Math.Max(newEvent.Bottom, lowestBottom);
    }

    public void addNewTab(string timelineName, ObjectId Id)
    {
        TimelineTabBase newTimelineTab = new TimelineTabBase();
        newTimelineTab.tabName = timelineName;
        newTimelineTab.Id = Id;
        newTimelineTab.timelineInstance = this;
        newTimelineTab.Dock = DockStyle.Left;
        //newTimelineTab.Location = new Point(timelineAddTab.Left, timelineAddTab.Top);
        panelTimelineContainer.Controls.Clear();
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

        if (addTimelineTab.Id != null)
        {
            // Load the new added TimelineTab
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
                var newtTab = new TimelineTab();
                newtTab = timelines.FindById(addTimelineTab.Id);

                addNewTab(newtTab.TimelineName, newtTab.Id);
                PopulateDates(newtTab.TimelineStartDate, newtTab.TimelineEndDate);
            }
        }
    }

    private void timelineOption_Click(object sender, EventArgs e)
    {
        EditEvent editEvents = new EditEvent();
        editEvents.ShowDialog();
    }
}
