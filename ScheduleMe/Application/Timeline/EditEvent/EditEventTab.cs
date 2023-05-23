using LiteDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScheduleMe.Tab;

public partial class EditEventTab : UserControl
{
    public ObjectId Id { get; set; }    // Reference Id from the database
    public EditEvent editEventInstance; // Instance that created this UserControl

    public string tabName
    {
        set { timelineTabBtn.Text = value; }
    }

    public EditEventTab()
    {
        InitializeComponent();
    }

    private void HighlightButton()
    {
        editEventInstance.eventInfoPanel.Controls.Clear();
        foreach (EditEventTab tab in editEventInstance.timelineTabPanel.Controls.OfType<EditEventTab>())
        {
            if (editEventInstance.currentID == tab.Id)
            {
                tab.timelineTabBtn.BackColor = Color.FromArgb(15, 76, 129);
                tab.timelineTabBtn.ForeColor = Color.White;
                break;
            }
        }
        timelineTabBtn.BackColor = Color.White;
        timelineTabBtn.ForeColor = Color.Black;
    }

    private void ReverseHighlight()
    {
        editEventInstance.eventInfoPanel.Controls.Clear();
        foreach (EditEventTab tab in editEventInstance.timelineTabPanel.Controls.OfType<EditEventTab>())
        {
            if (editEventInstance.currentID == tab.Id)
            {
                tab.timelineTabBtn.BackColor = Color.White;
                tab.timelineTabBtn.ForeColor = Color.Black;
                break;
            }
            else
            {
                tab.timelineTabBtn.BackColor = Color.FromArgb(15, 76, 129);
                tab.timelineTabBtn.ForeColor = Color.White;
            }
        }
    }

    private void eventTab_Click(object sender, EventArgs e)
    {
        if (editEventInstance.currentID != Id)
        {
            HighlightButton();
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
    }

    private void editEventTabMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == addOption)
        {
            AddTimeline addTab = new AddTimeline();
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
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                timelines.Delete(Id); // Delete this Timeline
                var timeline = timelines.FindAll();
                if (timeline.Any() == true)
                {
                    Timeline firstToLoad = timeline.First();
                    if (editEventInstance.currentID == Id)
                    {
                        editEventInstance.currentID = firstToLoad.Id;
                        ReverseHighlight();
                        if (firstToLoad != null)
                        {
                            if (firstToLoad.Events != null)
                            {
                                for (ushort i = 0; i < firstToLoad.Events.Count; i++)
                                {
                                    AddEventRow newRow = new AddEventRow();
                                    newRow.SetRowInfo(firstToLoad.Events[i]);
                                    newRow.Id = firstToLoad.Id;
                                    newRow.Index = i;
                                    newRow.Dock = DockStyle.Top;
                                    editEventInstance.eventInfoPanel.Controls.Add(newRow);
                                }
                            }
                        }
                    }
                }
            }
            this.Dispose();
        }
    }
}
