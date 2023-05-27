using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditTimelineTab : UserControl
{
    public ObjectId Id { get; set; }
    public EditTimeline editEventInstance;
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
        editEventInstance.pnlEventRows.Controls.Clear();
        foreach (EditTimelineTab tab in editEventInstance.pnlTimelineTabs.Controls)
        {
            if (editEventInstance.CurrentID == tab.Id)
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
        if (editEventInstance.CurrentID != Id)
        {
            HighlightButton();
            editEventInstance.CurrentID = Id;
            editEventInstance.PreviousID = Id;
            editEventInstance.LoadTimelineById(Id);
            editEventInstance.PreviousID = null;
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
            editEventInstance.PreviousID = editEventInstance.CurrentID;
            editEventInstance.CurrentID = Id;
            DeleteOption_ItemClicked?.Invoke(this, e);
            this.Dispose();
        }
    }

}
