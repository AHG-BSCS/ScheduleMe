namespace ScheduleMe.Tab;

public partial class TimelineTab : UserControl
{
    public string tabName
    {
        set { eventTab.Text = value; }
    }

    public TimelineTab()
    {
        InitializeComponent();
    }
}
