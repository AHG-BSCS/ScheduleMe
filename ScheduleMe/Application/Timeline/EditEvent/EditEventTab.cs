using LiteDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

    private void ReverseHighlight()
    {
        editEventInstance.eventInfoPanel.Controls.Clear();
        foreach (EditEventTab tab in editEventInstance.timelineTabPanel.Controls)
        {
            if (editEventInstance.CurrentID == tab.Id)
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

    private void eventTab_Click(object sender, EventArgs e)
    {
        if (editEventInstance.CurrentID != Id)
        {
            HighlightButton();
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var timelineTab = timelines.FindById(Id);
                editEventInstance.CurrentID = Id;
                editEventInstance.MinDate = timelineTab.TimelineStartDate;
                editEventInstance.MaxDate = timelineTab.TimelineEndDate;
                editEventInstance.SetTimelineDateRange();

                if (timelineTab.Events.Any())
                {
                    for (ushort i = 0; i < timelineTab.Events.Count; i++)
                    {
                        AddEventRow newRow = new AddEventRow();
                        newRow.Id = timelineTab.Id;
                        newRow.Index = i;
                        newRow.MinDate = timelineTab.TimelineStartDate;
                        newRow.MaxDate = timelineTab.TimelineEndDate;
                        newRow.Dock = DockStyle.Bottom;
                        newRow.SetRowInfo(timelineTab.Events[i]);
                        editEventInstance.eventInfoPanel.Controls.Add(newRow);
                    }
                }
            }
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
            DeleteOption_ItemClicked?.Invoke(this, e);
        }
    }
}
