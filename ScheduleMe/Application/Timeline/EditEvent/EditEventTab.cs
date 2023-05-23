using LiteDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScheduleMe.Tab;

public partial class EditEventTab : UserControl
{
    public ObjectId Id { get; set; }    // Reference Id from the database
    public EditEvent editEventInstance; // Instance that created this UserControl

    public string tabName
    {
        set { eventTab.Text = value; }
    }

    public EditEventTab()
    {
        InitializeComponent();
    }

    private void eventTab_Click(object sender, EventArgs e)
    {
        editEventInstance.eventInfoPanel.Controls.Clear();
        using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
        {
            var timelines = timelineDB.GetCollection<Timeline>("Timeline");
            var timelineTabs = timelines.FindById(Id);
            editEventInstance.currentID = Id;

            if (timelineTabs.Events != null)
            {
                for (ushort i = 0; i < timelineTabs.Events.Count; i++)
                {
                    AddEventRow newRow = new AddEventRow();
                    newRow.SetRowInfo(timelineTabs.Events[i]);
                    newRow.Id = timelineTabs.Id;
                    newRow.Index = i;
                    newRow.Dock = DockStyle.Top;
                    editEventInstance.eventInfoPanel.Controls.Add(newRow);
                }
            }
        }
    }

    private void editEventTabMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == addOption)
        {
            AddTimelineTab addTab = new AddTimelineTab();
            addTab.ShowDialog();

            if (addTab.Id != null)
            {
                // Load the new added TimelineTab
                using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
                {
                    var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                    var newtTab = new Timeline();
                    newtTab = timelines.FindById(addTab.Id);
                    editEventInstance.addNewTab(newtTab.TimelineName, newtTab.Id);
                }
            }
        }

        else if (e.ClickedItem == deleteOption)
        {
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                timelineDB.GetCollection("Timeline").Delete(Id);
            }
            editEventInstance.eventInfoPanel.Controls.Clear();
            this.Dispose();
            // Also switch to previous Tab if possible
        }
    }
}
