﻿namespace ScheduleMe.Tab;

public partial class Timeline : Form
{
    public Timeline()
    {
        InitializeComponent();
    }

    private void PopulateDates(DateTime startDate, DateTime endDate)
    {
        for (DateTime currentDate = startDate; currentDate < endDate; currentDate = currentDate.AddDays(1))
        {
            Label day = new Label();
            day.Text = currentDate.ToString("ddd");
            day.AutoSize = true;
            day.Location = new Point(50 * (currentDate - startDate).Days, 0);
            panelDateTimeContainer.Controls.Add(day);

            Label date = new Label();
            date.Text = currentDate.Day.ToString();
            date.AutoSize = true;
            date.Location = new Point(50 * (currentDate - startDate).Days, 20);
            panelDateTimeContainer.Controls.Add(date);

            // Create vertical line for each date
            Panel linePanel = new Panel();
            linePanel.BackColor = Color.Black;
            linePanel.Width = 1;
            linePanel.Height = panelDateTimeContainer.Height - date.Height;
            linePanel.Location = new Point(date.Left + date.Width / 2, date.Height);
            panelDateTimeContainer.Controls.Add(linePanel);
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

    private void PopulateEvents()
    {
        DateTime startDate = DateTime.Today;
        DateTime endDate = startDate.AddDays(7);

        for (DateTime date = startDate; date < endDate; date = date.AddDays(1))
        {
            // Create event button
            Button button = new Button();
            button.Text = "Event 1";
            button.AutoSize = true;
            button.Height = 50;
            button.Width = 100;
            button.Location = new Point(50 * (date - startDate).Days, 50);
            panelDateTimeContainer.Controls.Add(button);

            // Check for overlapping events and stack vertically
            foreach (Control control in panelDateTimeContainer.Controls)
            {
                if (control is Button && control != button)
                {
                    DateTime eventStartDate = date.AddDays(-1);
                    DateTime eventEndDate = date.AddDays(1);
                    DateTime controlStartDate = startDate.AddDays(control.Location.X / 100);
                    DateTime controlEndDate = startDate.AddDays((control.Location.X + control.Width) / 100);

                    if ((eventStartDate >= controlStartDate && eventStartDate <= controlEndDate)
                        || (eventEndDate >= controlStartDate && eventEndDate <= controlEndDate))
                    {
                        button.Top = control.Bottom;
                    }
                }
            }
        }
    }

    private void Timeline_Load(object sender, EventArgs e)
    {
        PopulateDates(new DateTime(2023, 5, 1, 0, 0, 0), new DateTime(2023, 6, 16, 23, 59, 59));
        PopulateEvents();
    }
}
