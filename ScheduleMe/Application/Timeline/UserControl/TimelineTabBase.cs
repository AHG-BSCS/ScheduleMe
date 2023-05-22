using LiteDB;

namespace ScheduleMe.Tab;

public partial class TimelineTabBase : UserControl
{
    private string timelineConnection = @"C:\Users\Jhondale\Downloads\Timelines.db";
    public ObjectId Id { get; set; }
    public Timeline timelineInstance;

    public string tabName
    {
        set { eventTab.Text = value; }
    }

    public TimelineTabBase()
    {
        InitializeComponent();
    }

    private void eventTab_Click(object sender, EventArgs e)
    {
        timelineInstance.panelTimelineContainer.Controls.Clear();
        using (var timelineDB = new LiteDatabase(timelineConnection))
        {
            var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
            var timelineTabs = timelines.FindById(Id);

            if (timelineTabs.Events != null)
            {
                timelineTabs.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                timelineInstance.PopulateEvents(timelineTabs.Events, timelineTabs.TimelineStartDate);
            }
            timelineInstance.PopulateDates(timelineTabs.TimelineStartDate, timelineTabs.TimelineEndDate);
        }
    }

    private void timelineTabMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == editOption)
        {
            EditEvent editEvent = new EditEvent();
            editEvent.ShowDialog();
        }

        else if (e.ClickedItem == addOption)
        {
            AddTimelineTab addTab = new AddTimelineTab();
            addTab.ShowDialog();

            if (addTab.Id != null)
            {
                // Load the new added TimelineTab
                using (var timelineDB = new LiteDatabase(timelineConnection))
                {
                    var timelines = timelineDB.GetCollection<TimelineTab>("Timeline");
                    var newtTab = new TimelineTab();
                    newtTab = timelines.FindById(addTab.Id);

                    timelineInstance.addNewTab(newtTab.TimelineName, newtTab.Id);
                    timelineInstance.PopulateDates(newtTab.TimelineStartDate, newtTab.TimelineEndDate);
                }
            }
        }

        else if (e.ClickedItem == deleteOption)
        {

        }
    }
}
