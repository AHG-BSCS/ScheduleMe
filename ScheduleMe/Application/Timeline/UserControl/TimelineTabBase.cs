namespace ScheduleMe.Tab;

public partial class TimelineTabBase : UserControl
{
    public string tabName
    {
        set { eventTab.Text = value; }
    }

    public TimelineTabBase()
    {
        InitializeComponent();
    }
}
