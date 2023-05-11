namespace ScheduleMe.Tab;

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
            day.Location = new Point(50 * (currentDate - startDate).Days, 5);
            panelDateTimeContainer.Controls.Add(day);

            Label date = new Label();
            date.Text = currentDate.Day.ToString();
            date.AutoSize = true;
            date.Location = new Point(50 * (currentDate - startDate).Days, 25);
            panelDateTimeContainer.Controls.Add(date);

            Panel linePanel = new Panel();
            linePanel.BackColor = Color.Black;
            linePanel.Width = 1;
            linePanel.Height = panelDateTimeContainer.Height;
            linePanel.Location = new Point(date.Left + date.Width / 2, date.Height);
            panelDateTimeContainer.Controls.Add(linePanel);
        }
    }

    private void PopulateEvents(List<DateTime> dates, DateTime startDate)
    {
        foreach (DateTime date in dates)
        {
            Button button = new Button();
            button.Text = "Event";
            button.AutoSize = true;
            button.Height = 25;
            button.Width = 60;
            button.Location = new Point(panelDateTimeContainer.HorizontalScroll.Value + (date - startDate).Days * 100, 50);
            panelDateTimeContainer.Controls.Add(button);

            // Check for overlapping events and stack vertically
            foreach (Control control in panelDateTimeContainer.Controls)
            {
                if (control is Button && control != button)
                {
                    DateTime eventStartDate = date.AddDays(-1);
                    DateTime eventEndDate = date.AddDays(1);
                    DateTime controlStartDate = startDate.AddDays((control.Location.X - panelDateTimeContainer.HorizontalScroll.Value) / 100);
                    DateTime controlEndDate = startDate.AddDays((control.Location.X - panelDateTimeContainer.HorizontalScroll.Value + control.Width) / 100);

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
        List<DateTime> events = new List<DateTime>()
        {
            new DateTime(2023, 4, 13, 0, 0, 0),
            new DateTime(2023, 4, 21, 0, 0, 0),
            new DateTime(2023, 4, 27, 0, 0, 0),
            new DateTime(2023, 4, 12, 0, 0, 0),
            new DateTime(2023, 4, 12, 0, 0, 0),
            new DateTime(2023, 4, 12, 0, 0, 0),
            new DateTime(2023, 4, 16, 0, 0, 0),
            new DateTime(2023, 5, 1, 0, 0, 0),
            new DateTime(2023, 5, 2, 0, 0, 0)
        };

        PopulateDates(new DateTime(2023, 4, 12, 0, 0, 0), new DateTime(2023, 5, 16, 23, 59, 59));
        PopulateEvents(events, new DateTime(2023, 4, 12, 0, 0, 0));
    }
}
