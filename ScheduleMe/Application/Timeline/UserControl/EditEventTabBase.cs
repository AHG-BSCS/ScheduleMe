using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditEventTabBase : UserControl
{
    public ObjectId Id { get; set; }    // Reference Id from the database
    public EditEvent editEventInstance; // Instance that created this UserControl

    public string tabName
    {
        set { eventTab.Text = value; }
    }

    public EditEventTabBase()
    {
        InitializeComponent();
    }

    private void eventTab_Click(object sender, EventArgs e)
    {
        editEventInstance.eventInfoPanel.Controls.Clear();
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
            var timelineTabs = timelines.FindById(Id);
            editEventInstance.currentID = Id;

            if (timelineTabs.Events != null)
            {
                for (ushort i = 0; i < timelineTabs.Events.Count; i++)
                {
                    AddEventRow newRow = new AddEventRow();
                    newRow.SetRowInfo(timelineTabs.Events[i]);
                    newRow.Index = i;
                    newRow.Dock = DockStyle.Top;
                    editEventInstance.eventInfoPanel.Controls.Add(newRow);
                }
            }
        }
    }
}
