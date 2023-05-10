namespace ScheduleMe.Tab;

public partial class DateCell : UserControl
{
    public DateCell()
    {
        InitializeComponent();
    }

    public string DayName
    {
        get { return lblDayName.Text;  }
        set { lblDayName.Text = value;}
    }

    public string Date
    {
        get { return lblDate.Text; }
        set { lblDate.Text = value;}
    }
}
