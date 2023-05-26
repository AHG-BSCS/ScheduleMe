using LiteDB;

namespace ScheduleMe.Tab;

public partial class EventButton : UserControl
{
    public ObjectId Id { get; set; }
    public ushort Index { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public EventButton()
    {
        InitializeComponent();
    }

    private void eventButtonMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == deleteOption)
        {
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var timeline = timelines.FindById(Id);
                timeline.Events.RemoveAt(Index);
                timelines.Update(timeline);
            }
            new Message(eventName.Text + " is Deleted");
            this.Dispose();
        }
    }

    public void SetEventProperty(string eventTitle, string description, DateTime startDate, DateTime endDate, int color)
    {
        eventName.Text = eventTitle;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        eventName.BackColor = Color.FromArgb(color);
    }
}
