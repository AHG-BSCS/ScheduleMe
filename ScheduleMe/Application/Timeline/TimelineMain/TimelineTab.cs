using LiteDB;

namespace ScheduleMe.Tab;

public partial class TimelineTab : UserControl
{
    public ObjectId Id { get; set; }
    public TimelinePanel timelinePanel;
    public event EventHandler<ToolStripItemClickedEventArgs> TimelineTabMenu_ItemClicked;
    public event EventHandler<ToolStripItemClickedEventArgs> AddOption_ItemClicked;
    public event EventHandler<ToolStripItemClickedEventArgs> OpenAtBottomOption_ItemClicked;

    public string TabName
    {
        get { return btnTab.Text; }
        set { btnTab.Text = value; }
    }

    public TimelineTab()
    {
        InitializeComponent();
    }

    private void HighlightButton()
    {
        timelinePanel.pnlEvents.Controls.Clear();
        foreach (TimelineTab tab in timelinePanel.pnlTab.Controls)
        {
            if (timelinePanel.CurrentID == tab.Id)
            {
                tab.btnTab.BackColor = Color.FromArgb(15, 76, 129);
                tab.btnTab.ForeColor = Color.White;
                break;
            }
        }
        btnTab.BackColor = Color.White;
        btnTab.ForeColor = Color.Black;
    }

    private void ReverseHighlight()
    {
        timelinePanel.pnlEvents.Controls.Clear();
        foreach (TimelineTab tab in timelinePanel.pnlTab.Controls)
        {
            if (timelinePanel.CurrentID == tab.Id)
            {
                tab.btnTab.BackColor = Color.White;
                tab.btnTab.ForeColor = Color.Black;
                break;
            }
            else
            {
                tab.btnTab.BackColor = Color.FromArgb(15, 76, 129);
                tab.btnTab.ForeColor = Color.White;
            }
        }
    }

    private void btnTab_Click(object sender, EventArgs e)
    {
        if (timelinePanel.CurrentID != Id)
        {
            HighlightButton();
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var timelineTabs = timelines.FindById(Id);
                timelinePanel.PopulateTimeline(timelineTabs);
                timelinePanel.CurrentID = Id;
            }
        }
    }

    private void mnuTab_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == mnuAdd)
        {
            AddOption_ItemClicked?.Invoke(this, e);
        }

        else if (e.ClickedItem == mnuDelete)
        {
            Confirm confirm = new Confirm();
            confirm.ShowDialog();

            if (confirm.Answer)
            {
                using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
                {
                    timelinePanel.EventIds.Remove(Id);
                    var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                    timelines.Delete(Id); // Delete this Timeline

                    foreach (ObjectId id in timelinePanel.EventIds)
                    {
                        Timeline firstToLoad = timelines.FindById(id);
                        if (timelinePanel.CurrentID == Id) // If this Id is deleted
                        {
                            timelinePanel.CurrentID = firstToLoad.Id;
                            ReverseHighlight();
                            if (firstToLoad != null)
                            {
                                timelinePanel.PopulateTimeline(firstToLoad);
                            }
                        }
                        break;
                    }

                    if (timelinePanel.EventIds.Any() == false)
                    {
                        MainForm mainForm = (MainForm)this.ParentForm.ParentForm;
                        timelinePanel.pnlEvents.Controls.Clear();
                        timelinePanel.CurrentID = null;

                        if (mainForm.tabPanel.Controls.Count > 1)
                        {
                            timelinePanel.Dispose();
                        }
                    }
                }
                this.Dispose();
            }
            confirm.Dispose();
        }
        else if (e.ClickedItem == mnuOpenAtBottom)
        {
            timelinePanel.PreviousID = timelinePanel.CurrentID;
            timelinePanel.CurrentID = Id;
            OpenAtBottomOption_ItemClicked?.Invoke(this, e);
            timelinePanel.PreviousID = null;
        }
        else
            TimelineTabMenu_ItemClicked?.Invoke(this, e);
    }

}
