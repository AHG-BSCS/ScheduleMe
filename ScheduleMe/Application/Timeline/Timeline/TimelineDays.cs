namespace ScheduleMe.Tab;

public partial class TimelineDays : UserControl
{
    public TimelineDays()
    {
        InitializeComponent();
    }

    public string Day
    {
        set => lblDay.Text = value;
    }

    public string Date
    {
        set => lblDate.Text = value;
    }
}
