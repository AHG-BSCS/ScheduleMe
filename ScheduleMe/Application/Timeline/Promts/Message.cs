namespace ScheduleMe.Tab;

public partial class Message : Form
{
    public Message(string text)
    {
        InitializeComponent();
        lblMessage.Text = text;
        ShowDialog();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        Dispose();
    }
}
