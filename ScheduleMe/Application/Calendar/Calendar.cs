using LiteDB;
using System.Globalization;

namespace ScheduleMe.Tab;

public partial class Calendar : Form
{
    public static int month, year;
    public static string staticMonth, staticYear;
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

        staticMonth = month.ToString();
        staticYear = year.ToString();

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
            bool isCreated = false;
            using var timelineConnection = new LiteDatabase(DBConnection.databaseConnection_calendar);
            var timelineDB = timelineConnection.GetCollection<CalendarEvent>("Calendar");
            var calendarEvents = timelineDB.FindAll();

            foreach (CalendarEvent calendarEvent in calendarEvents)
            {
                if (calendarEvent.EventDate == new DateTime(year, month, i))
                {
                    UserControlDays ucdays2 = new UserControlDays();
                    ucdays2.Days(i);
                    ucdays2.OwnDate = new DateTime(year, month, i);
                    ucdays2.lblEventName.Text = calendarEvent.EventName;
                    calendarContainer.Controls.Add(ucdays2);
                    isCreated = true;
                    break;
                }
                else
                    isCreated = false;
            }

            if (!isCreated)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Days(i);
                ucdays.OwnDate = new DateTime(year, month, i);
                calendarContainer.Controls.Add(ucdays);
            }

        }

        UCMonthYearDisplay ucMY = new UCMonthYearDisplay();
        ucMY.MonthYearDetails(nameMonth, year);
        monthYearContainer.Controls.Add(ucMY);
    }

    private void nextBtn_Click(object sender, EventArgs e)
    {
        calendarContainer.Controls.Clear();
        monthYearContainer.Controls.Clear();
        month++;

        if (month == 13)
        {
            month = 1;
            year++;
        }

        staticMonth = month.ToString();
        staticYear = year.ToString();

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
            bool isCreated = false;
            using var timelineConnection = new LiteDatabase(DBConnection.databaseConnection_calendar);
            var timelineDB = timelineConnection.GetCollection<CalendarEvent>("Calendar");
            var calendarEvents = timelineDB.FindAll();

            foreach (CalendarEvent calendarEvent in calendarEvents)
            {
                if (calendarEvent.EventDate == new DateTime(year, month, i))
                {
                    UserControlDays ucdays2 = new UserControlDays();
                    ucdays2.Days(i);
                    ucdays2.OwnDate = new DateTime(year, month, i);
                    ucdays2.lblEventName.Text = calendarEvent.EventName;
                    calendarContainer.Controls.Add(ucdays2);
                    isCreated = true;
                    break;
                }
                else
                    isCreated = false;
            }

            if (!isCreated)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Days(i);
                ucdays.OwnDate = new DateTime(year, month, i);
                calendarContainer.Controls.Add(ucdays);
            }
        }

        UCMonthYearDisplay ucMY = new UCMonthYearDisplay();
        ucMY.MonthYearDetails(nameMonth, year);
        monthYearContainer.Controls.Add(ucMY);
        //yearNowLbl.Text = nameMonth + " " + year.ToString();
    }

    private void previousBtn_Click(object sender, EventArgs e)
    {
        calendarContainer.Controls.Clear();
        monthYearContainer.Controls.Clear();
        month--;

        if (month == 0)
        {
            month = 12;
            year--;
        }

        staticMonth = month.ToString();
        staticYear = year.ToString();

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
            bool isCreated = false;
            using var timelineConnection = new LiteDatabase(DBConnection.databaseConnection_calendar);
            var timelineDB = timelineConnection.GetCollection<CalendarEvent>("Calendar");
            var calendarEvents = timelineDB.FindAll();

            foreach (CalendarEvent calendarEvent in calendarEvents)
            {
                if (calendarEvent.EventDate == new DateTime(year, month, i))
                {
                    UserControlDays ucdays2 = new UserControlDays();
                    ucdays2.Days(i);
                    ucdays2.OwnDate = new DateTime(year, month, i);
                    ucdays2.lblEventName.Text = calendarEvent.EventName;
                    calendarContainer.Controls.Add(ucdays2);
                    isCreated = true;
                    break;
                }
                else
                    isCreated = false;
            }

            if (!isCreated)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Days(i);
                ucdays.OwnDate = new DateTime(year, month, i);
                calendarContainer.Controls.Add(ucdays);
            }
        }

        UCMonthYearDisplay ucMY = new UCMonthYearDisplay();
        ucMY.MonthYearDetails(nameMonth, year);
        monthYearContainer.Controls.Add(ucMY);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        monthNowLbl.Text = DateTime.Now.ToString("MMMM").ToUpper();
        dayNowLbl.Text = DateTime.Now.ToString("dd").ToUpper();
    }

    private void prevYrBtn_Click(object sender, EventArgs e)
    {
        calendarContainer.Controls.Clear();
        monthYearContainer.Controls.Clear();
        year--;

        staticMonth = month.ToString();
        staticYear = year.ToString();

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
            bool isCreated = false;
            using var timelineConnection = new LiteDatabase(DBConnection.databaseConnection_calendar);
            var timelineDB = timelineConnection.GetCollection<CalendarEvent>("Calendar");
            var calendarEvents = timelineDB.FindAll();

            foreach (CalendarEvent calendarEvent in calendarEvents)
            {
                if (calendarEvent.EventDate == new DateTime(year, month, i))
                {
                    UserControlDays ucdays2 = new UserControlDays();
                    ucdays2.Days(i);
                    ucdays2.OwnDate = new DateTime(year, month, i);
                    ucdays2.lblEventName.Text = calendarEvent.EventName;
                    calendarContainer.Controls.Add(ucdays2);
                    isCreated = true;
                    break;
                }
                else
                    isCreated = false;
            }

            if (!isCreated)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Days(i);
                ucdays.OwnDate = new DateTime(year, month, i);
                calendarContainer.Controls.Add(ucdays);
            }
        }

        UCMonthYearDisplay ucMY = new UCMonthYearDisplay();
        ucMY.MonthYearDetails(nameMonth, year);
        monthYearContainer.Controls.Add(ucMY);
    }

    private void Calendar_Load_1(object sender, EventArgs e)
    {

    }

    private void nextYrBtn_Click(object sender, EventArgs e)
    {
        calendarContainer.Controls.Clear();
        monthYearContainer.Controls.Clear();
        year++;

        staticMonth = month.ToString();
        staticYear = year.ToString();

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
            bool isCreated = false;
            using var timelineConnection = new LiteDatabase(DBConnection.databaseConnection_calendar);
            var timelineDB = timelineConnection.GetCollection<CalendarEvent>("Calendar");
            var calendarEvents = timelineDB.FindAll();

            foreach (CalendarEvent calendarEvent in calendarEvents)
            {
                if (calendarEvent.EventDate == new DateTime(year, month, i))
                {
                    UserControlDays ucdays2 = new UserControlDays();
                    ucdays2.Days(i);
                    ucdays2.OwnDate = new DateTime(year, month, i);
                    ucdays2.lblEventName.Text = calendarEvent.EventName;
                    calendarContainer.Controls.Add(ucdays2);
                    isCreated = true;
                    break;
                }
                else
                    isCreated = false;
            }

            if (!isCreated)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Days(i);
                ucdays.OwnDate = new DateTime(year, month, i);
                calendarContainer.Controls.Add(ucdays);
            }
        }

        UCMonthYearDisplay ucMY = new UCMonthYearDisplay();
        ucMY.MonthYearDetails(nameMonth, year);
        monthYearContainer.Controls.Add(ucMY);
    }
}
