using ScheduleMe.Tab;

namespace ScheduleMe
{
    public partial class MainForm : Form
    {
        private Form activeForm = new Form();
        private static Calendar calendar = new Calendar();
        private static Timeline timeline = new Timeline();
        private static Timetable timetable = new Timetable();
        private static Note note = new Note();
        private static Weather weather = new Weather();
        private static Setting setting;
        private static About about;

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
            if (setting == null)
                setting = new Setting();
            setting.BringToFront();
            setting.Show();
        }

        private void btnAboutWindow_Click(object sender, EventArgs e)
        {
            if (about == null)
                about = new About();
            about.BringToFront();
            about.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}