namespace ScheduleMe.Tab;

public partial class Setting : Form
{
    public Setting()
    {
        InitializeComponent();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked == true)
            this.BackColor = Color.DarkGray;
        else
            this.BackColor = Color.White;
    }

    private void Setting_FormClosing(object sender, FormClosingEventArgs e)
    {
        Dispose();
    }
}
