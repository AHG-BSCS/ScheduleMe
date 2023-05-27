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
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                TimelinePanel timelineMain = (TimelinePanel)this.Parent.Parent;
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var timeline = timelines.FindById(Id);
                timeline.Events.RemoveAt(Index);
                timelines.Update(timeline);

                // Reload the timeline
                timelineMain.pnlEvents.Controls.Clear();
                timelineMain.PopulateTimeline(timeline);
            }
            new Message(btnEvent.Text + " is Deleted");
            this.Dispose();
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
