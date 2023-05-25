using LiteDB;

namespace ScheduleMe.Tab;

public partial class AddEventRow : UserControl
{
    public AddEventRow()
    {
        InitializeComponent();
    }

    internal Event eventInfo; // Fix the access modifier
    public ObjectId Id { get; set; }
    public ushort Index { get; set; }
    public DateTime MinDate { get; set; }
    public DateTime MaxDate { get; set; }

    public string Title
    {
        get { return titleTBox.Text; }
        set { titleTBox.Text = value; }
    }

    public string Description
    {
        get { return descriptionTBox.Text; }
        set { descriptionTBox.Text = value; }
    }

    public DateTime StartDate
    {
        get { return startDatePicker.Value; }
        set { startDatePicker.Value = value; }
    }

    public DateTime EndDate
    {
        get { return endDatePicker.Value; }
        set { endDatePicker.Value = value; }
    }

    public int Colour
    {
        get { return colorPickerBtn.BackColor.ToArgb(); }
        set { colorPickerBtn.BackColor = Color.FromArgb(value); }
    }

    private void colorPickerBtn_Click(object sender, EventArgs e)
    {
        colorDialog.ShowDialog();
        colorPickerBtn.BackColor = colorDialog.Color;
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

    private void rowMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == deleteOption && Id != null)
        {
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var timeline = timelines.FindById(Id);
                timeline.Events.RemoveAt(Index);
                timelines.Update(timeline);
            }
            new Message().Show(titleTBox.Text + " is Deleted");
            this.Dispose();
        }
        else
            new Message().Show("Can't be found. Please save first.");
    }

    private void startDatePicker_ValueChanged(object sender, EventArgs e)
    {
        if (startDatePicker.Value < MinDate || startDatePicker.Value > MaxDate)
            startDatePicker.Value = MinDate;

        if (startDatePicker.Value > endDatePicker.Value)
            startDatePicker.Value = endDatePicker.Value;
    }

    private void endDatePicker_ValueChanged(object sender, EventArgs e)
    {
        if (endDatePicker.Value > MaxDate || endDatePicker.Value < MinDate)
            endDatePicker.Value = MaxDate;

        if (endDatePicker.Value < startDatePicker.Value)
            endDatePicker.Value = startDatePicker.Value;
    }
}
