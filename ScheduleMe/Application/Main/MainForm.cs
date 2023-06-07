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
    private Button previousBtn = new Button();

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Directory.Exists($"{DBConnection.GetBasePath()}\\ScheduleMe"))
            {
                Directory.CreateDirectory($"{DBConnection.GetBasePath()}\\ScheduleMe");
                MessageBox.Show("Welcome to ScheduleMe! Thank you for using our app!", "First time Running!");
            }
        }
        catch
        {
            MessageBox.Show("Can't create database folder: ");
        }

        sideNavPanel.Width = (int)(sideNavPanel.Width * MainDesigner.BaseWidthFactor());

        GetFormInstance(ref activeForm);
        btnCalendar_Click(sender, e);
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
        if (visible && !previousBtn.Equals(button))
        {
            button.BackColor = MainDesigner.HighlightColor;
            previousBtn.BackColor = MainDesigner.ThemeColor;
            previousBtn = button;
        }
    }

    private void HighlightTabAndShow(Button button, Form form)
    {
        button.BackColor = MainDesigner.HighlightColor;
        form.ShowDialog();
        button.BackColor = MainDesigner.ThemeColor;
    }

    private void btnCalendar_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref calendar);
        ShowTab(calendar);
        HighlightTab(btnCalendar, calendar.Visible);
    }

    private void btnTimeline_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref timeline);
        ShowTab(timeline);
        HighlightTab(btnTimeline, timeline.Visible);
    }

    private void btnTimetable_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref timetable);
        ShowTab(timetable);
        HighlightTab(btnTimetable, timetable.Visible);
    }

    private void btnNote_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref note);
        ShowTab(note);
        HighlightTab(btnNote, note.Visible);
    }

    private void btnWeather_Click(object sender, EventArgs e)
    {
        GetFormInstance(ref weather);
        ShowTab(weather);
        HighlightTab(btnWeather, weather.Visible);
    }

    private void btnSetting_Click(object sender, EventArgs e)
    {
        HighlightTabAndShow(btnSetting, new Setting());
    }

    private void btnAbout_Click(object sender, EventArgs e)
    {
        HighlightTabAndShow(btnAbout, new About());
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Dispose();
    }
}