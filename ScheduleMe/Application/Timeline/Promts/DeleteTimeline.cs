namespace ScheduleMe.Tab;

public partial class DeleteTimeline : Form
{
    public bool Answer { get; set; }

    public DeleteTimeline()
    {
        InitializeComponent();
    }

    private void yesBtn_Click(object sender, EventArgs e)
    {
        Answer = true;
        this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Answer = false;
        this.Close();
    }
}
