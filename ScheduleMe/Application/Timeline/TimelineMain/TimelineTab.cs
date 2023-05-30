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
                tab.btnTab.BackColor = MainDesigner.ThemeColor;
                break;
            }
        }
        btnTab.BackColor = MainDesigner.HighlightColor;
    }

    private void ReverseHighlight()
    {
        TimelinePanel.pnlEvents.Controls.Clear();
        foreach (TimelineTab tab in TimelinePanel.pnlTab.Controls)
        {
            if (TimelinePanel.CurrentID == tab.Id)
            {
                tab.btnTab.BackColor = MainDesigner.HighlightColor;
                break;
            }
            else
            {
                tab.btnTab.BackColor = MainDesigner.ThemeColor;
            }
        }
    }

    private void btnTab_Click(object sender, EventArgs e)
    {
        if (TimelinePanel.CurrentID != Id)
        {
            HighlightButton();
            using var timelineConnection = new LiteDatabase(DBConnection.databaseConnection);
            var timelineDB = timelineConnection.GetCollection<Timeline>("Timeline");
            var timeline = timelineDB.FindById(Id);
            TimelinePanel.CurrentDateTimePosition = 0;
            TimelinePanel.PopulateTimeline(timeline);
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
                if (TimelinePanel.CurrentDateTimePosition != 0)
                    TimelinePanel.CurrentDateTimePosition = 0;

                using (var timelineConnection = new LiteDatabase(DBConnection.databaseConnection))
                {
                    TimelinePanel.EventIds.Remove(Id);
                    var timelineDB = timelineConnection.GetCollection<Timeline>("Timeline");
                    timelineDB.Delete(Id); // Delete this Timeline

                    foreach (ObjectId id in TimelinePanel.EventIds)
                    {
                        Timeline firstToLoad = timelineDB.FindById(id);
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
