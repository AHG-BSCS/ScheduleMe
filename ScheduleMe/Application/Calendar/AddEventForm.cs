using LiteDB;

namespace ScheduleMe.Tab
{
    public partial class AddEventForm : Form
    {
        public DateTime EventDate { get; set; }
        public AddEventForm()
        {
            InitializeComponent();
        }

        private void saveEventButton_Click(object sender, EventArgs e)
        {
            using var timelineConnection = new LiteDatabase(DBConnection.databaseConnection_calendar);
            var timelineDB = timelineConnection.GetCollection<CalendarEvent>("Calendar");

            CalendarEvent calendarEvent = new CalendarEvent();
            calendarEvent.EventName = eventNameTxtBx.Text;
            calendarEvent.EventDate = EventDate;
            timelineDB.Insert(calendarEvent);
            MessageBox.Show("Saved!");
            this.Dispose();
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            eventDateTxtBx.Text = Calendar.staticMonth + " / " + UserControlDays.staticDays.ToString() + " / " + Calendar.staticYear;
        }
    }
}
