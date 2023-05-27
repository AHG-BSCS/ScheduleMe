using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditEventTab : UserControl
{
    public ObjectId Id { get; set; }    // Reference Id from the database
    public EditEvent editEventInstance; // Instance that created this UserControl
    public event EventHandler<ToolStripItemClickedEventArgs> AddOption_ItemClicked;
    public event EventHandler<ToolStripItemClickedEventArgs> DeleteOption_ItemClicked;

    public string tabName
    {
        set { timelineTabBtn.Text = value; }
    }

    public EditEventTab()
    {
        InitializeComponent();
    }

    private void HighlightButton()
    {
        editEventInstance.eventInfoPanel.Controls.Clear();
        foreach (EditEventTab tab in editEventInstance.timelineTabPanel.Controls)
        {
            if (editEventInstance.CurrentID == tab.Id)
            {
                tab.timelineTabBtn.BackColor = Color.FromArgb(15, 76, 129);
                tab.timelineTabBtn.ForeColor = Color.White;
                break;
            }
        }
        timelineTabBtn.BackColor = Color.White;
        timelineTabBtn.ForeColor = Color.Black;
    }

    private void eventTab_Click(object sender, EventArgs e)
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

    private void editEventTabMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == addOption)
        {
            AddOption_ItemClicked?.Invoke(this, e);
        }

        else if (e.ClickedItem == deleteOption)
        {
            editEventInstance.PreviousID = editEventInstance.CurrentID;
            editEventInstance.CurrentID = Id;
            DeleteOption_ItemClicked?.Invoke(this, e);
            this.Dispose();
        }
    }
}
