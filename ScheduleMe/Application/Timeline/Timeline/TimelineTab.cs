using LiteDB;

namespace ScheduleMe.Tab;

public partial class TimelineTab : UserControl
{
    public ObjectId Id { get; set; }
    public TimelineMain timelineInstance;
    public event EventHandler<ToolStripItemClickedEventArgs> TimelineTabMenu_ItemClicked;
    public event EventHandler<ToolStripItemClickedEventArgs> AddOption_ItemClicked;
    public event EventHandler<ToolStripItemClickedEventArgs> OpenAtBottomOption_ItemClicked;

    public string TabName
    {
        get { return timelineTabBtn.Text; }
        set { timelineTabBtn.Text = value; }
    }

    public TimelineTab()
    {
        InitializeComponent();
    }

    private void HighlightButton()
    {
        timelineInstance.panelTimelineContainer.Controls.Clear();
        foreach (TimelineTab tab in timelineInstance.panelTimelineTab.Controls)
        {
            if (timelineInstance.CurrentID == tab.Id)
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
        foreach (TimelineTab tab in timelineInstance.panelTimelineTab.Controls)
        {
            if (timelineInstance.CurrentID == tab.Id)
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
        if (timelineInstance.CurrentID != Id)
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
                {
                    timelineInstance.panelTimelineContainer.Height = 130;
                    timelineInstance.Height = timelineInstance.panelTimelineContainer.Height + 35;
                }

                timelineInstance.PopulateDates(timelineTabs.TimelineStartDate, timelineTabs.TimelineEndDate);
                timelineInstance.CurrentID = Id;
            }
        }
    }

    private void timelineTabMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == addOption)
        {
            AddOption_ItemClicked?.Invoke(this, e);
        }

        else if (e.ClickedItem == deleteOption)
        {
            DeleteTimeline promt = new DeleteTimeline();
            promt.ShowDialog();

            if (promt.Answer)
            {
                using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
                {
                    timelineInstance.EventIds.Remove(Id);
                    var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                    timelines.Delete(Id); // Delete this Timeline

                    foreach (ObjectId id in timelineInstance.EventIds)
                    {
                        Timeline firstToLoad = timelines.FindById(id);
                        if (timelineInstance.CurrentID == Id) // If this Id is deleted
                        {
                            timelineInstance.CurrentID = firstToLoad.Id;
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
                                {
                                    timelineInstance.panelTimelineContainer.Height = 130;
                                    timelineInstance.Height = timelineInstance.panelTimelineContainer.Height + 35;
                                }
                                timelineInstance.PopulateDates(firstToLoad.TimelineStartDate, firstToLoad.TimelineEndDate);
                            }
                        }
                        break;
                    }

                    if (timelineInstance.EventIds.Any() == false)
                    {
                        MainForm mainForm = (MainForm)this.ParentForm.ParentForm;
                        timelineInstance.panelTimelineContainer.Controls.Clear();
                        timelineInstance.CurrentID = null;

                        if (mainForm.tabPanel.Controls.Count > 1)
                        {
                            timelineInstance.Dispose();
                        }
                    }
                }
                this.Dispose();
            }
            promt.Dispose();
        }
        else if (e.ClickedItem == openAtBottomOption)
        {
            timelineInstance.PreviousID = timelineInstance.CurrentID;
            timelineInstance.CurrentID = Id;
            OpenAtBottomOption_ItemClicked?.Invoke(this, e);
            timelineInstance.PreviousID = null;
        }
        else
            TimelineTabMenu_ItemClicked?.Invoke(this, e);
    }
}
