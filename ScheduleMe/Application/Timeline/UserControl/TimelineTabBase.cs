using LiteDB;

namespace ScheduleMe.Tab;

public partial class TimelineTabBase : UserControl
{
    public ObjectId Id { get; set; }

    public string tabName
    {
        set { eventTab.Text = value; }
    }

    public TimelineTabBase()
    {
        InitializeComponent();
    }

    private void eventTab_Click(object sender, EventArgs e)
    {

    }
}
