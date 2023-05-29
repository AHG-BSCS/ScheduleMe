using LiteDB;

namespace ScheduleMe.Tab;

public partial class TimelineTab : UserControl
{
    public ObjectId Id { get; set; }
    public TimelinePanel TimelinePanel { get; set; }

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
        TimelinePanel.pnlEvents.Controls.Clear();
        foreach (TimelineTab tab in TimelinePanel.pnlTab.Controls)
        {
            if (TimelinePanel.CurrentID == tab.Id)
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
        TimelinePanel.pnlEvents.Controls.Clear();
        foreach (TimelineTab tab in TimelinePanel.pnlTab.Controls)
        {
            if (TimelinePanel.CurrentID == tab.Id)
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
        if (TimelinePanel.CurrentID != Id)
        {
            HighlightButton();
            using var timelineDB = new LiteDatabase(DBConnection.timelineConnection);
            var timelines = timelineDB.GetCollection<Timeline>("Timeline");
            var timelineTabs = timelines.FindById(Id);
            TimelinePanel.PopulateTimeline(timelineTabs);
            TimelinePanel.CurrentID = Id;
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
                    TimelinePanel.EventIds.Remove(Id);
                    var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                    timelines.Delete(Id); // Delete this Timeline

                    foreach (ObjectId id in TimelinePanel.EventIds)
                    {
                        Timeline firstToLoad = timelines.FindById(id);
                        if (TimelinePanel.CurrentID == Id) // If this Id is deleted
                        {
                            TimelinePanel.CurrentID = firstToLoad.Id;
                            ReverseHighlight();
                            if (firstToLoad != null)
                            {
                                TimelinePanel.PopulateTimeline(firstToLoad);
                            }
                        }
                        break;
                    }

                    if (TimelinePanel.EventIds.Any() == false)
                    {
                        MainForm mainForm = (MainForm)ParentForm.ParentForm;
                        TimelinePanel.pnlEvents.Controls.Clear();
                        TimelinePanel.CurrentID = null;

                        if (mainForm.tabPanel.Controls.Count > 1)
                        {
                            TimelinePanel.Dispose();
                        }
                    }
                }
                Dispose();
            }
            confirm.Dispose();
        }

        else if (e.ClickedItem == mnuOpenAtBottom)
        {
            TimelinePanel.PreviousID = TimelinePanel.CurrentID;
            TimelinePanel.CurrentID = Id;
            OpenAtBottomOption_ItemClicked?.Invoke(this, e);
            TimelinePanel.PreviousID = null;
        }

        else
            TimelineTabMenu_ItemClicked?.Invoke(this, e);
    }
}
