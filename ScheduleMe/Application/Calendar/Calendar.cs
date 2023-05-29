using Microsoft.VisualBasic;
using ScheduleMe.Tab;

namespace ScheduleMe.Tab;

public partial class Calendar : Form
{
    int month, year;
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
        month = currentDateTime.Month;
        year = currentDateTime.Year;

        DateTime startOfTheMonth = new DateTime(year, month, 1);

        days = DateTime.DaysInMonth(year, month);

        dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

        for (i = 1; i < dayOfTheWeek + 1; i++)
        {
            UserControlBlank ucBlank = new UserControlBlank();
            calendarContainer.Controls.Add(ucBlank);
        }

        for (i = 1; i <= days; i++)
        {
            UserControlDays ucdays = new UserControlDays();
            ucdays.Days(i);
            calendarContainer.Controls.Add(ucdays);
        }
    }

    private void nextBtn_Click(object sender, EventArgs e)
    {
        calendarContainer.Controls.Clear();
        month++;

        int days, dayOfTheWeek, i;

        DateTime startOfTheMonth = new DateTime(year, month, 1);

        days = DateTime.DaysInMonth(year, month);

        dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

        for (i = 1; i < dayOfTheWeek + 1; i++)
        {
            UserControlBlank ucBlank = new UserControlBlank();
            calendarContainer.Controls.Add(ucBlank);
        }

        for (i = 1; i <= days; i++)
        {
            UserControlDays ucdays = new UserControlDays();
            ucdays.Days(i);
            calendarContainer.Controls.Add(ucdays);
        }
    }

    private void previousBtn_Click(object sender, EventArgs e)
    {
        calendarContainer.Controls.Clear();
        month--;

        int days, dayOfTheWeek, i;

        DateTime startOfTheMonth = new DateTime(year, month, 1);

        days = DateTime.DaysInMonth(year, month);

        dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

        for (i = 1; i < dayOfTheWeek + 1; i++)
        {
            UserControlBlank ucBlank = new UserControlBlank();
            calendarContainer.Controls.Add(ucBlank);
        }

        for (i = 1; i <= days; i++)
        {
            UserControlDays ucdays = new UserControlDays();
            ucdays.Days(i);
            calendarContainer.Controls.Add(ucdays);
        }
    }
}
