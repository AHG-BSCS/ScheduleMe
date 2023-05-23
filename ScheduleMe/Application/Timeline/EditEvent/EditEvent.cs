using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditEvent : Form
{
    public ObjectId currentID;

    public EditEvent()
    {
        InitializeComponent();
    }

    private void EditEvent_Load(object sender, EventArgs e)
    {
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<Timeline>("Timeline");
            var timelineTabs = timelines.FindAll();
            if (timelineTabs.Count() != 0)
            {
                // Load the first TimelineTab.Event List only
                Timeline firstToLoad = timelineTabs.First();
                currentID = firstToLoad.Id;

                if (firstToLoad.Events != null)
                {
                    for (ushort i = 0; i < firstToLoad.Events.Count; i++)
                    {
                        AddEventRow newRow = new AddEventRow();
                        newRow.SetRowInfo(firstToLoad.Events[i]);
                        newRow.Id = firstToLoad.Id;
                        newRow.Index = i;
                        newRow.Dock = DockStyle.Top;
                        eventInfoPanel.Controls.Add(newRow);
                    }
                }
                // Load all the Timeline Tabs
                foreach (var tab in timelineTabs)
                {
                    addNewTab(tab.TimelineName, tab.Id);
                }
            }
        }
    }

    internal void addNewTab(string timelineName, ObjectId Id)
    {
        EditEventTab newTimelineTab = new EditEventTab();
        newTimelineTab.tabName = timelineName;
        newTimelineTab.Id = Id;
        newTimelineTab.editEventInstance = this;
        newTimelineTab.Dock = DockStyle.Left;
        timelineTabPanel.Controls.Add(newTimelineTab);
        newTimelineTab.BringToFront();

        // Highlight the current tab
        if (currentID == Id)
        {
            newTimelineTab.timelineTabBtn.BackColor = Color.White;
            newTimelineTab.timelineTabBtn.ForeColor = Color.Black;
        }
    }

    private void timelineAddTab_Click(object sender, EventArgs e)
    {
        AddTimeline addTimelineTab = new AddTimeline();
        addTimelineTab.ShowDialog();

        // Remove the highlight of active Tab
        foreach (EditEventTab tab in timelineTabPanel.Controls.OfType<EditEventTab>())
        {
            if (currentID == tab.Id)
            {
                tab.timelineTabBtn.BackColor = Color.FromArgb(15, 76, 129);
                tab.timelineTabBtn.ForeColor = Color.White;
                break;
            }
        }
        // Load new added timeline
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<Timeline>("Timeline");
            Timeline newtTab = new Timeline();
            newtTab = timelines.FindById(addTimelineTab.Id);
            currentID = newtTab.Id;

            // Add new tab and clear since there is no events yet as expected
            addNewTab(newtTab.TimelineName, newtTab.Id);
            eventInfoPanel.Controls.Clear();
        }
    }

    private void addRowBtn_Click(object sender, EventArgs e)
    {
        AddEventRow newRow = new AddEventRow();
        newRow.eventInfo = new Event();
        newRow.SetRowInfo(newRow.eventInfo);
        newRow.Dock = DockStyle.Top; // Need some fix to docked at the bottom instead
        eventInfoPanel.Controls.Add(newRow);
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        if (currentID != null)
        {
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                Timeline timeline = timelines.FindById(currentID);

                // This will clear the current Events in class and replace with new list of Events
                // Kind of ineficient but I don't know how to fix this right now
                if (timeline.Events != null)
                timeline.Events.Clear();

                foreach (AddEventRow newEvent in eventInfoPanel.Controls)
                {
                    timeline.Events.Add(newEvent.GetRowInfo());
                }
                timelines.Update(timeline);
                MessageBox.Show("Saved");
            }
        }
    }
}
