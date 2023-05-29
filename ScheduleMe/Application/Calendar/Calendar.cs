using ScheduleMe.Tab;

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
        int days, dayOfTheWeek, i;

        DateTime currentDateTime = DateTime.Now;

        DateTime startOfTheMonth = new DateTime(currentDateTime.Year, currentDateTime.Month, 1);

        days = DateTime.DaysInMonth(currentDateTime.Year, currentDateTime.Month);

        dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")+1);

        for (i = 1; i < dayOfTheWeek; i++)
        {
            UserControlBlank ucBlank = new UserControlBlank();
            calendarContainer.Controls.Add(ucBlank);
        }

        for (i = 1; i<= days; i++)
        {
            UserControlDays ucdays = new UserControlDays();
            ucdays.Days(i);
            calendarContainer.Controls.Add(ucdays);
        }
    }
}
