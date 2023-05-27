using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditTimelineTab : UserControl
{
    public ObjectId Id { get; set; }
    public EditTimeline editTimeline;
    public event EventHandler<ToolStripItemClickedEventArgs> AddOption_ItemClicked;
    public event EventHandler<ToolStripItemClickedEventArgs> DeleteOption_ItemClicked;

    public string tabName
    {
        set { btnEditTimelineTab.Text = value; }
    }

    public EditTimelineTab()
    {
        InitializeComponent();
    }

    private void HighlightButton()
    {
        editTimeline.pnlEventRows.Controls.Clear();
        foreach (EditTimelineTab tab in editTimeline.pnlTimelineTabs.Controls)
        {
            if (editTimeline.CurrentID == tab.Id)
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
        if (editTimeline.CurrentID != Id)
        {
            HighlightButton();
            editTimeline.CurrentID = Id;
            editTimeline.PreviousID = Id;
            editTimeline.LoadTimelineById(Id);
            editTimeline.PreviousID = null;
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
            editTimeline.PreviousID = editTimeline.CurrentID;
            editTimeline.CurrentID = Id;
            DeleteOption_ItemClicked?.Invoke(this, e);
            this.Dispose();
        }
    }

}
