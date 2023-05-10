﻿namespace ScheduleMe.Tab;

public partial class Timeline : Form
{
    public Timeline()
    {
        InitializeComponent();
        addDateCell(new DateTime(2023, 5, 1, 0, 0, 0), new DateTime(2023, 6, 16, 23, 59, 59));
    }

    private void addDateCell(DateTime startDate, DateTime endDate)
    {
        for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
        {
            flPanelDateTime.Controls.Add(new DateCell()
            { dayName = shortDayName(i.DayOfWeek.ToString()), date = i.Day.ToString() });
        }
    }

    private string shortDayName(string DayName)
    {
        switch (DayName)
        {
            case "Monday": return "Mon";
            case "Tuesday": return "Tue";
            case "Wednesday": return "Wed";
            case "Thursday": return "Thu";
            case "Friday": return "Fri";
            case "Saturday": return "Sat";
            case "Sunday": return "Sun";
            default: return "null";
        }
    }
}
