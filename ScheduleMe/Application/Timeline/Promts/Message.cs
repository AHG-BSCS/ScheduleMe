namespace ScheduleMe.Tab;

public partial class Message : Form
{
    public Message(string text)
    {
        InitializeComponent();
        lblMessage.Text = text;
        this.ShowDialog();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }

}
