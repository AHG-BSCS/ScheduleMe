using LiteDB;

namespace ScheduleMe.Tab;

public partial class TimelineEvent : UserControl
{
    public ObjectId Id { get; set; }
    public ushort Index { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public TimelineEvent()
    {
        InitializeComponent();
    }

    private void mnuEvent_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == mnuDelete)
        {
            using (var timelineConnection = new LiteDatabase(DBConnection.databaseConnection))
            {
                TimelinePanel timelinePanel = (TimelinePanel)Parent.Parent;
                var timelineDB = timelineConnection.GetCollection<Timeline>("Timeline");
                var timeline = timelineDB.FindById(Id);
                timeline.Events.RemoveAt(Index);
                timelineDB.Update(timeline);

                // Reload the timeline
                timelinePanel.pnlEvents.Controls.Clear();
                timelinePanel.PopulateTimeline(timeline);
            }
            new Message(btnEvent.Text + " is Deleted");
            Dispose();
        }
    }

    public void SetEventProperty(string eventTitle, string description, DateTime startDate, DateTime endDate, int color)
    {
        btnEvent.Text = eventTitle;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        btnEvent.BackColor = Color.FromArgb(color);
    }
}
