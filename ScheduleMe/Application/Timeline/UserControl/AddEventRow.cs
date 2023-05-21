namespace ScheduleMe.Tab;

public partial class AddEventRow : UserControl
{
    public AddEventRow()
    {
        InitializeComponent();
    }

    public string Title
    {
        get { return titleTBox.Text; }
        set { titleTBox.Text = value; }
    }

    public string Description
    {
        get { return descriptionTBox.Text; }
        set { descriptionTBox.Text = value; }
    }

    public DateTime StartDate
    {
        get { return startDatePicker.Value; }
        set { startDatePicker.Value = value; }
    }

    public DateTime EndDate
    {
        get { return endDatePicker.Value; }
        set { endDatePicker.Value = value; }
    }

    public Color Color
    {
        get { return colorPickerBtn.BackColor; }
        set { colorPickerBtn.BackColor = value; }
    }

    private void colorPickerBtn_Click(object sender, EventArgs e)
    {
        colorDialog.ShowDialog();
        colorPickerBtn.BackColor = colorDialog.Color;
    }
}
