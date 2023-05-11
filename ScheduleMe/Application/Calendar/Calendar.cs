namespace ScheduleMe.Tab;

public partial class Calendar : Form
{
    public Calendar()
    {
        InitializeComponent();
    }

    private void Calendar_Load(object sender, EventArgs e)
    {
        ShowDate();
    }

    private void ShowDate()
    {
        DateTime currentDateTime = DateTime.Now;

        DateTime startOfTheMonth = new DateTime(currentDateTime.Year, currentDateTime.Month, 1);

        int days = DateTime.DaysInMonth(currentDateTime.Year, currentDateTime.Month);

    }
}
