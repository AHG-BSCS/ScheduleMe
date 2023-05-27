using LiteDB;

namespace ScheduleMe.Tab;

public partial class TimelineMain : Form
{
    public ObjectId CurrentID { get; set; }
    public ObjectId PreviousID { get; set; }
    private List<ObjectId> _eventIds = new List<ObjectId>();
    private byte columnSize = 42;
    private int currentDateTimePosition = 0;
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
        if (CurrentID == null)
        {
            LoadFirstTimeline();
        }

        else if (CurrentID != null)
        {
            LoadTimelineById(CurrentID);
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
                CurrentID = firstToLoad.Id;

                // Load all the Timeline Tabs
                foreach (var tab in timelineTabs)
                {
                    EventIds.Add(tab.Id);
                    AddNewTab(tab.TimelineName, tab.Id);
                }
                PopulateTimeline(firstToLoad);
            }
        }
    }

    private void LoadTimelineById(ObjectId id)
    {
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<Timeline>("Timeline");
            var timelineTab = timelines.FindById(id);
            EventIds.Add(id);
            AddNewTab(timelineTab.TimelineName, timelineTab.Id);
            PopulateTimeline(timelineTab);
        }
    }

    internal void PopulateTimeline(Timeline timeline)
    {
        if (timeline.Events.Any())
        {
            // Need to improve the sorting or the overlapping method. Too difficult
            timeline.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
            PopulateEvents(timeline.Events, timeline.TimelineStartDate, timeline.Id);
        }
        else
        {
            panelTimelineContainer.Height = 130;
            Height = panelTimelineContainer.Height + 35;
        }
        PopulateDates(timeline.TimelineStartDate, timeline.TimelineEndDate);
    }

    private void PopulateEvents(List<Event> events, DateTime startDate, ObjectId id)
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

    private void PopulateDates(DateTime startDate, DateTime endDate)
    {
        int firstMonthRight = 0;
        for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            if (currentDate.Day == 1 || currentDate.DayOfYear == startDate.DayOfYear)
            {
                GenerateMonthLabel(currentDate, startDate, ref firstMonthRight);
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

            if (currentDate.DayOfYear == DateTime.Now.DayOfYear && currentDate.Year == DateTime.Now.Year)
            {
                Point point = new Point((dayDates.Left + dayDates.Width / 2)
                    + ((int)((float)columnSize * (float)(DateTime.Now.Hour / 24.0))),
                    dayDates.Height - 22);
                currentDateTimePosition = GenerateTimeIndicator(point);
                line.Width = 2;
            }
        }
    }

    private void GenerateMonthLabel(DateTime currentDate, DateTime startDate, ref int firstMonthRight)
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

    private int GenerateTimeIndicator(Point point)
    {
        Panel timeIndicatorLine = new Panel();
        timeIndicatorLine.BackColor = Color.FromArgb(15, 76, 129);
        timeIndicatorLine.Width = 3;
        timeIndicatorLine.Height = panelTimelineContainer.Height - 35;
        timeIndicatorLine.Location = point;
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
        return timeIndicatorLine.Left;
    }

    public void AddNewTab(string timelineName, ObjectId Id)
    {
        TimelineTab newTimelineTab = new TimelineTab();
        newTimelineTab.TimelineTabMenu_ItemClicked += timelineMenu_ItemClicked;
        newTimelineTab.AddOption_ItemClicked += addTabBtn_Click;
        newTimelineTab.OpenAtBottomOption_ItemClicked += timelineMenu_ItemClicked;
        newTimelineTab.TabName = timelineName;
        newTimelineTab.Id = Id;
        newTimelineTab.timelineInstance = this;
        newTimelineTab.Dock = DockStyle.Left;
        panelTimelineTab.Controls.Add(newTimelineTab);
        newTimelineTab.BringToFront();

        // Highlight the current tab
        if (CurrentID == Id)
        {
            newTimelineTab.tabBtn.BackColor = Color.White;
            newTimelineTab.tabBtn.ForeColor = Color.Black;
        }
    }

    private void seekTodayBtn_Click(object sender, EventArgs e)
    {
        // Need to improve
        Screen screen = Screen.PrimaryScreen;
        short screenWidth = (short)screen.Bounds.Width;
        panelTimelineContainer.AutoScrollPosition = new Point(currentDateTimePosition - (screenWidth / 2));
    }

    private void addTabBtn_Click(object sender, EventArgs e)
    {
        AddTimeline addTimelineTab = new AddTimeline();
        addTimelineTab.ShowDialog();

        if (addTimelineTab.Id != null)
        {
            // Remove the highlight of active Tab
            foreach (TimelineTab tab in panelTimelineTab.Controls)
            {
                if (CurrentID == tab.Id)
                {
                    tab.tabBtn.BackColor = Color.FromArgb(15, 76, 129);
                    tab.tabBtn.ForeColor = Color.White;
                    break;
                }
            }
            // Load the new added TimelineTab
            panelTimelineContainer.Controls.Clear();
            panelTimelineContainer.Height = 130;
            Height = panelTimelineContainer.Height + 35;
            CurrentID = addTimelineTab.Id;
            LoadTimelineById(addTimelineTab.Id);
        }
        addTimelineTab.Dispose();
    }

    private void timelineMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem.Name == editOption.Name)
        {
            EditEvent editEvent = new EditEvent();
            editEvent.CurrentID = CurrentID;
            editEvent.EventIds = EventIds;
            editEvent.ShowDialog();

            CurrentID = editEvent.CurrentID;
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
                    AddNewTab(tab.TimelineName, tab.Id);

                    if (id == CurrentID)
                        PopulateTimeline(tab);
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
                newTimelineMain.CurrentID = CurrentID;
                newTimelineMain.Show();
                newTimelineMain.TopLevel = false;
                newTimelineMain.Dock = DockStyle.Top;
                mainForm.tabPanel.Controls.Add(newTimelineMain);
                newTimelineMain.BringToFront();
                mainForm.tabPanel.Focus();
                EventIds.Remove(CurrentID);

                // Dispose the moved tab
                foreach (TimelineTab tab in panelTimelineTab.Controls)
                {
                    if (CurrentID == tab.Id)
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
                        Timeline timelineTab;
                        if (CurrentID != PreviousID && PreviousID != null)
                        {
                            timelineTab = timelines.FindById(PreviousID);
                            CurrentID = PreviousID;
                        }
                        else
                        {
                            timelineTab = timelines.FindById(tab.Id);
                            tab.tabBtn.BackColor = Color.White;
                            tab.tabBtn.ForeColor = Color.Black;
                            CurrentID = tab.Id;
                        }
                        PopulateTimeline(timelineTab);
                    }
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
                    firstPanel.AddNewTab(tab.TabName, tab.Id);
                }
                this.Dispose();
            }
            else
                new Message("Last remaining panel");
        }
    }

}
