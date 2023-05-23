using LiteDB;

namespace ScheduleMe.Tab;

public partial class TimelineTab : UserControl
{
    public ObjectId Id { get; set; }
    public TimelineMain timelineInstance;

    public string TabName
    {
        set { timelineTabBtn.Text = value; }
    }

    public TimelineTab()
    {
        InitializeComponent();
    }

    private void HighlightButton()
    {
        timelineInstance.panelTimelineContainer.Controls.Clear();
        foreach (TimelineTab tab in timelineInstance.panelTimelineTab.Controls.OfType<TimelineTab>())
        {
            if (timelineInstance.currentID == tab.Id)
            {
                tab.timelineTabBtn.BackColor = Color.FromArgb(15, 76, 129);
                tab.timelineTabBtn.ForeColor = Color.White;
                break;
            }
        }
        timelineTabBtn.BackColor = Color.White;
        timelineTabBtn.ForeColor = Color.Black;
    }

    private void ReverseHighlight()
    {
        timelineInstance.panelTimelineContainer.Controls.Clear();
        foreach (TimelineTab tab in timelineInstance.panelTimelineTab.Controls.OfType<TimelineTab>())
        {
            if (timelineInstance.currentID == tab.Id)
            {
                tab.timelineTabBtn.BackColor = Color.White;
                tab.timelineTabBtn.ForeColor = Color.Black;
                break;
            }
            else
            {
                tab.timelineTabBtn.BackColor = Color.FromArgb(15, 76, 129);
                tab.timelineTabBtn.ForeColor = Color.White;
            }

        }
    }

    private void timelineTabBtn_Click(object sender, EventArgs e)
    {
        if (timelineInstance.currentID != Id)
        {
            HighlightButton();
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var timelineTabs = timelines.FindById(Id);

                if (timelineTabs.Events.Count > 0)
                {
                    timelineTabs.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                    timelineInstance.PopulateEvents(timelineTabs.Events, timelineTabs.TimelineStartDate, timelineTabs.Id);
                }
                else
                    timelineInstance.panelTimelineContainer.Height = 130;

                timelineInstance.PopulateDates(timelineTabs.TimelineStartDate, timelineTabs.TimelineEndDate);
                timelineInstance.currentID = timelineTabs.Id;
            }
        }
    }

    private void timelineTabMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == editOption)
        {
            EditEvent editEvent = new EditEvent();
            editEvent.ShowDialog();

            timelineInstance.panelTimelineTab.Controls.Clear();
            timelineInstance.panelTimelineContainer.Controls.Clear();

            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var lastTab = timelines.FindById(timelineInstance.currentID);

                // Load all the Timeline Tabs
                foreach (var tab in timelines.FindAll())
                {
                    timelineInstance.addNewTab(tab.TimelineName, tab.Id);
                }

                if (lastTab != null) // last tab still exist
                {
                    if (lastTab.Events != null)
                    {
                        // Need to improve the sorting or the overlapping method. Too difficult
                        lastTab.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                        timelineInstance.PopulateEvents(lastTab.Events, lastTab.TimelineStartDate, lastTab.Id);
                    }
                    timelineInstance.PopulateDates(lastTab.TimelineStartDate, lastTab.TimelineEndDate);
                }
                else // last tab doesn't exist
                {
                    Timeline firstTab = timelines.FindAll().First();
                    timelineInstance.currentID = firstTab.Id;
                    
                    if (firstTab != null) // Load the first Timeline.Event List only
                    {
                        if (firstTab.Events != null)
                        {
                            // Need to improve the sorting or the overlapping method. Too difficult
                            firstTab.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                            timelineInstance.PopulateEvents(firstTab.Events, firstTab.TimelineStartDate, firstTab.Id);
                        }
                        timelineInstance.PopulateDates(firstTab.TimelineStartDate, firstTab.TimelineEndDate);
                    }
                }
            }
        }

        else if (e.ClickedItem == addOption)
        {
            AddTimeline addTab = new AddTimeline();
            addTab.ShowDialog();

            if (addTab.Id != null)
            {
                // Load the new added TimelineTab
                using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
                {
                    var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                    var newtTab = new Timeline();
                    newtTab = timelines.FindById(addTab.Id);

                    timelineInstance.addNewTab(newtTab.TimelineName, newtTab.Id);
                    timelineInstance.PopulateDates(newtTab.TimelineStartDate, newtTab.TimelineEndDate);
                }
            }
        }

        else if (e.ClickedItem == deleteOption)
        {
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                timelines.Delete(Id); // Delete this Timeline
                Timeline firstToLoad = timelines.FindAll().First();

                if (timelineInstance.currentID == Id)
                {
                    timelineInstance.currentID = firstToLoad.Id;
                    ReverseHighlight();
                    if (firstToLoad != null)
                    {
                        if (firstToLoad.Events != null)
                        {
                            // Need to improve the sorting or the overlapping method. Too difficult
                            firstToLoad.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                            timelineInstance.PopulateEvents(firstToLoad.Events, firstToLoad.TimelineStartDate, firstToLoad.Id);
                        }
                        timelineInstance.PopulateDates(firstToLoad.TimelineStartDate, firstToLoad.TimelineEndDate);
                    }
                }
            }
            this.Dispose();
        }
    }
}
