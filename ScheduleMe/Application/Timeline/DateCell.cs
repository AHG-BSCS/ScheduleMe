namespace ScheduleMe.Tab;

public partial class DateCell : UserControl
{
    public DateCell()
    {
        InitializeComponent();
    }

    public string dayName
    {
        get { return lblDayName.Text; }
        set { lblDayName.Text = value; }
    }

    public string date
    {
        get { return lblDate.Text; }
        set { lblDate.Text = value; }
    }
}
