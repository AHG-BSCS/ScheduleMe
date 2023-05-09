using ScheduleMe.Tab;

namespace ScheduleMe
{
    public partial class MainForm : Form
    {
        private Calendar calendar = new Calendar();
        private Timeline timeline = new Timeline();
        private Timetable timetable = new Timetable();
        private Note note = new Note();
        private Weather weather = new Weather();

        public MainForm()
        {
            InitializeComponent();
            openTabForm(calendar, calendar);
        }


        private void openTabForm(Form activeForm, Form childForm)
        {
            activeForm.Hide();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            tabPanel.Controls.Add(childForm);
            childForm.Show();
        }


        private void btnCalendarTab_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimelineTab_Click(object sender, EventArgs e)
        {

        }

        private void btnTimetableTab_Click(object sender, EventArgs e)
        {

        }

        private void btnNoteTab_Click(object sender, EventArgs e)
        {

        }

        private void btnWeatherTab_Click(object sender, EventArgs e)
        {

        }

        private void btnSettingWindow_Click(object sender, EventArgs e)
        {

        }

        private void btnAboutWindow_Click(object sender, EventArgs e)
        {

        }
    }
}