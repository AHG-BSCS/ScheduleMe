using LiteDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScheduleMe.Tab;

public partial class EditEvent : Form
{
    public ObjectId CurrentID { get; set; }
    public List<ObjectId> EventIds { get; set; }
    public DateTime MinDate { get; set; }
    public DateTime MaxDate { get; set; }

    public EditEvent()
    {
        InitializeComponent();
    }

    private void EditEvent_Load(object sender, EventArgs e)
    {
        if (CurrentID != null)
            LoadTimelineById();
    }

    private void LoadTimelineById() // Assuming that currentID do exists
    {
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<Timeline>("Timeline");
            foreach (ObjectId id in EventIds)
            {
                var timelineTab = timelines.FindById(id);
                if (id == CurrentID)
                {
                    CurrentID = timelineTab.Id;
                    MinDate = timelineTab.TimelineStartDate;
                    MaxDate = timelineTab.TimelineEndDate;
                    SetTimelineDateRange();

                    if (timelineTab.Events.Any())
                    {
                        for (ushort i = 0; i < timelineTab.Events.Count; i++)
                        {
                            AddEventRow newRow = new AddEventRow();
                            newRow.Id = timelineTab.Id;
                            newRow.Index = i;
                            newRow.MinDate = MinDate;
                            newRow.MaxDate = MaxDate;
                            newRow.Dock = DockStyle.Bottom;
                            newRow.SetRowInfo(timelineTab.Events[i]);
                            eventInfoPanel.Controls.Add(newRow);
                        }
                    }
                }
                addNewTab(timelineTab.TimelineName, timelineTab.Id);
            }
        }
    }

    internal void addNewTab(string timelineName, ObjectId Id)
    {
        EditEventTab newTimelineTab = new EditEventTab();
        newTimelineTab.AddOption_ItemClicked += timelineAddTab_Click;
        newTimelineTab.DeleteOption_ItemClicked += deleteBtn_Click;
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

        if (addTimelineTab.Id != null)
        {
            EventIds.Add(addTimelineTab.Id);
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
                Timeline newtTab = timelines.FindById(addTimelineTab.Id);
                CurrentID = newtTab.Id;
                MinDate = newtTab.TimelineStartDate;
                MaxDate = newtTab.TimelineEndDate;
                SetTimelineDateRange();

                // Add new tab and clear since there is no events yet as expected
                addNewTab(newtTab.TimelineName, newtTab.Id);
                eventInfoPanel.Controls.Clear();
            }
        }
        addTimelineTab.Dispose();
    }

    private void addRowBtn_Click(object sender, EventArgs e)
    {
        if (CurrentID != null)
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
        else
            new Message("No timeline");
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
                if (timeline.Events.Any())
                    timeline.Events.Clear();

                timeline.TimelineStartDate = timelineStartDatePicker.Value;
                timeline.TimelineEndDate = timelineEndDatePicker.Value;
                foreach (AddEventRow newEvent in eventInfoPanel.Controls)
                {
                    timeline.Events.Add(newEvent.GetRowInfo());
                }
                timelines.Update(timeline);
                new Message(timeline.TimelineName + " is Saved");

                // Reload the timeline events to assign a property to newly added rows
                eventInfoPanel.Controls.Clear();
                timeline = timelines.FindById(CurrentID);
                for (ushort i = 0; i < timeline.Events.Count; i++)
                {
                    AddEventRow newRow = new AddEventRow();
                    newRow.Id = timeline.Id;
                    newRow.Index = i;
                    newRow.MinDate = MinDate;
                    newRow.MaxDate = MaxDate;
                    newRow.Dock = DockStyle.Bottom;
                    newRow.SetRowInfo(timeline.Events[i]);
                    eventInfoPanel.Controls.Add(newRow);
                }
            }
        }
        else
            new Message("No timeline");
    }

    private void deleteBtn_Click(object sender, EventArgs e)
    {
        if (CurrentID != null)
        {
            ObjectId deletedId = CurrentID;
            DeleteTimeline promt = new DeleteTimeline();
            promt.ShowDialog();

            if (promt.Answer)
            {
                using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
                {
                    EventIds.Remove(CurrentID);
                    var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                    timelines.Delete(CurrentID); // Delete this Timeline

                    foreach (ObjectId id in EventIds)
                    {
                        Timeline firstToLoad = timelines.FindById(id);
                        CurrentID = firstToLoad.Id;
                        MinDate = firstToLoad.TimelineStartDate;
                        MaxDate = firstToLoad.TimelineEndDate;
                        SetTimelineDateRange();
                        ReverseHighlight(deletedId);

                        if (firstToLoad.Events.Any())
                        {
                            for (ushort i = 0; i < firstToLoad.Events.Count; i++)
                            {
                                AddEventRow newRow = new AddEventRow();
                                newRow.Id = firstToLoad.Id;
                                newRow.Index = i;
                                newRow.MinDate = firstToLoad.TimelineStartDate;
                                newRow.MaxDate = firstToLoad.TimelineEndDate;
                                newRow.Dock = DockStyle.Bottom;
                                newRow.SetRowInfo(firstToLoad.Events[i]);
                                eventInfoPanel.Controls.Add(newRow);
                            }
                        }
                        break;
                    }
                    if (EventIds.Any() == false) // No tab available. The final tab is not disposed
                    {
                        eventInfoPanel.Controls.Clear();
                        timelineTabPanel.Controls.Clear();
                        CurrentID = null;
                    }
                }
            }
            promt.Dispose();
        }
        else
            new Message("No timeline");
    }

    private void timelineStartDatePicker_ValueChanged(object sender, EventArgs e)
    {
        if (CurrentID != null)
        {
            if (timelineStartDatePicker.Value > MinDate)
            {
                timelineStartDatePicker.Value = MinDate;
                new Message("Invalid starting date");
            }
        }
        else
            new Message("No timeline");
    }

    private void timelineEndDatePicker_ValueChanged(object sender, EventArgs e)
    {
        if (CurrentID != null)
        {
            if (timelineEndDatePicker.Value < MaxDate)
            {
                timelineEndDatePicker.Value = MaxDate;
                new Message("Invalid ending date");
            }
        }
        else
            new Message("No timeline");
    }

    public void SetTimelineDateRange()
    {
        timelineStartDatePicker.Value = MinDate;
        timelineEndDatePicker.Value = MaxDate;
    }

    private void ReverseHighlight(ObjectId deletedId)
    {
        EditEventTab disposeThis = new EditEventTab();
        eventInfoPanel.Controls.Clear();

        foreach (EditEventTab tab in timelineTabPanel.Controls.OfType<EditEventTab>())
        {
            if (CurrentID == tab.Id)
            {
                tab.timelineTabBtn.BackColor = Color.White;
                tab.timelineTabBtn.ForeColor = Color.Black;
            }
            else if (deletedId == tab.Id)
                disposeThis = tab;
        }
        disposeThis.Dispose();
    }
}
