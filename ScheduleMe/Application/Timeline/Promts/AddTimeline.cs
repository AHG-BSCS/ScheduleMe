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
        using (var timelineConnection = new LiteDatabase(DBConnection.databaseConnection))
        {
            var timelineDB = timelineConnection.GetCollection<Timeline>("Timeline");

            var newTimeline = new Timeline
            {
                TimelineName = txtName.Text,
                TimelineStartDate = pckStartDate.Value,
                TimelineEndDate = pckEndDate.Value,
            };

            if (txtName.Text == "Test Dates") newTimeline.Events = TestDates();

            else if (txtName.Text == "Academic Year 22-23") newTimeline.Events = TestDateAcademicCalendar();

            timelineDB.Insert(newTimeline);
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

    private List<Event> TestDateAcademicCalendar() // For testing purpose only. To be remove later
    {
        return new List<Event>
        {
            new Event { EventStartDate = new DateTime(2022, 8, 1), EventEndDate = new DateTime(2022, 8, 19), EventColor = -15987921, EventTitle = "First Semester Pre-Enrollment and Enrollment Period" },
            new Event { EventStartDate = new DateTime(2022, 8, 22), EventEndDate = new DateTime(2023, 1, 6), EventColor = -15987921, EventTitle = "First Semester Period" },
            new Event { EventStartDate = new DateTime(2022, 10, 25), EventEndDate = new DateTime(2022, 10, 28), EventColor = -15987921, EventTitle = "First Semester Mid-Term Examination" },
            new Event { EventStartDate = new DateTime(2022, 12, 19), EventEndDate = new DateTime(2022, 12, 30), EventColor = -15987921, EventTitle = "Christmas Vacation" },
            new Event { EventStartDate = new DateTime(2023, 1, 5), EventEndDate = new DateTime(2023, 1, 7), EventColor = -15987921, EventTitle = "First Semester Final Examination" },
            new Event { EventStartDate = new DateTime(2023, 1, 16), EventEndDate = new DateTime(2023, 1, 27), EventColor = -15987921, EventTitle = "Second Semester Pre-Enrollment and Enrollment Period" },
            new Event { EventStartDate = new DateTime(2023, 1, 30), EventEndDate = new DateTime(2023, 6, 2), EventColor = -15987921, EventTitle = "Second Semester Period" },
            new Event { EventStartDate = new DateTime(2023, 4, 6), EventEndDate = new DateTime(2023, 4, 8), EventColor = -15987921, EventTitle = "Second Semester Mid-Term Examination" },
            new Event { EventStartDate = new DateTime(2023, 5, 5), EventEndDate = new DateTime(2023, 5, 27), EventColor = -15987921, EventTitle = "Final Examinaation for Graduating Students" },
            new Event { EventStartDate = new DateTime(2023, 5, 1), EventEndDate = new DateTime(2023, 5, 3), EventColor = -15987921, EventTitle = "Final Examinaation for Non-Graduating Students" },
            new Event { EventStartDate = new DateTime(2023, 6, 27), EventEndDate = new DateTime(2023, 6, 30), EventColor = -15987921, EventTitle = "Graduation Period" },
            new Event { EventStartDate = new DateTime(2023, 6, 12), EventEndDate = new DateTime(2023, 6, 16), EventColor = -15987921, EventTitle = "Enrollment of Inter-Semester Classes" },
            new Event { EventStartDate = new DateTime(2023, 6, 20), EventEndDate = new DateTime(2023, 7, 28), EventColor = -15987921, EventTitle = "Inter Semester Period" }
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
