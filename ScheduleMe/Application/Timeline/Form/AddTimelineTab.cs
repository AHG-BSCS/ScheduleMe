using LiteDB;

namespace ScheduleMe.Tab;

public partial class AddTimelineTab : Form
{
    private string timelineConnection = @"C:\Users\Jhondale\Documents\CODE\C#\GitHub\ScheduleMe\ScheduleMe\Database\Timelines.db";
    public ObjectId Id { get; set; }

    public AddTimelineTab()
    {
        InitializeComponent();
    }

    private void btnSaveTimeline_Click(object sender, EventArgs e)
    {
        using (var timelineDB = new LiteDatabase(timelineConnection))
        {
            var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");

            var newTimeline = new TimelineTab
            {
                TimelineName = tBoxName.Text,
                TimelineStartDate = startDatePicker.Value,
                TimelineEndDate = endDatePicker.Value
            };
            timelines.Insert(newTimeline);
            Id = newTimeline.Id;
        }
        this.Close();
    }

    private void btnCancelTimeline_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
