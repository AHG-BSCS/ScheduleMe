using LiteDB;

namespace ScheduleMe.Tab;

public partial class AddTimeline : Form
{
    public ObjectId Id { get; set; }

    public AddTimeline()
    {
        InitializeComponent();
    }

    private void CreateTimeline()
    {
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<Timeline>("Timeline");

            var newTimeline = new Timeline
            {
                TimelineName = txtName.Text,
                TimelineStartDate = pckStartDate.Value,
                TimelineEndDate = pckEndDate.Value,
            };

            if (txtName.Text == "Test Dates") newTimeline.Events = TestDates();

            timelines.Insert(newTimeline);
            Id = newTimeline.Id;
        }
        Close();
    }

    private List<Event> TestDates() // For testing purpose only. To be remove later
    {
        return new List<Event>
        {
            new Event { EventStartDate = new DateTime(2023, 4, 6), EventEndDate = new DateTime(2023, 4, 9), EventColor = -15987921, EventTitle = "Event 1" },
            new Event { EventStartDate = new DateTime(2023, 4, 4), EventEndDate = new DateTime(2023, 4, 8), EventColor = -15987921, EventTitle = "Event 2" },
            new Event { EventStartDate = new DateTime(2023, 4, 5), EventEndDate = new DateTime(2023, 4, 7), EventColor = -15987921, EventTitle = "Event 3" },
            new Event { EventStartDate = new DateTime(2023, 4, 2), EventEndDate = new DateTime(2023, 4, 4), EventColor = -15987921, EventTitle = "Event 4" },
            new Event { EventStartDate = new DateTime(2023, 4, 3), EventEndDate = new DateTime(2023, 4, 6), EventColor = -15987921, EventTitle = "Event 5" },
            new Event { EventStartDate = new DateTime(2023, 4, 1), EventEndDate = new DateTime(2023, 4, 5), EventColor = -15987921, EventTitle = "Event 6" },
            new Event { EventStartDate = new DateTime(2023, 4, 1), EventEndDate = new DateTime(2023, 4, 2), EventColor = -15987921, EventTitle = "Event 7" },
            new Event { EventStartDate = new DateTime(2023, 4, 1), EventEndDate = new DateTime(2023, 4, 3), EventColor = -15987921, EventTitle = "Event 8" },
            new Event { EventStartDate = new DateTime(2023, 4, 6), EventEndDate = new DateTime(2023, 4, 16), EventColor = -15987921, EventTitle = "Event 9" },
            new Event { EventStartDate = new DateTime(2023, 4, 11), EventEndDate = new DateTime(2023, 4, 17), EventColor = -15987921, EventTitle = "Event 10" },
            new Event { EventStartDate = new DateTime(2023, 4, 12), EventEndDate = new DateTime(2023, 4, 16), EventColor = -15987921, EventTitle = "Event 11" },
            new Event { EventStartDate = new DateTime(2023, 5, 18), EventEndDate = new DateTime(2023, 5, 21), EventColor = -15987921, EventTitle = "Event 12" }
        };
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (txtName.Text != "")
        {
            if (pckStartDate.Value < pckEndDate.Value)
                CreateTimeline();
            else
                new Message("Invalid Dates");
        }
        else
            new Message("Invalid Name");
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Dispose();
    }
}
