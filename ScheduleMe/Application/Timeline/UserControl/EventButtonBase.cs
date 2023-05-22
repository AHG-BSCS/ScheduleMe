namespace ScheduleMe.Tab;

public partial class EventButtonBase : UserControl
{
    public EventButtonBase()
    {
        InitializeComponent();
    }

    private DateTime _startDate;
    private DateTime _endDate;
    private Color _color;
    private string _description;

    public DateTime StartDate { get => _startDate; set => _startDate = value; }
    public DateTime EndDate { get => _endDate; set => _endDate = value; }
    public Color Color { get => _color; set => _color = value; }
    public string Event
    {
        get => eventName.Text;
        set => eventName.Text = value;
    }
    public string Description { get => _description; set => _description = value; }


}
