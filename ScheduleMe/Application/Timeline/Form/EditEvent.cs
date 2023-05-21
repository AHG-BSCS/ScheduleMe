using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditEvent : Form
{
    private string timelineConnection = @"C:\Users\Jhondale\Downloads\Timelines.db";
    public ObjectId currentID;
    public List<AddEventRow> newEventRows = new List<AddEventRow>();

    public EditEvent()
    {
        InitializeComponent();
    }

    private void EditEvent_Load(object sender, EventArgs e)
    {
        using (var timelineDB = new LiteDatabase(timelineConnection))
        {
            var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
            var timelineTabs = timelines.FindAll();
            TimelineTab firstToLoad = timelineTabs.First();

            if (firstToLoad.Events != null)
            {
                foreach (Event firstEvents in firstToLoad.Events)
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
                    eventInfoPanel.Controls.Add(newRow);
                }
                currentID = firstToLoad.Id;
            }

            foreach (var tab in timelineTabs)
            {
                addNewTab(tab.TimelineName, tab.Id);
            }
        }
    }

    private void addNewTab(string timelineName, ObjectId Id)
    {
        EditEventTabBase newTimelineTab = new EditEventTabBase();
        newTimelineTab.tabName = timelineName;
        newTimelineTab.Id = Id;
        newTimelineTab.editEventInstance = this;
        newTimelineTab.Location = new Point(timelineAddTab.Left, timelineAddTab.Top);
        timelineTabPanel.Controls.Add(newTimelineTab);
        newTimelineTab.BringToFront();

        timelineAddTab.Location = new Point(newTimelineTab.Right, newTimelineTab.Top);
        newTimelineTab.Dock = DockStyle.Left;
        currentID = newTimelineTab.Id;
        newEventRows.Clear();
    }

    private void timelineAddTab_Click(object sender, EventArgs e)
    {
        AddTimelineTab addTimelineTab = new AddTimelineTab();
        addTimelineTab.ShowDialog();

        // Load the new added timeline
        using (var timelineDB = new LiteDatabase(timelineConnection))
        {
            var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
            var newtTab = new TimelineTab();
            newtTab = timelines.FindById(addTimelineTab.Id);

            addNewTab(newtTab.TimelineName, newtTab.Id);
            eventInfoPanel.Controls.Clear();
        }
    }

    private void addRowBtn_Click(object sender, EventArgs e)
    {
        AddEventRow newRow = new AddEventRow();
        newEventRows.Add(newRow);
        newRow.Dock = DockStyle.Top;
        eventInfoPanel.Controls.Add(newRow);
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        using (var timelineDB = new LiteDatabase(timelineConnection))
        {
            var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
            TimelineTab timeline = timelines.FindById(currentID);

            foreach (AddEventRow newEvent in newEventRows)
            {
                timeline.Events.Add
                (
                    new Event
                    {
                        EventTitle = newEvent.Title,
                        EventDescription = newEvent.Description,
                        EventStartDate = newEvent.StartDate,
                        EventEndDate = newEvent.EndDate,
                        EventColor = newEvent.Color
                    }
                );
            }
            timelines.Insert(timeline);
            newEventRows.Clear();
        }
    }
}
