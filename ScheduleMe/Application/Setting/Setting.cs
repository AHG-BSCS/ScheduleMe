namespace ScheduleMe.Tab;

public partial class Setting : Form
{
    public Setting()
    {
        InitializeComponent();
    }

    public event EventHandler<FormClosedEventArgs> FormClosedEvent;

    private void Setting_FormClosed(object sender, FormClosedEventArgs e)
    {
        FormClosedEvent?.Invoke(this, e);
    }
}
