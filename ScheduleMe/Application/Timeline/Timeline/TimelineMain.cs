using LiteDB;

namespace ScheduleMe.Tab;

public partial class TimelineMain : Form
{
    public ObjectId currentID { get; set; }
    private List<ObjectId> _eventIds = new List<ObjectId>();
    private byte columnSize = 42;
    private short currentDateTimePosition = 0;
    public List<ObjectId> EventIds
    {
        get { return _eventIds; }
        set { _eventIds = value; }
    }

    public TimelineMain()
    {
        InitializeComponent();
    }

    private void Timeline_Load(object sender, EventArgs e)
    {
        if (currentID == null)
        {
            LoadFirstTimeline();
        }

        else if (currentID != null) // Assumed that ID exists
        {
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var timelineTab = timelines.FindById(currentID);
                EventIds.Add(currentID);
                addNewTab(timelineTab.TimelineName, timelineTab.Id);

                if (timelineTab.Events.Any())
                {
                    // Need to improve the sorting or the overlapping method. Too difficult
                    timelineTab.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                    PopulateEvents(timelineTab.Events, timelineTab.TimelineStartDate, timelineTab.Id);
                }
                else
                {
                    panelTimelineContainer.Height = 130;
                    Height = panelTimelineContainer.Height + 35;
                }
                PopulateDates(timelineTab.TimelineStartDate, timelineTab.TimelineEndDate);
            }
        }
    }

    private void LoadFirstTimeline()
    {
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<Timeline>("Timeline");
            var timelineTabs = timelines.FindAll();
            if (timelineTabs.Any())
            {
                Timeline firstToLoad = timelineTabs.First();
                currentID = firstToLoad.Id;

                // Load all the Timeline Tabs
                foreach (var tab in timelineTabs)
                {
                    EventIds.Add(tab.Id);
                    addNewTab(tab.TimelineName, tab.Id);
                }

                // Load the first Timeline.Event List only
                if (firstToLoad.Events.Any())
                {
                    // Need to improve the sorting or the overlapping method. Too difficult
                    firstToLoad.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                    PopulateEvents(firstToLoad.Events, firstToLoad.TimelineStartDate, firstToLoad.Id);
                }
                else
                {
                    panelTimelineContainer.Height = 130;
                    Height = panelTimelineContainer.Height + 35;
                }
                PopulateDates(firstToLoad.TimelineStartDate, firstToLoad.TimelineEndDate);
            }
        }
    }

    public void PopulateDates(DateTime startDate, DateTime endDate)
    {
        int firstMonthRight = 0;
        for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            if (currentDate.Day == 1 || currentDate.DayOfYear == startDate.DayOfYear)
            {
                Label nextMonths = new Label();
                nextMonths.Text = currentDate.ToString("MMMM yyyy");
                nextMonths.Font = new Font("Dubai", 10, FontStyle.Bold);
                nextMonths.Location = new Point(columnSize * (currentDate - startDate).Days, 0);
                nextMonths.AutoSize = true;
                panelTimelineContainer.Controls.Add(nextMonths);

                if (nextMonths.Left < firstMonthRight)
                    nextMonths.Left = firstMonthRight;

                else if (currentDate.Day == startDate.Day)
                    firstMonthRight = nextMonths.Right;
            }

            DatesLabel dayDates = new DatesLabel();
            dayDates.Day = currentDate.ToString("ddd");
            dayDates.Date = currentDate.Day.ToString();
            dayDates.Location = new Point(columnSize * (currentDate - startDate).Days, 23 - 5);
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
        int lowestBottom = 0;

        for (ushort i = 0; i < events.Count; i++)
        {
            int eventDuration = (int)(events[i].EventEndDate - events[i].EventStartDate).TotalDays;
            int eventsXAxis = panelTimelineContainer.HorizontalScroll.Value
                        + (events[i].EventStartDate - startDate).Days
                        * columnSize;

            EventButton newEvent = new EventButton();
            newEvent.SetEventProperty(
                events[i].EventTitle,
                events[i].EventDescription,
                events[i].EventStartDate,
                events[i].EventEndDate,
                events[i].EventColor);
            newEvent.Id = id;
            newEvent.Index = i;
            newEvent.Width = eventDuration * columnSize + 1;
            newEvent.Location = new Point(eventsXAxis + 17, 70);

            panelTimelineContainer.Controls.Add(newEvent);
            StackEvents(newEvent, ref lowestBottom);
        }
        panelTimelineContainer.Height = lowestBottom + 30;
        Height = panelTimelineContainer.Height + 35;
    }

    private void StackEvents(EventButton newEvent, ref int lowestBottom)
    {
        int currentRow = 70;

        foreach (EventButton previousEvent in panelTimelineContainer.Controls)
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
                    currentRow += 40;
                }
            }
        }
        newEvent.Top = currentRow;
        lowestBottom = Math.Max(newEvent.Bottom, lowestBottom);
    }

    public void addNewTab(string timelineName, ObjectId Id)
    {
        TimelineTab newTimelineTab = new TimelineTab();
        newTimelineTab.TimelineTabMenu_ItemClicked += timelineMenu_ItemClicked;
        newTimelineTab.AddOption_ItemClicked += timelineAddTab_Click;
        newTimelineTab.OpenAtBottomOption_ItemClicked += timelineMenu_ItemClicked;
        newTimelineTab.TabName = timelineName;
        newTimelineTab.Id = Id;
        newTimelineTab.timelineInstance = this;
        newTimelineTab.Dock = DockStyle.Left;
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

    private void timelineAddTab_Click(object sender, EventArgs e)
    {
        AddTimeline addTimelineTab = new AddTimeline();
        addTimelineTab.ShowDialog();

        if (addTimelineTab.Id != null)
        {
            EventIds.Add(addTimelineTab.Id);
            // Remove the highlight of active Tab
            foreach (TimelineTab tab in panelTimelineTab.Controls)
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
                Height = panelTimelineContainer.Height + 35;
                PopulateDates(newtTab.TimelineStartDate, newtTab.TimelineEndDate);
            }
        }
        addTimelineTab.Dispose();
    }

    private void timelineMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem.Name == editOption.Name)
        {
            EditEvent editEvent = new EditEvent();
            editEvent.CurrentID = currentID;
            editEvent.EventIds = EventIds;
            editEvent.ShowDialog();

            currentID = editEvent.CurrentID;
            EventIds = editEvent.EventIds;
            editEvent.Dispose();
            panelTimelineTab.Controls.Clear();
            panelTimelineContainer.Controls.Clear();

            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                foreach (ObjectId id in EventIds)
                {
                    var tab = timelines.FindById(id);
                    if (id == currentID)
                    {
                        if (tab.Events.Any())
                        {
                            // Need to improve the sorting or the overlapping method. Too difficult
                            tab.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                            PopulateEvents(tab.Events, tab.TimelineStartDate, tab.Id);
                        }
                        else
                        {
                            panelTimelineContainer.Height = 130;
                            Height = panelTimelineContainer.Height + 35;
                        }

                        PopulateDates(tab.TimelineStartDate, tab.TimelineEndDate);
                    }
                    addNewTab(tab.TimelineName, tab.Id);
                }
            }
        }
        else if (e.ClickedItem.Name == openAtBottomOption.Name)
        {
            if (panelTimelineTab.Controls.Count > 1)
            {
                panelTimelineContainer.Controls.Clear();
                MainForm mainForm = (MainForm)this.ParentForm;
                TimelineMain newTimelineMain = new TimelineMain();
                newTimelineMain.currentID = currentID;
                newTimelineMain.Show();
                newTimelineMain.TopLevel = false;
                newTimelineMain.Dock = DockStyle.Top;
                mainForm.tabPanel.Controls.Add(newTimelineMain);
                newTimelineMain.BringToFront();
                mainForm.tabPanel.Focus();
                EventIds.Remove(currentID);

                // Dispose the moved tab
                foreach (TimelineTab tab in panelTimelineTab.Controls)
                {
                    if (currentID == tab.Id)
                    {
                        tab.Dispose();
                        break;
                    }
                }

                // Prevent the loading of moved tab
                foreach (TimelineTab tab in panelTimelineTab.Controls)
                {
                    using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
                    {
                        var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                        var timelineTab = timelines.FindById(tab.Id);

                        if (timelineTab.Events.Any())
                        {
                            // Need to improve the sorting or the overlapping method. Too difficult
                            timelineTab.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                            PopulateEvents(timelineTab.Events, timelineTab.TimelineStartDate, timelineTab.Id);
                        }
                        else
                        {
                            panelTimelineContainer.Height = 130;
                            Height = panelTimelineContainer.Height + 35;
                        }

                        PopulateDates(timelineTab.TimelineStartDate, timelineTab.TimelineEndDate);
                    }
                    tab.timelineTabBtn.BackColor = Color.White;
                    tab.timelineTabBtn.ForeColor = Color.Black;
                    currentID = tab.Id;
                    break;
                }
            }
            else
                new Message("Last remaining tab");

        }
        else if (e.ClickedItem == deletePanelOption)
        {
            MainForm mainForm = (MainForm)this.ParentForm;
            if (mainForm.tabPanel.Controls.Count > 1)
            {
                TimelineMain firstPanel = new TimelineMain();
                foreach (TimelineMain panel in mainForm.tabPanel.Controls.OfType<TimelineMain>())
                {
                    if (panel != this)
                    {
                        firstPanel = panel;
                        break;
                    }
                }

                foreach (TimelineTab tab in panelTimelineTab.Controls)
                {
                    firstPanel.EventIds.Add(tab.Id);
                    firstPanel.addNewTab(tab.TabName, tab.Id);
                }
                this.Dispose();
            }
            else
                new Message("Last remaining panel");
        }
    }
}
