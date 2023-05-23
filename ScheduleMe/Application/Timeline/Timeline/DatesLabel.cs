namespace ScheduleMe.Tab;

public partial class DatesLabel : UserControl
{
    public DatesLabel()
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
