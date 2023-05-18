using LiteDB;

namespace ScheduleMe.Tab;

public partial class AddTimelineTab : Form
{
    private string timelineConnection = @"C:\Users\Jhondale\Documents\CODE\C#\GitHub\ScheduleMe\ScheduleMe\Database\Timelines.db";
    public string timelineName { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }

    public AddTimelineTab()
    {
        InitializeComponent();
    }

    private void btnSaveTimeline_Click(object sender, EventArgs e)
    {
        using (var timelineDB = new LiteDatabase(timelineConnection))
        {
            var timelines = timelineDB.GetCollection<AddTimelineTab>(tBoxName.Text);

            var timeline1 = new AddTimelineTab();
            {
                timelineName = tBoxName.Text;
                startDate = startDatePicker.Value;
                endDate = endDatePicker.Value;
            };

            timelines.Insert(timeline1);
        }

        this.Close();
    }

    private void btnCancelTimeline_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
