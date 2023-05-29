namespace ScheduleMe.Tab;
partial class EditTimelineTab
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        btnEditTimelineTab = new Button();
        mnuEditTimelineTab = new ContextMenuStrip(components);
        mnuAdd = new ToolStripMenuItem();
        mnuDelete = new ToolStripMenuItem();
        mnuEditTimelineTab.SuspendLayout();
        SuspendLayout();
        // 
        // btnEditTimelineTab
        // 
        btnEditTimelineTab.AutoSize = true;
        btnEditTimelineTab.BackColor = Color.FromArgb(15, 76, 129);
        btnEditTimelineTab.ContextMenuStrip = mnuEditTimelineTab;
        btnEditTimelineTab.Cursor = Cursors.Hand;
        btnEditTimelineTab.Dock = DockStyle.Fill;
        btnEditTimelineTab.FlatAppearance.BorderColor = Color.White;
        btnEditTimelineTab.FlatAppearance.BorderSize = 0;
        btnEditTimelineTab.FlatStyle = FlatStyle.Flat;
        btnEditTimelineTab.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        btnEditTimelineTab.ForeColor = Color.White;
        btnEditTimelineTab.Location = new Point(0, 0);
        btnEditTimelineTab.Margin = new Padding(0);
        btnEditTimelineTab.Name = "btnEditTimelineTab";
        btnEditTimelineTab.Size = new Size(72, 36);
        btnEditTimelineTab.TabIndex = 0;
        btnEditTimelineTab.TabStop = false;
        btnEditTimelineTab.Text = "New Tab";
        btnEditTimelineTab.UseVisualStyleBackColor = false;
        btnEditTimelineTab.Click += btnEditTimelineTab_Click;
        // 
        // mnuEditTimelineTab
        // 
        mnuEditTimelineTab.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        mnuEditTimelineTab.Items.AddRange(new ToolStripItem[] { mnuAdd, mnuDelete });
        mnuEditTimelineTab.Name = "timelineOption";
        mnuEditTimelineTab.Size = new Size(116, 56);
        mnuEditTimelineTab.Text = "Option";
        mnuEditTimelineTab.ItemClicked += mnuEditTimelineTab_ItemClicked;
        // 
        // mnuAdd
        // 
        mnuAdd.Image = Properties.Resources.mnuAdd;
        mnuAdd.Name = "mnuAdd";
        mnuAdd.Size = new Size(115, 26);
        mnuAdd.Text = "Add";
        // 
        // mnuDelete
        // 
        mnuDelete.Image = Properties.Resources.mnuDelete;
        mnuDelete.Name = "mnuDelete";
        mnuDelete.Size = new Size(115, 26);
        mnuDelete.Text = "Delete";
        // 
        // EditTimelineTab
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = Color.Transparent;
        Controls.Add(btnEditTimelineTab);
        Margin = new Padding(0);
        Name = "EditTimelineTab";
        Size = new Size(72, 36);
        mnuEditTimelineTab.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ContextMenuStrip mnuEditTimelineTab;
    private ToolStripMenuItem mnuAdd;
    private ToolStripMenuItem mnuDelete;
    public Button btnEditTimelineTab;
}
