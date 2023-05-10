namespace ScheduleMe.Tab;

public partial class Timeline : Form
{
    public Timeline()
    {
        InitializeComponent();
        AddDateCell(20);
    }

    private void AddDateCell(int count)
    {
        for (int i = 1; i <= count; i++)
        {
            flPanelDateTime.Controls.Add(new DateCell() { DayName = "Wed", Date = "10" });
        }
    }
}
