using LiteDB;

namespace ScheduleMe.Tab;

public partial class TimelineTab : UserControl
{
    public ObjectId Id { get; set; }
    public TimelineMain timelineInstance;

    public string tabName
    {
        set { eventTab.Text = value; }
    }

    public TimelineTab()
    {
        InitializeComponent();
    }

    private void eventTab_Click(object sender, EventArgs e)
    {
        timelineInstance.panelTimelineContainer.Controls.Clear();
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<Timeline>("Timeline");
            var timelineTabs = timelines.FindById(Id);

            if (timelineTabs.Events != null)
            {
                timelineTabs.Events.Sort((e1, e2) => e1.EventEndDate.CompareTo(e2.EventStartDate));
                timelineInstance.PopulateEvents(timelineTabs.Events, timelineTabs.TimelineStartDate, timelineTabs.Id);
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
                using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
                {
                    var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                    var newtTab = new Timeline();
                    newtTab = timelines.FindById(addTab.Id);

                    timelineInstance.addNewTab(newtTab.TimelineName, newtTab.Id);
                    timelineInstance.PopulateDates(newtTab.TimelineStartDate, newtTab.TimelineEndDate);
                }
            }
        }

        else if (e.ClickedItem == deleteOption)
        {
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                timelineDB.GetCollection("Timeline").Delete(Id);
            }
            timelineInstance.panelTimelineContainer.Controls.Clear();
            this.Dispose();
            // Also switch to previous Tab if possible
        }
    }
}
