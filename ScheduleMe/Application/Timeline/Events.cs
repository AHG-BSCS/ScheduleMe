namespace ScheduleMe.Tab;

public partial class Events : UserControl
{
    public Events()
    {
        InitializeComponent();
    }

    public Events(DateTime startDate, DateTime endDate)
    {
        StartDate = startDate;
        EndDate = endDate;
    }

    private DateTime _startDate;
    private DateTime _endDate;
    private Color _color;
    private string _event;
    private string _description;

    public DateTime StartDate { get => _startDate; set => _startDate = value; }
    public DateTime EndDate { get => _endDate; set => _endDate = value; }
    public Color Color { get => _color; set => _color = value; }
    public string Event { get => _event; set => _event = value; }
    public string Description { get => _description; set => _description = value; }
}
