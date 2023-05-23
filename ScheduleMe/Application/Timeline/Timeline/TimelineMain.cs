using LiteDB;

namespace ScheduleMe.Tab;

public partial class TimelineMain : Form
{
    public ObjectId currentID { get; set; }
    private byte columnSize = 42;
    private short currentDateTimePosition = 0;

    public TimelineMain()
    {
        InitializeComponent();
    }

    private void Timeline_Load(object sender, EventArgs e)
    {
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<Timeline>("Timeline");
            var timelineTabs = timelines.FindAll();
            if (timelineTabs.Count() != 0)
            {
                Timeline firstToLoad = timelineTabs.First();
                currentID = firstToLoad.Id;

                // Load all the Timeline Tabs
                foreach (var tab in timelineTabs)
                {
                    addNewTab(tab.TimelineName, tab.Id);
                }

                // Load the first Timeline.Event List only
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

            DatesLabel dayDates = new DatesLabel();
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

        for (ushort i = 0; i < events.Count; i++)
        {
            int eventDuration = (int)(events[i].EventEndDate - events[i].EventStartDate).TotalDays;
            int eventsXAxis = panelTimelineContainer.HorizontalScroll.Value
                        + (events[i].EventStartDate - startDate).Days
                        * columnSize;

            // Set other event property here
            EventButton newEvent = new EventButton();
            newEvent.StartDate = events[i].EventStartDate;
            newEvent.EndDate = events[i].EventEndDate;
            newEvent.Id = id;
            newEvent.Index = i;
            newEvent.Event = "Event " + tempIncrement++;
            newEvent.Width = eventDuration * columnSize + 4;
            newEvent.Location = new Point(eventsXAxis + 17, 70);

            panelTimelineContainer.Controls.Add(newEvent);
            ArrangeEventsOverlap(newEvent, ref lowestBottom);
        }
        panelTimelineContainer.Height = lowestBottom + 30;
    }

    private void ArrangeEventsOverlap(EventButton newEvent, ref int lowestBottom)
    {
        int previousEventTop = 0;
        int previousOverFlowBottom = 0;
        int noOverflowTop = 0;
        int noOverflowCounter = 0;

        foreach (EventButton previousEvent in panelTimelineContainer.Controls.OfType<EventButton>())
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
        TimelineTab newTimelineTab = new TimelineTab();
        newTimelineTab.TabName = timelineName;
        newTimelineTab.Id = Id;
        newTimelineTab.timelineInstance = this;
        newTimelineTab.Dock = DockStyle.Left;
        //newTimelineTab.Location = new Point(timelineAddTab.Left, timelineAddTab.Top);
        panelTimelineContainer.Controls.Clear();
        panelTimelineTab.Controls.Add(newTimelineTab);
        newTimelineTab.BringToFront();

        // Highlight the current tab
        if (currentID == Id)
        {
            newTimelineTab.timelineTabBtn.BackColor = Color.White;
            newTimelineTab.timelineTabBtn.ForeColor = Color.Black;
        }
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
        AddTimeline addTimelineTab = new AddTimeline();
        addTimelineTab.ShowDialog();

        

        if (addTimelineTab.Id != null)
        {
            // Remove the highlight of active Tab
            foreach (TimelineTab tab in panelTimelineTab.Controls.OfType<TimelineTab>())
            {
                if (currentID == tab.Id)
                {
                    tab.timelineTabBtn.BackColor = Color.FromArgb(15, 76, 129);
                    tab.timelineTabBtn.ForeColor = Color.White;
                    break;
                }
            }
            // Load the new added TimelineTab
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var newtTab = new Timeline();
                newtTab = timelines.FindById(addTimelineTab.Id);
                currentID = newtTab.Id;

                addNewTab(newtTab.TimelineName, newtTab.Id);
                panelTimelineContainer.Controls.Clear();
                panelTimelineContainer.Height = 130;
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
