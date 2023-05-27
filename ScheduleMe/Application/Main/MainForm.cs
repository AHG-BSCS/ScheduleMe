using LiteDB;
using ScheduleMe.Tab;

namespace ScheduleMe
{
    public partial class MainForm : Form
    {
        private static Form activeForm;
        private static Calendar calendar;
        private static TimelineMain timeline;
        private static Timetable timetable;
        private static Note note;
        private static Weather weather;
        private Button previousButton = new Button();

        public Color accentColor = Color.FromArgb(15, 76, 129);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            showFormInstance(ref activeForm);
            showFormInstance(ref calendar);
            highlightButton(btnCalendarTab, calendar.Visible);
            openInTabPanel(calendar);
        }

        private void showFormInstance<T>(ref T instance) where T : Form, new()
        {
            if (instance == null || instance.IsDisposed)
                instance = new T();
            instance.Show();
        }

        private void openInTabPanel(Form newForm)
        {
            if (!newForm.Equals(activeForm))
            {
                activeForm.Hide();
                tabPanel.Controls.Clear();
                activeForm = newForm;
                newForm.TopLevel = false;
                newForm.Dock = DockStyle.Top;
                tabPanel.Controls.Add(newForm);
                tabPanel.Focus();
            }
        }

        private void highlightButton(Button button, bool visible)
        {
            if (visible && !previousButton.Equals(button))
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
                previousButton.BackColor = sideNavPanel.BackColor;
                previousButton.ForeColor = Color.White;
                previousButton = button;
            }
        }

        private void HighlightAndShow(Button button, Form form)
        {
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
            form.ShowDialog();
            button.BackColor = sideNavPanel.BackColor;
            button.ForeColor = Color.White;
        }

        private void btnCalendarTab_Click(object sender, EventArgs e)
        {
            showFormInstance(ref calendar);
            openInTabPanel(calendar);
            highlightButton(btnCalendarTab, calendar.Visible);
        }

        private void btnTimelineTab_Click(object sender, EventArgs e)
        {
            showFormInstance(ref timeline);
            openInTabPanel(timeline);
            highlightButton(btnTimelineTab, timeline.Visible);
        }

        private void btnTimetableTab_Click(object sender, EventArgs e)
        {
            showFormInstance(ref timetable);
            openInTabPanel(timetable);
            highlightButton(btnTimetableTab, timetable.Visible);
        }

        private void btnNoteTab_Click(object sender, EventArgs e)
        {
            showFormInstance(ref note);
            openInTabPanel(note);
            highlightButton(btnNoteTab, note.Visible);
        }

        private void btnWeatherTab_Click(object sender, EventArgs e)
        {
            showFormInstance(ref weather);
            openInTabPanel(weather);
            highlightButton(btnWeatherTab, weather.Visible);
        }

        private void btnSettingWindow_Click(object sender, EventArgs e)
        {
            HighlightAndShow(btnSettingWindow, new Setting());
        }

        private void btnAboutWindow_Click(object sender, EventArgs e)
        {
            HighlightAndShow(btnAboutWindow, new About());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}