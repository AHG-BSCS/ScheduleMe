using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditEvent : Form
{
    private string timelineConnection = @"C:\Users\Jhondale\Downloads\Timelines.db";
    public ObjectId currentID;

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
            if (timelineTabs.Count() != 0)
            {
                TimelineTab firstToLoad = timelineTabs.First();

                if (firstToLoad.Events != null)
                {
                    AddEventRow newRow = new AddEventRow();
                    newRow.SetEventInfo(firstToLoad.Events.GetEnumerator().Current);
                    newRow.Dock = DockStyle.Top;
                    eventInfoPanel.Controls.Add(newRow);
                    /*
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
                    } */
                    currentID = firstToLoad.Id;
                }

                foreach (var tab in timelineTabs)
                {
                    addNewTab(tab.TimelineName, tab.Id);
                }
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
        newRow.Dock = DockStyle.Top;
        eventInfoPanel.Controls.Add(newRow);
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        if (currentID != null)
        {
            using (var timelineDB = new LiteDatabase(timelineConnection))
            {
                var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
                TimelineTab timeline = timelines.FindById(currentID);
                timeline.Events.Clear();

                foreach (AddEventRow newEvent in eventInfoPanel.Controls)  // Null Reference Exception
                {
                    timeline.Events.Add(newEvent.GetEventInfo());
                }
                timelines.Upsert(timeline);
            }
        }
    }
}
