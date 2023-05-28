using LiteDB;

namespace ScheduleMe.Tab;

public partial class TimelinePanel : Form
{
    public ObjectId CurrentID { get; set; }
    public ObjectId PreviousID { get; set; }
    public List<ObjectId> EventIds { get; set; } = new List<ObjectId>();

    private readonly byte columnSize = 42;
    private int currentDateTimePosition = 0;

    public TimelinePanel()
    {
        InitializeComponent();
    }

    private void Timeline_Load(object sender, EventArgs e)
    {
        if (CurrentID == null)
            LoadFirstTimeline();

        else if (CurrentID != null)
            LoadTimelineById(CurrentID);
    }

    private void LoadFirstTimeline()
    {
        using var timelineDB = new LiteDatabase(DBConnection.timelineConnection);
        var timelines = timelineDB.GetCollection<Timeline>("Timeline");
        var timelineTabs = timelines.FindAll();

        if (timelineTabs.Any())
        {
            Timeline firstToLoad = timelineTabs.First();
            CurrentID = firstToLoad.Id;

            foreach (var tab in timelineTabs) // Load all the Timeline Tabs
            {
                EventIds.Add(tab.Id);
                AddNewTab(tab.TimelineName, tab.Id);
            }
            PopulateTimeline(firstToLoad);
        }
    }

    private void LoadTimelineById(ObjectId id)
    {
        using var timelineDB = new LiteDatabase(DBConnection.timelineConnection);
        var timelines = timelineDB.GetCollection<Timeline>("Timeline");
        var timelineTab = timelines.FindById(id);
        EventIds.Add(id);
        AddNewTab(timelineTab.TimelineName, timelineTab.Id);
        PopulateTimeline(timelineTab);
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
            pnlEvents.Height = 130;
            Height = pnlEvents.Height + 35;
        }
        PopulateDates(timeline.TimelineStartDate, timeline.TimelineEndDate);
    }

    private void PopulateEvents(List<Event> events, DateTime startDate, ObjectId id)
    {
        int lowestBottom = 0;

        for (ushort i = 0; i < events.Count; i++)
        {
            int eventDuration = (int)(events[i].EventEndDate - events[i].EventStartDate).TotalDays;
            int eventsXAxis = pnlEvents.HorizontalScroll.Value
                        + ((events[i].EventStartDate - startDate).Days
                        * columnSize);

            TimelineEvent newEvent = new TimelineEvent();
            newEvent.SetEventProperty(
                events[i].EventTitle,
                events[i].EventDescription,
                events[i].EventStartDate,
                events[i].EventEndDate,
                events[i].EventColor);
            newEvent.Id = id;
            newEvent.Index = i;
            newEvent.Width = (eventDuration * columnSize) + 1;
            newEvent.Location = new Point(eventsXAxis + 17, 70);

            pnlEvents.Controls.Add(newEvent);
            StackEvents(newEvent, ref lowestBottom);
        }
        pnlEvents.Height = lowestBottom + 30;
        Height = pnlEvents.Height + 35;
    }

    private void StackEvents(TimelineEvent newEvent, ref int lowestBottom)
    {
        int currentRow = 70;

        foreach (TimelineEvent previousEvent in pnlEvents.Controls)
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
                GenerateMonthLabel(currentDate, startDate, ref firstMonthRight);

            TimelineDays timelineDays = new TimelineDays();
            timelineDays.Day = currentDate.ToString("ddd");
            timelineDays.Date = currentDate.Day.ToString();
            timelineDays.Location = new Point(columnSize * (currentDate - startDate).Days, 23 - 5);
            pnlEvents.Controls.Add(timelineDays);

            Panel line = new Panel();
            line.BackColor = Color.Black;
            line.Width = 1;
            line.Height = pnlEvents.Height - 58;
            line.Location = new Point(timelineDays.Left + (timelineDays.Width / 2), timelineDays.Height);
            pnlEvents.Controls.Add(line);

            if (currentDate.DayOfYear == DateTime.Now.DayOfYear && currentDate.Year == DateTime.Now.Year)
            {
                Point point = new Point(timelineDays.Left + (timelineDays.Width / 2)
                    + ((int)(columnSize * (float)(DateTime.Now.Hour / 24.0))),
                    timelineDays.Height - 22);
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
        pnlEvents.Controls.Add(nextMonths);

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
        timeIndicatorLine.Height = pnlEvents.Height - 35;
        timeIndicatorLine.Location = point;
        pnlEvents.Controls.Add(timeIndicatorLine);
        timeIndicatorLine.BringToFront();

        Label timeIndicatorText = new Label();
        timeIndicatorText.BackColor = Color.FromArgb(15, 76, 129);
        timeIndicatorText.ForeColor = Color.White;
        timeIndicatorText.Text = DateTime.Now.ToString("hh:mm tt");
        timeIndicatorText.Font = new Font("Dubai", 8, FontStyle.Bold);
        timeIndicatorText.Location = new Point(timeIndicatorLine.Left, timeIndicatorLine.Top - 14);
        timeIndicatorText.AutoSize = true;
        pnlEvents.Controls.Add(timeIndicatorText);
        timeIndicatorText.BringToFront();
        return timeIndicatorLine.Left;
    }

    public void AddNewTab(string timelineName, ObjectId Id)
    {
        TimelineTab newTimelineTab = new TimelineTab();
        newTimelineTab.TimelineTabMenu_ItemClicked += mnuTimeline_ItemClicked;
        newTimelineTab.AddOption_ItemClicked += btnAddTab_Click;
        newTimelineTab.OpenAtBottomOption_ItemClicked += mnuTimeline_ItemClicked;
        newTimelineTab.TabName = timelineName;
        newTimelineTab.Id = Id;
        newTimelineTab.timelinePanel = this;
        newTimelineTab.Dock = DockStyle.Left;
        pnlTab.Controls.Add(newTimelineTab);
        newTimelineTab.BringToFront();

        if (CurrentID == Id) // Highlight the current tab
        {
            newTimelineTab.btnTab.BackColor = Color.White;
            newTimelineTab.btnTab.ForeColor = Color.Black;
        }
    }

    private void btnJump_Click(object sender, EventArgs e) // Need to improve
    {
        Screen screen = Screen.PrimaryScreen;
        short screenWidth = (short)screen.Bounds.Width;
        pnlEvents.AutoScrollPosition = new Point(currentDateTimePosition - (screenWidth / 2));
    }

    private void btnAddTab_Click(object sender, EventArgs e)
    {
        AddTimeline addTimeline = new AddTimeline();
        addTimeline.ShowDialog();

        if (addTimeline.Id != null)
        {
            foreach (TimelineTab tab in pnlTab.Controls) // Remove the highlight of active Tab
            {
                if (CurrentID == tab.Id)
                {
                    tab.btnTab.BackColor = Color.FromArgb(15, 76, 129);
                    tab.btnTab.ForeColor = Color.White;
                    break;
                }
            }
            // Load the new added TimelineTab
            pnlEvents.Controls.Clear();
            pnlEvents.Height = 130;
            Height = pnlEvents.Height + 35;
            CurrentID = addTimeline.Id;
            LoadTimelineById(addTimeline.Id);
        }
        addTimeline.Dispose();
    }

    private void mnuTimeline_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem.Name == mnuEdit.Name)
        {
            MainForm mainForm = (MainForm)ParentForm;
            EditTimeline editTimeline = new EditTimeline();
            editTimeline.CurrentID = CurrentID;
            editTimeline.EventIds = EventIds;
            editTimeline.ShowDialog();

            CurrentID = editTimeline.CurrentID;
            EventIds = editTimeline.EventIds;
            editTimeline.Dispose();
            pnlTab.Controls.Clear();
            pnlEvents.Controls.Clear();

            if (EventIds.Any())
            {
                using var timelineDB = new LiteDatabase(DBConnection.timelineConnection);
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                foreach (ObjectId id in EventIds)
                {
                    var tab = timelines.FindById(id);
                    AddNewTab(tab.TimelineName, tab.Id);

                    if (id == CurrentID)
                        PopulateTimeline(tab);
                }
            }
            else if (mainForm.tabPanel.Controls.Count > 1)
                Dispose();
        }

        else if (e.ClickedItem.Name == mnuOpenAtBottom.Name)
        {
            if (pnlTab.Controls.Count > 1)
            {
                pnlEvents.Controls.Clear();
                MainForm mainForm = (MainForm)ParentForm;
                TimelinePanel newtimelinePanel = new TimelinePanel();
                newtimelinePanel.CurrentID = CurrentID;
                newtimelinePanel.Show();
                newtimelinePanel.TopLevel = false;
                newtimelinePanel.Dock = DockStyle.Top;
                mainForm.tabPanel.Controls.Add(newtimelinePanel);
                newtimelinePanel.BringToFront();
                mainForm.tabPanel.Focus();
                EventIds.Remove(CurrentID);

                foreach (TimelineTab tab in pnlTab.Controls) // Dispose the moved tab
                {
                    if (CurrentID == tab.Id)
                    {
                        tab.Dispose();
                        break;
                    }
                }

                foreach (TimelineTab tab in pnlTab.Controls) // Prevent the loading of moved tab
                {
                    using var timelineDB = new LiteDatabase(DBConnection.timelineConnection);
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
                        tab.btnTab.BackColor = Color.White;
                        tab.btnTab.ForeColor = Color.Black;
                        CurrentID = tab.Id;
                    }
                    PopulateTimeline(timelineTab);
                    break;
                }
            }
            else
                new Message("Last remaining tab");
        }

        else if (e.ClickedItem == mnuDeletePanel)
        {
            MainForm mainForm = (MainForm)ParentForm;
            if (mainForm.tabPanel.Controls.Count > 1)
            {
                // Look for the a panel to move the tab
                TimelinePanel lastTimelinePanel = new TimelinePanel();
                foreach (TimelinePanel panel in mainForm.tabPanel.Controls.OfType<TimelinePanel>())
                {
                    if (panel != this)
                    {
                        lastTimelinePanel = panel;
                        break;
                    }
                }

                foreach (TimelineTab tab in pnlTab.Controls) // Add the tab
                {
                    lastTimelinePanel.EventIds.Add(tab.Id);
                    lastTimelinePanel.AddNewTab(tab.TabName, tab.Id);
                }
                Dispose();
            }
            else
                new Message("Last remaining panel");
        }
    }
}
