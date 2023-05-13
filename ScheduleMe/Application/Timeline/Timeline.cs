namespace ScheduleMe.Tab;

public partial class Timeline : Form
{
    public Timeline()
    {
        InitializeComponent();
    }

    private int columnSize = 50;

    private void PopulateDates(DateTime startDate, DateTime endDate)
    {
        for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            Label day = new Label();
            day.Text = currentDate.ToString("ddd");
            day.AutoSize = true;
            day.Location = new Point(columnSize * (currentDate - startDate).Days, 5);
            panelTimelineContainer.Controls.Add(day);

            Label date = new Label();
            date.Text = currentDate.Day.ToString();
            date.AutoSize = true;
            date.Location = new Point(columnSize * (currentDate - startDate).Days, 25);
            panelTimelineContainer.Controls.Add(date);

            Panel linePanel = new Panel();
            linePanel.BackColor = Color.Black;
            linePanel.Width = 1;
            linePanel.Height = panelTimelineContainer.Height - 40;
            linePanel.Location = new Point(date.Left + date.Width / 2, date.Height);
            panelTimelineContainer.Controls.Add(linePanel);
        }
    }

    private void PopulateEvents(List<Tuple<DateTime, DateTime>> eventDates, DateTime startDate)
    {
        int i = 1;
        foreach (Tuple<DateTime, DateTime> eventDate in eventDates)
        {
            Events newEvent = new Events();
            newEvent.StartDate = eventDate.Item1;
            newEvent.EndDate = eventDate.Item2;
            newEvent.Event = "Event " + i++;
            int eventDuration = (int)(eventDate.Item2 - eventDate.Item1).TotalDays;
            newEvent.Width = eventDuration * columnSize;
            int eventsXAxis = panelTimelineContainer.HorizontalScroll.Value
                        + (eventDate.Item1 - startDate).Days
                        * columnSize;

            if (eventDate.Item2.Day > 9)
            {
                if (eventDate.Item1.Day > 9)
                    newEvent.Location = new Point(eventsXAxis + 13, 50);
                else
                {
                    newEvent.Location = new Point(eventsXAxis + 9, 50);
                    newEvent.Width += 3;
                }
            }
            else
                newEvent.Location = new Point(eventsXAxis + 9, 50);

            panelTimelineContainer.Controls.Add(newEvent);
            ArrangeEventsOverlap(newEvent);
        }
    }

    private void ArrangeEventsOverlap(Events newEvent)
    {
        bool isRepeat = true;
        int previousEventTop = 0;
        foreach (Events previousEvent in panelTimelineContainer.Controls)
        {
            if (previousEvent != newEvent)
            {
                DateTime newEventStartDate = newEvent.StartDate;
                DateTime newEventEndDate = newEvent.EndDate;
                DateTime previousEventStartDate = previousEvent.StartDate;
                DateTime previousEventEndDate = previousEvent.EndDate;

                if ((newEventStartDate >= previousEventStartDate && newEventStartDate <= previousEventEndDate)
                    || (newEventStartDate >= previousEventStartDate && newEventEndDate >= previousEventStartDate)
                    || (newEventStartDate <= previousEventStartDate && newEventEndDate > previousEventStartDate)
                    || (newEventStartDate <= previousEventStartDate && newEventEndDate >= previousEventEndDate))
                {
                    if (previousEvent.Top > previousEventTop)
                    {
                        newEvent.Top = previousEvent.Bottom + 10;
                        previousEventTop = previousEvent.Top;

                        if (newEvent.Top >= previousEvent.Top && isRepeat)
                        {
                            panelTimelineContainer.Height += 40;
                            isRepeat = false; // set to false to prevent height increase
                        }
                    }
                }
            }
        }
    }



    private void Timeline_Load(object sender, EventArgs e)
    {
        List<Tuple<DateTime, DateTime>> events = new List<Tuple<DateTime, DateTime>>()
        {
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 6), new DateTime(2023, 4, 9)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 4), new DateTime(2023, 4, 8)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 5), new DateTime(2023, 4, 7)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 2), new DateTime(2023, 4, 4)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 3), new DateTime(2023, 4, 6)),
        };

        PopulateEvents(events, new DateTime(2023, 4, 1));
        PopulateDates(new DateTime(2023, 4, 1), new DateTime(2023, 4, 30));
    }
}
