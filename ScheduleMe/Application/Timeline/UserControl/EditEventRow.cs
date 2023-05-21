namespace ScheduleMe.Tab;

public partial class EditEventRow : UserControl
{
    public EditEventRow()
    {
        InitializeComponent();
    }

    private void colorPickerBtn_Click(object sender, EventArgs e)
    {
        colorDialog.ShowDialog();
        colorPickerBtn.BackColor = colorDialog.Color;
    }
}
