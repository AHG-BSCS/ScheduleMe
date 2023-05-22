using LiteDB;

namespace ScheduleMe.Tab;

public partial class EventButtonBase : UserControl
{
    public ObjectId Id { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Color Color { get; set; }
    public string Description { get; set; }
    public string Event
    {
        get { return eventName.Text; }
        set { eventName.Text = value; }
    }

    public EventButtonBase()
    {
        InitializeComponent();
    }


    private void eventButtonMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == editOption)
        {
            EditEvent editEvent = new EditEvent();
            editEvent.ShowDialog();
        }

        else if (e.ClickedItem == deleteOption)
        {

        }
    }
}
