namespace ScheduleMe.Tab;

public partial class AddEventRow : UserControl
{
    public AddEventRow()
    {
        InitializeComponent();
    }

    private void colorPickerBtn_Click(object sender, EventArgs e)
    {
        colorDialog.ShowDialog();
        colorPickerBtn.BackColor = colorDialog.Color;
    }
}
