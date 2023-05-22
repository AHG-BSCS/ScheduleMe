using LiteDB;

namespace ScheduleMe.Tab;

public partial class AddTimelineTab : Form
{
    private string timelineConnection = @"C:\Users\Jhondale\Downloads\Timelines.db";
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
                TimelineEndDate = endDatePicker.Value,
            };

            // For testing purpose only. To be remove later
            if (tBoxName.Text == "Test")
            {
                newTimeline.Events = new List<Event>
                {
                    new Event { EventStartDate = new DateTime(2023, 4, 6), EventEndDate = new DateTime(2023, 4, 9) },
                    new Event { EventStartDate = new DateTime(2023, 4, 4), EventEndDate = new DateTime(2023, 4, 8) },
                    new Event { EventStartDate = new DateTime(2023, 4, 5), EventEndDate = new DateTime(2023, 4, 7) },
                    new Event { EventStartDate = new DateTime(2023, 4, 2), EventEndDate = new DateTime(2023, 4, 4) },
                    new Event { EventStartDate = new DateTime(2023, 4, 3), EventEndDate = new DateTime(2023, 4, 6) },
                    new Event { EventStartDate = new DateTime(2023, 4, 1), EventEndDate = new DateTime(2023, 4, 5) },
                    new Event { EventStartDate = new DateTime(2023, 4, 1), EventEndDate = new DateTime(2023, 4, 2) },
                    new Event { EventStartDate = new DateTime(2023, 4, 1), EventEndDate = new DateTime(2023, 4, 3) },
                    new Event { EventStartDate = new DateTime(2023, 4, 6), EventEndDate = new DateTime(2023, 4, 16) },
                    new Event { EventStartDate = new DateTime(2023, 4, 11), EventEndDate = new DateTime(2023, 4, 17) },
                    new Event { EventStartDate = new DateTime(2023, 4, 12), EventEndDate = new DateTime(2023, 4, 16) },
                    new Event { EventStartDate = new DateTime(2023, 5, 18), EventEndDate = new DateTime(2023, 5, 21) }
                };
            }
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
