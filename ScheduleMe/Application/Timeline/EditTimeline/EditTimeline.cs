using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditTimeline : Form
{
    public ObjectId CurrentID { get; set; }
    public ObjectId PreviousID { get; set; }
    public List<ObjectId> EventIds { get; set; }
    public DateTime MinDate { get; set; }
    public DateTime MaxDate { get; set; }

    public EditTimeline()
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

    internal void LoadTimelineById(ObjectId id)
    {
        using var timelineConnection = new LiteDatabase(DBConnection.databaseConnection_timeline);
        var timelineDB = timelineConnection.GetCollection<Timeline>("Timeline");
        var timeline = timelineDB.FindById(id);

        if (id == CurrentID || CurrentID == null)
        {
            CurrentID = timeline.Id;
            MinDate = timeline.TimelineStartDate;
            MaxDate = timeline.TimelineEndDate;
            SetTimelineDateRange(timeline.TimelineName);

            if (timeline.Events.Any())
                PopulateRows(timeline);
        }
        if (PreviousID == null)
            AddNewTab(timeline.TimelineName, timeline.Id);
    }

    internal void SetTimelineDateRange(string timelineName)
    {
        txtTimelineName.Text = timelineName;
        pckStartDate.Value = MinDate;
        pckEndDate.Value = MaxDate;
    }

    internal void PopulateRows(Timeline timelineTab)
    {
        for (ushort i = 0; i < timelineTab.Events.Count; i++)
        {
            EditTimelineRow newRow = new EditTimelineRow();
            newRow.Id = timelineTab.Id;
            newRow.Index = i;
            newRow.MinDate = MinDate;
            newRow.MaxDate = MaxDate;
            newRow.Dock = DockStyle.Bottom;
            newRow.SetRowInfo(timelineTab.Events[i]);
            pnlEventRows.Controls.Add(newRow);
        }
    }

    private void HighlightAndDispose(ObjectId deletedId)
    {
        EditTimelineTab disposeThis = new EditTimelineTab();
        pnlEventRows.Controls.Clear();

        foreach (EditTimelineTab tab in pnlTimelineTabs.Controls)
        {
            if (PreviousID == tab.Id)
            {
                tab.btnEditTimelineTab.BackColor = MainDesigner.HighlightColor;
            }
            else if (deletedId == tab.Id)
                disposeThis = tab;
        }
        disposeThis.Dispose();
    }

    public void AddNewTab(string timelineName, ObjectId Id)
    {
        EditTimelineTab newTimelineTab = new EditTimelineTab();
        newTimelineTab.AddOption_ItemClicked += btnAddTab_Click;
        newTimelineTab.DeleteOption_ItemClicked += btnDelete_Click;
        newTimelineTab.TabName = timelineName;
        newTimelineTab.Id = Id;
        newTimelineTab.EditTimeline = this;
        newTimelineTab.Dock = DockStyle.Left;
        pnlTimelineTabs.Controls.Add(newTimelineTab);
        newTimelineTab.BringToFront();

        if (CurrentID == Id) // Highlight the current tab
        {
            newTimelineTab.btnEditTimelineTab.BackColor = MainDesigner.HighlightColor;
        }
    }

    private void btnAddTab_Click(object sender, EventArgs e)
    {
        AddTimeline addTimeline = new AddTimeline();
        addTimeline.ShowDialog();

        if (addTimeline.Id != null)
        {
            foreach (EditTimelineTab tab in pnlTimelineTabs.Controls)
            {
                if (CurrentID == tab.Id)
                {
                    tab.btnEditTimelineTab.BackColor = MainDesigner.ThemeColor;
                    break;
                }
            }
            // Load new added timeline
            CurrentID = addTimeline.Id;
            EventIds.Add(CurrentID);
            pnlEventRows.Controls.Clear();
            LoadTimelineById(CurrentID);
        }
        addTimeline.Dispose();
    }

    private void btnAddRow_Click(object sender, EventArgs e)
    {
        if (CurrentID != null)
        {
            EditTimelineRow newRow = new EditTimelineRow();
            newRow.eventInfo = new Event() { EventStartDate = MinDate, EventEndDate = MinDate.AddDays(1) };
            newRow.MinDate = MinDate;
            newRow.MaxDate = MaxDate;

            // newRow.Id = currentID; this can produce wrong deletion of data if Index was not accurate
            // newRow.Index is can't be set since it wasn't save to database yet
            // Or prevent the show of MenuStrip to this row
            newRow.SetRowInfo(newRow.eventInfo);
            newRow.Dock = DockStyle.Bottom;
            pnlEventRows.Controls.Add(newRow);
        }
        else
            new Message("No timeline");
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (CurrentID != null)
        {
            using var timelineConnection = new LiteDatabase(DBConnection.databaseConnection_timeline);
            var timelineDB = timelineConnection.GetCollection<Timeline>("Timeline");
            Timeline timeline = timelineDB.FindById(CurrentID);

            // This will clear the current Events in class and replace with new list of Events
            // Kind of ineficient but I don't know how to fix this right now
            if (timeline.Events.Any())
                timeline.Events.Clear();

            timeline.TimelineName = txtTimelineName.Text;
            timeline.TimelineStartDate = pckStartDate.Value;
            timeline.TimelineEndDate = pckEndDate.Value;

            foreach (EditTimelineRow row in pnlEventRows.Controls)
            {
                timeline.Events.Add(row.GetRowInfo());
            }

            timelineDB.Update(timeline);
            new Message(timeline.TimelineName + " is Saved");
            pnlEventRows.Controls.Clear();
            timeline = timelineDB.FindById(CurrentID);
            PopulateRows(timeline);
        }
        else
            new Message("No timeline");
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (CurrentID != null)
        {
            ObjectId deletedId = CurrentID;
            Confirm confirm = new Confirm();
            confirm.ShowDialog();

            if (confirm.Answer)
            {
                EventIds.Remove(CurrentID);
                using (var timelineConnection = new LiteDatabase(DBConnection.databaseConnection_timeline))
                    timelineConnection.GetCollection<Timeline>("Timeline").Delete(CurrentID);

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
                    pnlEventRows.Controls.Clear();
                    pnlTimelineTabs.Controls.Clear();
                    CurrentID = null;
                }
            }
            confirm.Dispose();
        }
        else
            new Message("No timeline");
    }

    private void pckStartDate_ValueChanged(object sender, EventArgs e)
    {
        if (CurrentID != null)
        {
            if (pckStartDate.Value > MinDate)
            {
                pckStartDate.Value = MinDate;
                new Message("Invalid starting date");
            }
        }
        else
            new Message("No timeline");
    }

    private void pckEndDate_ValueChanged(object sender, EventArgs e)
    {
        if (CurrentID != null)
        {
            if (pckEndDate.Value < MaxDate)
            {
                pckEndDate.Value = MaxDate;
                new Message("Invalid ending date");
            }
        }
        else
            new Message("No timeline");
    }

    private void txtTimelineName_Validated(object sender, EventArgs e)
    {
        foreach (EditTimelineTab tab in pnlTimelineTabs.Controls)
        {
            if (tab.Id == CurrentID)
            {
                using var timelineConnection = new LiteDatabase(DBConnection.databaseConnection_timeline);
                var timelineDB = timelineConnection.GetCollection<Timeline>("Timeline");
                Timeline timeline = timelineDB.FindById(CurrentID);
                tab.btnEditTimelineTab.Text = txtTimelineName.Text;
                timeline.TimelineName = txtTimelineName.Text;
                timelineDB.Update(timeline);
            }
        }
    }
}
