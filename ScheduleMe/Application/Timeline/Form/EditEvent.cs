using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditEvent : Form
{
    private string timelineConnection = @"C:\Users\Jhondale\Downloads\Timelines.db";

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
                }
            }

            foreach (var tab in timelineTabs)
            {
                addNewTab(tab.TimelineName, tab.Id);
            }
        }
    }

    private void timelineAddTab_Click(object sender, EventArgs e)
    {

    }

    private void addRowBtn_Click(object sender, EventArgs e)
    {
        AddEventRow newRow = new AddEventRow();
        newRow.Dock = DockStyle.Top;
        eventInfoPanel.Controls.Add(newRow);
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
    }
}
