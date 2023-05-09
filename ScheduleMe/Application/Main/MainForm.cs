using ScheduleMe.Tab;

namespace ScheduleMe
{
    public partial class MainForm : Form
    {
        private static Form? activeForm;
        private static Calendar? calendar;
        private static Timeline? timeline;
        private static Timetable? timetable;
        private static Note? note;
        private static Weather? weather;
        private static Setting? setting;
        private static About? about;

        public MainForm()
        {
            InitializeComponent();
            getFormInstance(ref activeForm);
            getFormInstance(ref calendar);
            openTabForm(calendar);
        }

        private void getFormInstance<T>(ref T instance) where T : Form, new()
        {
            if (instance == null)
                instance = new T();
        }

        private void openTabForm(Form newForm)
        {
            if (!newForm.Equals(activeForm))
            {
                activeForm.Hide();
                activeForm = newForm;
                newForm.Show();
                newForm.TopLevel = false;
                newForm.Dock = DockStyle.Fill;
                tabPanel.Controls.Add(newForm);
                newForm.BringToFront();
            }
        }

        private void btnCalendarTab_Click(object sender, EventArgs e)
        {
            getFormInstance(ref calendar);
            openTabForm(calendar);
        }

        private void btnTimelineTab_Click(object sender, EventArgs e)
        {
            getFormInstance(ref timeline);
            openTabForm(timeline);
        }

        private void btnTimetableTab_Click(object sender, EventArgs e)
        {
            getFormInstance(ref timetable);
        }

        private void btnNoteTab_Click(object sender, EventArgs e)
        {
            getFormInstance(ref note);
        }

        private void btnWeatherTab_Click(object sender, EventArgs e)
        {
            getFormInstance(ref weather);
        }

        private void btnSettingWindow_Click(object sender, EventArgs e)
        {
            getFormInstance(ref setting);
            setting.BringToFront();
            setting.Show();
        }

        private void btnAboutWindow_Click(object sender, EventArgs e)
        {
            getFormInstance(ref about);
            about.BringToFront();
            about.Show();
        }
    }
}