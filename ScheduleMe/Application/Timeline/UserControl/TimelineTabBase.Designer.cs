namespace ScheduleMe.Tab;
partial class TimelineTabBase
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
        eventTab = new Button();
        timelineTabMenu = new ContextMenuStrip(components);
        editOption = new ToolStripMenuItem();
        addOption = new ToolStripMenuItem();
        deleteOption = new ToolStripMenuItem();
        optionSeparator = new ToolStripSeparator();
        openAtBottomOption = new ToolStripMenuItem();
        timelineTabMenu.SuspendLayout();
        SuspendLayout();
        // 
        // eventTab
        // 
        eventTab.AutoSize = true;
        eventTab.BackColor = Color.FromArgb(15, 76, 129);
        eventTab.ContextMenuStrip = timelineTabMenu;
        eventTab.Dock = DockStyle.Fill;
        eventTab.FlatAppearance.BorderColor = Color.White;
        eventTab.FlatAppearance.BorderSize = 2;
        eventTab.FlatStyle = FlatStyle.Flat;
        eventTab.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        eventTab.ForeColor = Color.White;
        eventTab.Location = new Point(0, 0);
        eventTab.Margin = new Padding(0);
        eventTab.Name = "eventTab";
        eventTab.Size = new Size(72, 36);
        eventTab.TabIndex = 0;
        eventTab.TabStop = false;
        eventTab.Text = "New Tab";
        eventTab.UseVisualStyleBackColor = false;
        eventTab.Click += eventTab_Click;
        // 
        // timelineTabMenu
        // 
        timelineTabMenu.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        timelineTabMenu.Items.AddRange(new ToolStripItem[] { editOption, addOption, deleteOption, optionSeparator, openAtBottomOption });
        timelineTabMenu.Name = "timelineOption";
        timelineTabMenu.Size = new Size(189, 136);
        timelineTabMenu.Text = "Option";
        timelineTabMenu.ItemClicked += timelineTabMenu_ItemClicked;
        // 
        // editOption
        // 
        editOption.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        editOption.Name = "editOption";
        editOption.Size = new Size(188, 26);
        editOption.Text = "Edit";
        // 
        // addOption
        // 
        addOption.Name = "addOption";
        addOption.Size = new Size(188, 26);
        addOption.Text = "Add";
        // 
        // deleteOption
        // 
        deleteOption.Name = "deleteOption";
        deleteOption.Size = new Size(188, 26);
        deleteOption.Text = "Delete";
        // 
        // optionSeparator
        // 
        optionSeparator.Name = "optionSeparator";
        optionSeparator.Size = new Size(185, 6);
        // 
        // openAtBottomOption
        // 
        openAtBottomOption.Name = "openAtBottomOption";
        openAtBottomOption.Size = new Size(188, 26);
        openAtBottomOption.Text = "Open at the bottom";
        // 
        // TimelineTabBase
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = Color.Transparent;
        Controls.Add(eventTab);
        Margin = new Padding(0);
        Name = "TimelineTabBase";
        Size = new Size(72, 36);
        timelineTabMenu.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button eventTab;
    private ContextMenuStrip timelineTabMenu;
    private ToolStripMenuItem editOption;
    private ToolStripMenuItem addOption;
    private ToolStripMenuItem deleteOption;
    private ToolStripSeparator optionSeparator;
    private ToolStripMenuItem openAtBottomOption;
}
