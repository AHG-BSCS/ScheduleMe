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
        int days, dayOfTheWeek;

        DateTime currentDateTime = DateTime.Now;

        DateTime startOfTheMonth = new DateTime(currentDateTime.Year, currentDateTime.Month, 1);

        days = DateTime.DaysInMonth(currentDateTime.Year, currentDateTime.Month);

        dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
    }
}
