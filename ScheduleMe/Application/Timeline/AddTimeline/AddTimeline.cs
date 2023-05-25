using LiteDB;

namespace ScheduleMe.Tab;

public partial class AddTimeline : Form
{
    public ObjectId Id { get; set; }

    public AddTimeline()
    {
        InitializeComponent();
    }

    private void btnSaveTimeline_Click(object sender, EventArgs e)
    {
        if (tBoxName.Text != "")
        {
            if (startDatePicker.Value < endDatePicker.Value)
                CreateTimeline();
            else
                MessageBox.Show("Invalid Dates");
        }
        else
            MessageBox.Show("Invalid Name");
    }

    private void btnCancelTimeline_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void CreateTimeline()
    {
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<Timeline>("Timeline");

            var newTimeline = new Timeline
            {
                TimelineName = tBoxName.Text,
                TimelineStartDate = startDatePicker.Value,
                TimelineEndDate = endDatePicker.Value,
            };

            // For testing purpose only. To be remove later
            if (tBoxName.Text == "Test Dates")
            {
                newTimeline.Events = new List<Event>
                {
                    new Event { EventStartDate = new DateTime(2023, 4, 6), EventEndDate = new DateTime(2023, 4, 9), EventColor = -15987921, EventTitle = "Event 1" },
                    new Event { EventStartDate = new DateTime(2023, 4, 4), EventEndDate = new DateTime(2023, 4, 8), EventColor = -15987921, EventTitle = "Event 2" },
                    new Event { EventStartDate = new DateTime(2023, 4, 5), EventEndDate = new DateTime(2023, 4, 7), EventColor = -15987921, EventTitle = "Event 3" },
                    new Event { EventStartDate = new DateTime(2023, 4, 2), EventEndDate = new DateTime(2023, 4, 4), EventColor = -15987921, EventTitle = "Event 4" },
                    new Event {EventStartDate = new DateTime(2023, 4, 3), EventEndDate = new DateTime(2023, 4, 6), EventColor = -15987921, EventTitle = "Event 5" },
                    new Event {EventStartDate = new DateTime(2023, 4, 1), EventEndDate = new DateTime(2023, 4, 5), EventColor = -15987921, EventTitle = "Event 6" },
                    new Event {EventStartDate = new DateTime(2023, 4, 1), EventEndDate = new DateTime(2023, 4, 2), EventColor = -15987921, EventTitle = "Event 7" },
                    new Event {EventStartDate = new DateTime(2023, 4, 1), EventEndDate = new DateTime(2023, 4, 3), EventColor = -15987921, EventTitle = "Event 8" },
                    new Event {EventStartDate = new DateTime(2023, 4, 6), EventEndDate = new DateTime(2023, 4, 16), EventColor = -15987921, EventTitle = "Event 9" },
                    new Event {EventStartDate = new DateTime(2023, 4, 11), EventEndDate = new DateTime(2023, 4, 17), EventColor = -15987921, EventTitle = "Event 10" },
                    new Event {EventStartDate = new DateTime(2023, 4, 12), EventEndDate = new DateTime(2023, 4, 16), EventColor = -15987921, EventTitle = "Event 11" },
                    new Event { EventStartDate = new DateTime(2023, 5, 18), EventEndDate = new DateTime(2023, 5, 21), EventColor = -15987921, EventTitle = "Event 12" }
                };
            }
            timelines.Insert(newTimeline);
            Id = newTimeline.Id;
        }
        this.Close();
    }
}
