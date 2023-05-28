using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditTimelineTab : UserControl
{
    public ObjectId Id { get; set; }
    public EditTimeline EditTimeline { get; set; }

    public event EventHandler<ToolStripItemClickedEventArgs> AddOption_ItemClicked;
    public event EventHandler<ToolStripItemClickedEventArgs> DeleteOption_ItemClicked;

    public string TabName
    {
        set { btnEditTimelineTab.Text = value; }
    }

    public EditTimelineTab()
    {
        InitializeComponent();
    }

    private void HighlightButton()
    {
        EditTimeline.pnlEventRows.Controls.Clear();
        foreach (EditTimelineTab tab in EditTimeline.pnlTimelineTabs.Controls)
        {
            if (EditTimeline.CurrentID == tab.Id)
            {
                tab.btnEditTimelineTab.BackColor = Color.FromArgb(15, 76, 129);
                tab.btnEditTimelineTab.ForeColor = Color.White;
                break;
            }
        }
        btnEditTimelineTab.BackColor = Color.White;
        btnEditTimelineTab.ForeColor = Color.Black;
    }

    private void btnEditTimelineTab_Click(object sender, EventArgs e)
    {
        if (EditTimeline.CurrentID != Id)
        {
            HighlightButton();
            EditTimeline.CurrentID = Id;
            EditTimeline.PreviousID = Id;
            EditTimeline.LoadTimelineById(Id);
            EditTimeline.PreviousID = null;
        }
    }

    private void mnuEditTimelineTab_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == mnuAdd)
        {
            AddOption_ItemClicked?.Invoke(this, e);
        }

        else if (e.ClickedItem == mnuDelete)
        {
            EditTimeline.PreviousID = EditTimeline.CurrentID;
            EditTimeline.CurrentID = Id;
            DeleteOption_ItemClicked?.Invoke(this, e);
            Dispose();
        }
    }
}
