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
        get { return tabBtn.Text; }
        set { tabBtn.Text = value; }
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
                tab.tabBtn.BackColor = Color.FromArgb(15, 76, 129);
                tab.tabBtn.ForeColor = Color.White;
                break;
            }
        }
        tabBtn.BackColor = Color.White;
        tabBtn.ForeColor = Color.Black;
    }

    private void ReverseHighlight()
    {
        timelineInstance.panelTimelineContainer.Controls.Clear();
        foreach (TimelineTab tab in timelineInstance.panelTimelineTab.Controls)
        {
            if (timelineInstance.CurrentID == tab.Id)
            {
                tab.tabBtn.BackColor = Color.White;
                tab.tabBtn.ForeColor = Color.Black;
                break;
            }
            else
            {
                tab.tabBtn.BackColor = Color.FromArgb(15, 76, 129);
                tab.tabBtn.ForeColor = Color.White;
            }
        }
    }

    private void tabBtn_Click(object sender, EventArgs e)
    {
        if (timelineInstance.CurrentID != Id)
        {
            HighlightButton();
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var timelineTabs = timelines.FindById(Id);
                timelineInstance.PopulateTimeline(timelineTabs);
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
                                timelineInstance.PopulateTimeline(firstToLoad);
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
