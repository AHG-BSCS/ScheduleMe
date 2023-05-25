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
            if (editEventInstance.CurrentID == tab.Id)
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
            if (editEventInstance.CurrentID == tab.Id)
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
        if (editEventInstance.CurrentID != Id)
        {
            HighlightButton();
            using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
            {
                var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                var timelineTab = timelines.FindById(Id);
                editEventInstance.CurrentID = Id;
                editEventInstance.MinDate = timelineTab.TimelineStartDate;
                editEventInstance.MaxDate = timelineTab.TimelineEndDate;
                editEventInstance.SetTimelineDateRange();

                if (timelineTab.Events.Any())
                {
                    for (ushort i = 0; i < timelineTab.Events.Count; i++)
                    {
                        AddEventRow newRow = new AddEventRow();
                        newRow.Id = timelineTab.Id;
                        newRow.Index = i;
                        newRow.MinDate = timelineTab.TimelineStartDate;
                        newRow.MaxDate = timelineTab.TimelineEndDate;
                        newRow.Dock = DockStyle.Bottom;
                        newRow.SetRowInfo(timelineTab.Events[i]);
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
            DeleteTimeline promt = new DeleteTimeline();
            promt.ShowDialog();

            if (promt.Answer)
            {
                using (var timelineDB = new LiteDatabase(DBConnection.timelineConnection))
                {
                    var timelines = timelineDB.GetCollection<Timeline>("Timeline");
                    timelines.Delete(Id); // Delete this Timeline
                    var timeline = timelines.FindAll();

                    if (timeline.Any())
                    {
                        Timeline firstToLoad = timeline.First();
                        if (editEventInstance.CurrentID == Id)
                        {
                            editEventInstance.CurrentID = firstToLoad.Id;
                            editEventInstance.MinDate = firstToLoad.TimelineStartDate;
                            editEventInstance.MaxDate = firstToLoad.TimelineEndDate;
                            editEventInstance.SetTimelineDateRange();

                            ReverseHighlight();
                            if (firstToLoad != null)
                            {
                                if (firstToLoad.Events.Any())
                                {
                                    for (ushort i = 0; i < firstToLoad.Events.Count; i++)
                                    {
                                        AddEventRow newRow = new AddEventRow();
                                        newRow.Id = firstToLoad.Id;
                                        newRow.Index = i;
                                        newRow.MinDate = firstToLoad.TimelineStartDate;
                                        newRow.MaxDate = firstToLoad.TimelineEndDate;
                                        newRow.Dock = DockStyle.Bottom;
                                        newRow.SetRowInfo(firstToLoad.Events[i]);
                                        editEventInstance.eventInfoPanel.Controls.Add(newRow);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        editEventInstance.eventInfoPanel.Controls.Clear();
                        editEventInstance.CurrentID = null;
                    }
                }
                this.Dispose();
            }
        }
    }
}
