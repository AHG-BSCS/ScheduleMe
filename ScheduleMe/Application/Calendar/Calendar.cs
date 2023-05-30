using Microsoft.VisualBasic;
using ScheduleMe.Tab;
using System.Globalization;
using System.Runtime.Serialization;

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

        string nameMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

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

        yearNowLbl.Text = nameMonth + " " + year.ToString();
    }

    private void nextBtn_Click(object sender, EventArgs e)
    {
        calendarContainer.Controls.Clear();
        month++;

        int days, dayOfTheWeek, i;

        string nameMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

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

        yearNowLbl.Text = nameMonth + " " + year.ToString();
    }

    private void previousBtn_Click(object sender, EventArgs e)
    {
        calendarContainer.Controls.Clear();
        month--;

        int days, dayOfTheWeek, i;

        string nameMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

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

        yearNowLbl.Text = nameMonth + " " + year.ToString();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        monthNowLbl.Text = DateTime.Now.ToString("MMMM").ToUpper();
        dayNowLbl.Text = DateTime.Now.ToString("dd").ToUpper();
    }

    private void prevYrBtn_Click(object sender, EventArgs e)
    {
        calendarContainer.Controls.Clear();
        year--;

        int days, dayOfTheWeek, i;

        string nameMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

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

        yearNowLbl.Text = nameMonth + " " + year.ToString();
    }

    private void Calendar_Load_1(object sender, EventArgs e)
    {

    }

    private void nextYrBtn_Click(object sender, EventArgs e)
    {
        calendarContainer.Controls.Clear();
        year++;

        int days, dayOfTheWeek, i;

        string nameMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
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

        yearNowLbl.Text = nameMonth + " " + year.ToString();
    }
}
