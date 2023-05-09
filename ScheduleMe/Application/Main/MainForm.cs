using ScheduleMe.Tab;

namespace ScheduleMe
{
    public partial class MainForm : Form
    {
        private Form activeForm = new Form();
        private Calendar calendar = new Calendar();
        private Timeline timeline = new Timeline();
        private Timetable timetable = new Timetable();
        private Note note = new Note();
        private Weather weather = new Weather();

        public MainForm()
        {
            InitializeComponent();
            openTabForm(calendar);
        }

        private void openTabForm(Form newForm)
        {
            if (!activeForm.Equals(newForm))
            {
                activeForm = newForm;
                activeForm.Hide();
                newForm.TopLevel = false;
                newForm.Dock = DockStyle.Fill;
                tabPanel.Controls.Add(newForm);
                newForm.BringToFront();
                newForm.Show();
            }
        }

        private void btnCalendarTab_Click(object sender, EventArgs e)
        {
            openTabForm(calendar);
        }

        private void btnTimelineTab_Click(object sender, EventArgs e)
        {
            openTabForm(timeline);
        }

        private void btnTimetableTab_Click(object sender, EventArgs e)
        {
            openTabForm(timetable);
        }

        private void btnNoteTab_Click(object sender, EventArgs e)
        {
            openTabForm(note);
        }

        private void btnWeatherTab_Click(object sender, EventArgs e)
        {
            openTabForm(weather);
        }

        private void btnSettingWindow_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        private void btnAboutWindow_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}