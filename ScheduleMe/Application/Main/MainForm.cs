using ScheduleMe.Tab;

namespace ScheduleMe;

public partial class MainForm : Form
{
    private static Form activeForm;
    private static Calendar calendar;
    private static TimelinePanel timeline;
    private static Timetable timetable;
    private static Note note;
    private static Weather weather;
    private Button previousButton = new Button();

    internal Color accentColor = Color.FromArgb(15, 76, 129);

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        GetFormInstance(ref activeForm);
        GetFormInstance(ref calendar);
        HighlightTab(btnCalendarTab, calendar.Visible);
        ShowTab(calendar);
    }

    private void GetFormInstance<T>(ref T instance) where T : Form, new()
    {
        if (instance == null || instance.IsDisposed)
            instance = new T();
        instance.Show();
    }

    private void ShowTab(Form newForm)
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

    private void HighlightTab(Button button, bool visible)
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

    private void HighlightTabAndShow(Button button, Form form)
    {
        button.BackColor = Color.White;
        button.ForeColor = Color.Black;
        form.ShowDialog();
        button.BackColor = sideNavPanel.BackColor;
        button.ForeColor = Color.White;
    }

    private void btnCalendarTab_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref calendar);
        ShowTab(calendar);
        HighlightTab(btnCalendarTab, calendar.Visible);
    }

    private void btnTimelineTab_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref timeline);
        ShowTab(timeline);
        HighlightTab(btnTimelineTab, timeline.Visible);
    }

    private void btnTimetableTab_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref timetable);
        ShowTab(timetable);
        HighlightTab(btnTimetableTab, timetable.Visible);
    }

    private void btnNoteTab_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref note);
        ShowTab(note);
        HighlightTab(btnNoteTab, note.Visible);
    }

    private void btnWeatherTab_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref weather);
        ShowTab(weather);
        HighlightTab(btnWeatherTab, weather.Visible);
    }

    private void btnSettingWindow_Click(object sender, EventArgs e)
    {
        HighlightTabAndShow(btnSettingWindow, new Setting());
    }

    private void btnAboutWindow_Click(object sender, EventArgs e)
    {
        HighlightTabAndShow(btnAboutWindow, new About());
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Dispose();
    }
}