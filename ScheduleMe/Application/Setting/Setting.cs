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

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked == true)
        {
            this.BackColor = Color.DarkGray;
        }
        else
        {
            this.BackColor = Color.White;
        }
    }
}
