using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditEventTabBase : UserControl
{
    private string timelineConnection = @"C:\Users\Jhondale\Downloads\Timelines.db";
    public ObjectId Id { get; set; }
    public EditEvent editEventInstance;

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
        editEventInstance.timelineTabPanel.Controls.Clear();
        using (var timelineDB = new LiteDatabase(timelineConnection))
        {
            var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
            var timelineTabs = timelines.FindById(Id);

            if (timelineTabs.Events != null)
            {
                // Load DateTime

            }
        }
    }
}
