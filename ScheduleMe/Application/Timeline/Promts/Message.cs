namespace ScheduleMe.Tab;

public partial class Message : Form
{
    public Message()
    {
        InitializeComponent();
    }

    public void Show(string text)
    {
        messageLbl.Text = text;
        this.ShowDialog();
    }
    public void

    private void okBtn_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }
}
