namespace ScheduleMe.Tab;

public partial class DatesLabelBase : UserControl
{
    public DatesLabelBase()
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
