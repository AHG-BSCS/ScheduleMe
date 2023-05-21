using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditEventTabBase : UserControl
{
    private string timelineConnection = @"C:\Users\Jhondale\Downloads\Timelines.db";
    public ObjectId Id { get; set; }
    public EditEvent editEventInstance; // instance that created this UserControl

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
        using (var timelineDB = new LiteDatabase(timelineConnection))
        {
            var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
            var timelineTabs = timelines.FindById(Id);
            editEventInstance.currentID = Id;

            if (timelineTabs.Events != null)
            {
                // Load DateTime
                foreach (Event firstEvents in timelineTabs.Events)
                {
                    AddEventRow newRow = new AddEventRow
                    {
                        Title = firstEvents.EventTitle,
                        Description = firstEvents.EventDescription,
                        StartDate = firstEvents.EventStartDate,
                        EndDate = firstEvents.EventEndDate,
                        Color = firstEvents.EventColor,
                    };
                    newRow.Dock = DockStyle.Top;
                    editEventInstance.eventInfoPanel.Controls.Add(newRow);
                }
            }
            editEventInstance.newEventRows.Clear();
        }
    }
}
