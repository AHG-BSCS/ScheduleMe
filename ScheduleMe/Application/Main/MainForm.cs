using ScheduleMe.Tab;

namespace ScheduleMe
{
    public partial class MainForm : Form
    {
        private static Form activeForm;
        private static Calendar calendar;
        private static Timeline timeline;
        private static Timetable timetable;
        private static Note note;
        private static Weather weather;
        private static Setting setting;
        private static About about;

        public MainForm()
        {
            InitializeComponent();
            showFormInstance(ref activeForm);
            showFormInstance(ref calendar);
            openInTabPanel(calendar);
        }

        private void showFormInstance<T>(ref T instance) where T : Form, new()
        {
            if (instance == null)
                instance = new T();
            instance.BringToFront();
            instance.Show();
        }

        private void openInTabPanel(Form newForm)
        {
            if (!newForm.Equals(activeForm))
            {
                activeForm.Hide();
                activeForm = newForm;
                newForm.TopLevel = false;
                newForm.Dock = DockStyle.Fill;
                tabPanel.Controls.Add(newForm);
            }
        }

        private void btnCalendarTab_Click(object sender, EventArgs e)
        {
            showFormInstance(ref calendar);
            openInTabPanel(calendar);
        }

        private void btnTimelineTab_Click(object sender, EventArgs e)
        {
            showFormInstance(ref timeline);
            openInTabPanel(timeline);
        }

        private void btnTimetableTab_Click(object sender, EventArgs e)
        {
            showFormInstance(ref timetable);
            openInTabPanel(timetable);
        }

        private void btnNoteTab_Click(object sender, EventArgs e)
        {
            showFormInstance(ref note);
            openInTabPanel(note);
        }

        private void btnWeatherTab_Click(object sender, EventArgs e)
        {
            showFormInstance(ref weather);
            openInTabPanel(weather);
        }

        private void btnSettingWindow_Click(object sender, EventArgs e)
        {
            showFormInstance(ref setting);
        }

        private void btnAboutWindow_Click(object sender, EventArgs e)
        {
            showFormInstance(ref about);
        }
    }
}