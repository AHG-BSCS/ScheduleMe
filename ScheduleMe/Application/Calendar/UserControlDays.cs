namespace ScheduleMe.Tab
{
    public partial class UserControlDays : UserControl
    {
        public DateTime OwnDate { get; set; }
        public static string staticDays;
        public UserControlDays()
        {
            InitializeComponent();
        }

        public void Days(int numDay)
        {
            numDayLbl.Text = numDay.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            staticDays = numDayLbl.Text;
            AddEventForm eventForm = new AddEventForm();
            eventForm.EventDate = OwnDate;
            eventForm.ShowDialog();
        }
    }
}
