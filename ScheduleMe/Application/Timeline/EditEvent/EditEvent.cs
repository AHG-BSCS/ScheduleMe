using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditEvent : Form
{
    public ObjectId CurrentID { get; set; }
    public DateTime MinDate { get; set; }
    public DateTime MaxDate { get; set; }

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
                CurrentID = firstToLoad.Id;
                MinDate = firstToLoad.TimelineStartDate;
                MaxDate = firstToLoad.TimelineEndDate;

                if (firstToLoad.Events != null)
                {
                    for (ushort i = 0; i < firstToLoad.Events.Count; i++)
                    {
                        AddEventRow newRow = new AddEventRow();
                        newRow.SetRowInfo(firstToLoad.Events[i]);
                        newRow.Id = firstToLoad.Id;
                        newRow.Index = i;
                        newRow.Dock = DockStyle.Bottom;
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
        if (CurrentID == Id)
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
            if (CurrentID == tab.Id)
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
            CurrentID = newtTab.Id;
            MinDate = newtTab.TimelineStartDate;
            MaxDate = newtTab.TimelineEndDate;

            // Add new tab and clear since there is no events yet as expected
            addNewTab(newtTab.TimelineName, newtTab.Id);
            eventInfoPanel.Controls.Clear();
        }
    }

    private void addRowBtn_Click(object sender, EventArgs e)
    {
        AddEventRow newRow = new AddEventRow();
        newRow.eventInfo = new Event();
        newRow.MinDate = MinDate;
        newRow.MaxDate = MaxDate;
        // newRow.Id = currentID; this can produce wrong deletion of data if Index was not accurate
        // newRow.Index is can't be set since it wasn't save to database yet
        // Or prevent the show of MenuStrip to this row
        newRow.SetRowInfo(newRow.eventInfo);
        newRow.Dock = DockStyle.Bottom;
        eventInfoPanel.Controls.Add(newRow);
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        if (CurrentID != null)
        {
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                Timeline timeline = timelines.FindById(CurrentID);

                // This will clear the current Events in class and replace with new list of Events
                // Kind of ineficient but I don't know how to fix this right now
                if (timeline.Events != null)
                    timeline.Events.Clear();

                foreach (AddEventRow newEvent in eventInfoPanel.Controls)
                {
                    timeline.Events.Add(newEvent.GetRowInfo());
                }
                timelines.Update(timeline);
                MessageBox.Show(timeline.TimelineName + " is Saved");

                // Reload the timeline events to assign a property to newly added rows
                eventInfoPanel.Controls.Clear();
                timeline = timelines.FindById(CurrentID);
                for (ushort i = 0; i < timeline.Events.Count; i++)
                {
                    AddEventRow newRow = new AddEventRow();
                    newRow.SetRowInfo(timeline.Events[i]);
                    newRow.Id = timeline.Id;
                    newRow.Index = i;
                    newRow.Dock = DockStyle.Bottom;
                    eventInfoPanel.Controls.Add(newRow);
                }
            }
        }
    }
}
