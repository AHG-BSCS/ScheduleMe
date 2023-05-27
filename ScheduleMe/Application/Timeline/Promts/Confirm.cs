namespace ScheduleMe.Tab;

public partial class Confirm : Form
{
    public bool Answer { get; set; }

    public Confirm()
    {
        InitializeComponent();
    }

    private void btnYes_Click(object sender, EventArgs e)
    {
        Answer = true;
        this.Close();
    }

    private void btnNo_Click(object sender, EventArgs e)
    {
        Answer = false;
        this.Close();
    }

}
