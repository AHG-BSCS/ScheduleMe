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

                if (timelineTabs.Events.Any())
                {
                    timelineTabs.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                    timelineInstance.PopulateEvents(timelineTabs.Events, timelineTabs.TimelineStartDate, timelineTabs.Id);
                }
                else
                    timelineInstance.panelTimelineContainer.Height = 130;

                timelineInstance.PopulateDates(timelineTabs.TimelineStartDate, timelineTabs.TimelineEndDate);
                timelineInstance.currentID = Id;
            }
        }
    }

    private void timelineTabMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == editOption)
        {
            EditEvent editEvent = new EditEvent();
            editEvent.CurrentID = Id;
            editEvent.ShowDialog();

            timelineInstance.currentID = editEvent.CurrentID;
            editEvent.Dispose();
            timelineInstance.panelTimelineTab.Controls.Clear();
            timelineInstance.panelTimelineContainer.Controls.Clear();

            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var timeline = timelines.FindAll();

                // Load all the Timeline Tabs
                foreach (var tab in timeline)
                {
                    timelineInstance.addNewTab(tab.TimelineName, tab.Id);
                }

                if (timelines.FindById(timelineInstance.currentID) != null) // last tab still exist
                {
                    var lastTab = timelines.FindById(timelineInstance.currentID);
                    if (lastTab.Events.Any())
                    {
                        // Need to improve the sorting or the overlapping method. Too difficult
                        lastTab.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                        timelineInstance.PopulateEvents(lastTab.Events, lastTab.TimelineStartDate, lastTab.Id);
                    }
                    timelineInstance.PopulateDates(lastTab.TimelineStartDate, lastTab.TimelineEndDate);
                }
                else if (timeline.Any())// last tab doesn't exist
                {
                    Timeline firstTab = timelines.FindAll().First();
                    timelineInstance.currentID = firstTab.Id;

                    if (firstTab != null) // Load the first Timeline.Event List only
                    {
                        if (firstTab.Events.Any())
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
            addTab.Dispose();
        }

        else if (e.ClickedItem == deleteOption)
        {
            DeleteTimeline promt = new DeleteTimeline();
            promt.ShowDialog();

            if (promt.Answer)
            {
                using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
                {
                    var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                    timelines.Delete(Id); // Delete this Timeline
                    var timeline = timelines.FindAll();
                    if (timeline.Any())
                    {
                        Timeline firstToLoad = timeline.First();
                        if (timelineInstance.currentID == Id)
                        {
                            timelineInstance.currentID = firstToLoad.Id;
                            ReverseHighlight();
                            if (firstToLoad != null)
                            {
                                if (firstToLoad.Events.Any())
                                {
                                    // Need to improve the sorting or the overlapping method. Too difficult
                                    firstToLoad.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                                    timelineInstance.PopulateEvents(firstToLoad.Events, firstToLoad.TimelineStartDate, firstToLoad.Id);
                                }
                                else
                                    timelineInstance.panelTimelineContainer.Height = 130;
                                timelineInstance.PopulateDates(firstToLoad.TimelineStartDate, firstToLoad.TimelineEndDate);
                            }
                        }
                    }
                    else
                    {
                        timelineInstance.panelTimelineContainer.Controls.Clear();
                        timelineInstance.currentID = null;
                    }
                }
                this.Dispose();
            }
            promt.Dispose();
        }
    }
}
