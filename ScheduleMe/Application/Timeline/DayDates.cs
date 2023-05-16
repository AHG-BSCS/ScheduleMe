namespace ScheduleMe.Tab;

public partial class DayDates : UserControl
{
    public DayDates()
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
