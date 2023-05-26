namespace ScheduleMe.Tab;

public partial class Message : Form
{
    public Message(string text)
    {
        InitializeComponent();
        messageLbl.Text = text;
        this.ShowDialog();
    }

    private void okBtn_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }
}
