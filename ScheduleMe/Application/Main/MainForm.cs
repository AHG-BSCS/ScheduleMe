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
    private Panel previousPanelBtn = new Panel();

    internal Color accentColor = Color.FromArgb(15, 76, 129);

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        GetFormInstance(ref activeForm);
        GetFormInstance(ref calendar);
        HighlightTab(pnlCalendarBtn, calendar.Visible);
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

    private void HighlightTab(Panel panelBtn, bool visible)
    {
        if (visible && !previousPanelBtn.Equals(panelBtn))
        {
            panelBtn.BackColor = MainDesigner.HighlightColor;
            panelBtn.ForeColor = Color.Black;
            previousPanelBtn.BackColor = MainDesigner.ThemeColor;
            previousPanelBtn.ForeColor = Color.White;
            previousPanelBtn = panelBtn;
        }
    }

    private void HighlightTabAndShow(Panel panelBtn, Form form)
    {
        panelBtn.BackColor = MainDesigner.HighlightColor;
        panelBtn.ForeColor = Color.Black;
        form.ShowDialog();
        panelBtn.BackColor = MainDesigner.ThemeColor;
        panelBtn.ForeColor = Color.White;
    }

    private void pnlCalendarBtn_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref calendar);
        ShowTab(calendar);
        HighlightTab(pnlCalendarBtn, calendar.Visible);
    }

    private void pnlTimelineBtn_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref timeline);
        ShowTab(timeline);
        HighlightTab(pnlTimelineBtn, timeline.Visible);
    }

    private void pnlTimetableBtn_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref timetable);
        ShowTab(timetable);
        HighlightTab(pnlTimetableBtn, timetable.Visible);
    }

    private void pnlNoteBtn_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref note);
        ShowTab(note);
        HighlightTab(pnlNoteBtn, note.Visible);
    }

    private void pnlWeatherBtn_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref weather);
        ShowTab(weather);
        HighlightTab(pnlWeatherBtn, weather.Visible);
    }

    private void pnlSettingBtn_Click(object sender, EventArgs e)
    {
        HighlightTabAndShow(pnlSettingBtn, new Setting());
    }

    private void pnlAboutBtn_Click(object sender, EventArgs e)
    {
        HighlightTabAndShow(pnlAboutBtn, new About());
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Dispose();
    }

    private void lblCalendar_Click(object sender, EventArgs e)
    {
        pnlCalendarBtn_Click(sender, e);
    }

    private void picCalendar_Click(object sender, EventArgs e)
    {
        pnlCalendarBtn_Click(sender, e);
    }

    private void lblTimeline_Click(object sender, EventArgs e)
    {
        pnlTimelineBtn_Click(sender, e);
    }

    private void picTimeline_Click(object sender, EventArgs e)
    {
        pnlTimelineBtn_Click(sender, e);
    }

    private void lblTimetable_Click(object sender, EventArgs e)
    {
        pnlTimetableBtn_Click(sender, e);
    }

    private void picTimetable_Click(object sender, EventArgs e)
    {
        pnlTimetableBtn_Click(sender, e);
    }

    private void lblNote_Click(object sender, EventArgs e)
    {
        pnlNoteBtn_Click(sender, e);
    }

    private void picNote_Click(object sender, EventArgs e)
    {
        pnlNoteBtn_Click(sender, e);
    }

    private void lblWeather_Click(object sender, EventArgs e)
    {
        pnlWeatherBtn_Click(sender, e);
    }

    private void picWeather_Click(object sender, EventArgs e)
    {
        pnlWeatherBtn_Click(sender, e);
    }

    private void lblSetting_Click(object sender, EventArgs e)
    {
        pnlSettingBtn_Click(sender, e);
    }

    private void picSetting_Click(object sender, EventArgs e)
    {
        pnlSettingBtn_Click(sender, e);
    }

    private void lblAbout_Click(object sender, EventArgs e)
    {
        pnlAboutBtn_Click(sender, e);
    }

    private void picAbout_Click(object sender, EventArgs e)
    {
        pnlAboutBtn_Click(sender, e);
    }
}