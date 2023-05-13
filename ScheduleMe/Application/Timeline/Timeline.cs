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
            Events events = new Events();
            events.StartDate = eventDate.Item1;
            events.EndDate = eventDate.Item2;
            events.Event = "Event " + i++;
            int eventDuration = (int)(eventDate.Item2 - eventDate.Item1).TotalDays;
            events.Width = eventDuration * columnSize;
            int eventsXAxis = panelTimelineContainer.HorizontalScroll.Value
                        + (eventDate.Item1 - startDate).Days
                        * columnSize;

            if (eventDate.Item2.Day > 9)
            {
                if (eventDate.Item1.Day > 9)
                    events.Location = new Point(eventsXAxis + 13, 50);
                else
                {
                    events.Location = new Point(eventsXAxis + 9, 50);
                    events.Width += 3;
                }
            }
            else
                events.Location = new Point(eventsXAxis + 9, 50);

            panelTimelineContainer.Controls.Add(events);
            ArrangeEventsOverlap(events);
        }
    }

    private void ArrangeEventsOverlap(Events events)
    {
        int baseHeight = 50;
        foreach (Events previousEvent in panelTimelineContainer.Controls)
        {
            if (previousEvent != events)
            {
                DateTime eventStartDate = events.StartDate;
                DateTime eventEndDate = events.EndDate;
                DateTime previousEventStartDate = previousEvent.StartDate;
                DateTime previousEventEndDate = previousEvent.EndDate;

                if ((eventStartDate >= previousEventStartDate && eventStartDate <= previousEventEndDate)
                    || (eventEndDate >= previousEventStartDate && eventEndDate <= previousEventEndDate))
                {
                    
                    int availableSpace = previousEvent.Top - events.Height - 10;
                    if (availableSpace >= baseHeight)
                    {
                        events.Top = availableSpace;
                    }
                    else
                    {
                        events.Top = previousEvent.Bottom + 10;
                        panelTimelineContainer.Height += 40;
                        baseHeight += 40;
                    }
                }
                else
                {
                    panelTimelineContainer.Height -= 20;
                }
            }
        }
    }


    private void Timeline_Load(object sender, EventArgs e)
    {
        List<Tuple<DateTime, DateTime>> events = new List<Tuple<DateTime, DateTime>>()
        {
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 1), new DateTime(2023, 4, 10)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 4), new DateTime(2023, 4, 6)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 5), new DateTime(2023, 4, 7)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 6), new DateTime(2023, 4, 12)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 13), new DateTime(2023, 4, 16)),
            new Tuple<DateTime, DateTime>(new DateTime(2023, 4, 15), new DateTime(2023, 4, 18)),
        };

        PopulateEvents(events, new DateTime(2023, 4, 1));
        PopulateDates(new DateTime(2023, 4, 1), new DateTime(2023, 4, 30));
    }
}
