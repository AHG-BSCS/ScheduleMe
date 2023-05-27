using LiteDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScheduleMe.Tab;

public partial class EditEvent : Form
{
    public ObjectId CurrentID { get; set; }
    public ObjectId PreviousID { get; set; }
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
        {
            foreach (ObjectId id in EventIds)
            {
                LoadTimelineById(id);
            }
        }
    }

    public void LoadTimelineById(ObjectId id)
    {
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<Timeline>("Timeline");
            var timelineTab = timelines.FindById(id);
            if (id == CurrentID || CurrentID == null)
            {
                CurrentID = timelineTab.Id;
                MinDate = timelineTab.TimelineStartDate;
                MaxDate = timelineTab.TimelineEndDate;
                SetTimelineDateRange();

                if (timelineTab.Events.Any())
                    PopulateRows(timelineTab);
            }
            if (PreviousID == null)
                AddNewTab(timelineTab.TimelineName, timelineTab.Id);
        }
    }

    public void SetTimelineDateRange()
    {
        timelineStartDatePicker.Value = MinDate;
        timelineEndDatePicker.Value = MaxDate;
    }

    private void PopulateRows(Timeline timelineTab)
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

    private void HighlightAndDispose(ObjectId deletedId)
    {
        EditEventTab disposeThis = new EditEventTab();
        eventInfoPanel.Controls.Clear();

        foreach (EditEventTab tab in timelineTabPanel.Controls.OfType<EditEventTab>())
        {
            if (PreviousID == tab.Id)
            {
                tab.timelineTabBtn.BackColor = Color.White;
                tab.timelineTabBtn.ForeColor = Color.Black;
            }
            else if (deletedId == tab.Id)
                disposeThis = tab;
        }
        disposeThis.Dispose();
    }

    public void AddNewTab(string timelineName, ObjectId Id)
    {
        EditEventTab newTimelineTab = new EditEventTab();
        newTimelineTab.AddOption_ItemClicked += addTabBtn_Click;
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

    private void addTabBtn_Click(object sender, EventArgs e)
    {
        AddTimeline addTimelineTab = new AddTimeline();
        addTimelineTab.ShowDialog();

        if (addTimelineTab.Id != null)
        {
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
            CurrentID = addTimelineTab.Id;
            EventIds.Add(CurrentID);
            eventInfoPanel.Controls.Clear();
            LoadTimelineById(CurrentID);
            // Remove the highlight of active Tab
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
                PopulateRows(timeline);
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
                EventIds.Remove(CurrentID);
                using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
                    timelineDB.GetCollection<Timeline>("Timeline").Delete(CurrentID);

                if (CurrentID == PreviousID || PreviousID == null)
                {
                    foreach (ObjectId id in EventIds)
                    {
                        CurrentID = null;
                        PreviousID = id;
                        HighlightAndDispose(deletedId);
                        LoadTimelineById(id);
                        PreviousID = null;
                        break;
                    }
                }
                else
                {
                    CurrentID = PreviousID;
                    PreviousID = null;
                }

                if (EventIds.Any() == false) // No tab available. The final tab is not disposed
                {
                    eventInfoPanel.Controls.Clear();
                    timelineTabPanel.Controls.Clear();
                    CurrentID = null;
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

}
