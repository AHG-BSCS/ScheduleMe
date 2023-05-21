namespace ScheduleMe.Tab;

public partial class AddEventRow : UserControl
{
    public AddEventRow()
    {
        InitializeComponent();
    }

    public string Title
    {
        set { titleTBox.Text = value; }
    }

    public string Description
    {
        set { descriptionTBox.Text = value; }
    }

    public DateTime StartDate
    {
        set { startDatePicker.Value = value; }
    }

    public DateTime EndDate
    {
        set { endDatePicker.Value = value; }
    }

    public Color Color
    {
        set { colorPickerBtn.BackColor = value; }
    }

    private void colorPickerBtn_Click(object sender, EventArgs e)
    {
        colorDialog.ShowDialog();
        colorPickerBtn.BackColor = colorDialog.Color;
    }
}
