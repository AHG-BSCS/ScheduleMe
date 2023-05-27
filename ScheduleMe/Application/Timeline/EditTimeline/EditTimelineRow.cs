using LiteDB;

namespace ScheduleMe.Tab;

public partial class EditTimelineRow : UserControl
{
    public EditTimelineRow()
    {
        InitializeComponent();
    }

    internal Event eventInfo;
    public ObjectId Id { get; set; }
    public ushort Index { get; set; }
    public DateTime MinDate { get; set; }
    public DateTime MaxDate { get; set; }

    public string Title
    {
        get { return txtTitle.Text; }
        set { txtTitle.Text = value; }
    }

    public string Description
    {
        get { return txtDescription.Text; }
        set { txtDescription.Text = value; }
    }

    public DateTime StartDate
    {
        get { return pckStartDate.Value; }
        set { pckStartDate.Value = value; }
    }

    public DateTime EndDate
    {
        get { return pckEndDate.Value; }
        set { pckEndDate.Value = value; }
    }

    public int Colour
    {
        get { return btnColorPicker.BackColor.ToArgb(); }
        set { btnColorPicker.BackColor = Color.FromArgb(value); }
    }

    private void btnColorPicker_Click(object sender, EventArgs e)
    {
        colEventColor.ShowDialog();
        btnColorPicker.BackColor = colEventColor.Color;
        colEventColor.Dispose();
    }

    internal Event GetRowInfo()
    {
        eventInfo.EventTitle = Title;
        eventInfo.EventDescription = Description;
        eventInfo.EventStartDate = StartDate;
        eventInfo.EventEndDate = EndDate;
        eventInfo.EventColor = Colour;
        return eventInfo;
    }

    internal void SetRowInfo(Event eventInfo)
    {
        this.eventInfo = eventInfo;
        Title = eventInfo.EventTitle;
        Description = eventInfo.EventDescription;
        StartDate = eventInfo.EventStartDate;
        EndDate = eventInfo.EventEndDate;
        Colour = eventInfo.EventColor;
    }

    private void mnuEventRow_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == mnuDelete && Id != null)
        {
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                EditTimeline editEvent = (EditTimeline)this.Parent.Parent;
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var timeline = timelines.FindById(Id);
                timeline.Events.RemoveAt(Index);
                timelines.Update(timeline);

                // Reload the timeline
                editEvent.pnlEventRows.Controls.Clear();
                editEvent.PopulateRows(timeline);
            }
            new Message(txtTitle.Text + " is Deleted");
            this.Dispose();
        }
        else
            new Message("Can't be found. Please save first.");
    }

    private void pckStartDate_ValueChanged(object sender, EventArgs e)
    {
        if (pckStartDate.Value < MinDate || pckStartDate.Value > MaxDate)
            pckStartDate.Value = MinDate;

        if (pckStartDate.Value > pckEndDate.Value)
            pckStartDate.Value = pckEndDate.Value;
    }

    private void pckEndDate_ValueChanged(object sender, EventArgs e)
    {
        if (pckEndDate.Value > MaxDate || pckEndDate.Value < MinDate)
            pckEndDate.Value = MaxDate;

        if (pckEndDate.Value < pckStartDate.Value)
            pckEndDate.Value = pckStartDate.Value;
    }

}
