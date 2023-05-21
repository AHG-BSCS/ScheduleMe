namespace ScheduleMe.Tab;

public partial class EditEvent : Form
{
    public EditEvent()
    {
        InitializeComponent();
    }

    private void timelineAddTab_Click(object sender, EventArgs e)
    {

    }

    private void addRowBtn_Click(object sender, EventArgs e)
    {
        AddEventRow newRow = new AddEventRow();
        newRow.Dock = DockStyle.Top;
        eventInfoPanel.Controls.Add(newRow);
    }
}
