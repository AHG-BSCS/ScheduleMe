namespace ScheduleMe.Tab;

public partial class Timeline : Form
{
    public Timeline()
    {
        InitializeComponent();
        AddDateCell(new DateTime(2023, 1, 1, 21, 2, 12), new DateTime(2023, 2, 14, 21, 2, 12));
    }

    private void AddDateCell(DateTime startDate, DateTime endDate)
    {
        for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
        {
            flPanelDateTime.Controls.Add(new DateCell()
            { DayName = i.DayOfWeek.ToString(), Date = i.Day.ToString() });
        }
    }
}
