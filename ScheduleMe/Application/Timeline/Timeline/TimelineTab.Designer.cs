namespace ScheduleMe.Tab;
partial class TimelineTab
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
        timelineTabBtn = new Button();
        timelineTabMenu = new ContextMenuStrip(components);
        editOption = new ToolStripMenuItem();
        addOption = new ToolStripMenuItem();
        deleteOption = new ToolStripMenuItem();
        optionSeparator = new ToolStripSeparator();
        openAtBottomOption = new ToolStripMenuItem();
        timelineTabMenu.SuspendLayout();
        SuspendLayout();
        // 
        // timelineTabBtn
        // 
        timelineTabBtn.AutoSize = true;
        timelineTabBtn.BackColor = Color.FromArgb(15, 76, 129);
        timelineTabBtn.ContextMenuStrip = timelineTabMenu;
        timelineTabBtn.Dock = DockStyle.Fill;
        timelineTabBtn.FlatAppearance.BorderColor = Color.White;
        timelineTabBtn.FlatAppearance.BorderSize = 0;
        timelineTabBtn.FlatStyle = FlatStyle.Flat;
        timelineTabBtn.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        timelineTabBtn.ForeColor = Color.White;
        timelineTabBtn.Location = new Point(0, 0);
        timelineTabBtn.Margin = new Padding(0);
        timelineTabBtn.Name = "timelineTabBtn";
        timelineTabBtn.Size = new Size(74, 36);
        timelineTabBtn.TabIndex = 0;
        timelineTabBtn.TabStop = false;
        timelineTabBtn.Text = "New Tab";
        timelineTabBtn.UseVisualStyleBackColor = false;
        timelineTabBtn.Click += timelineTabBtn_Click;
        // 
        // timelineTabMenu
        // 
        timelineTabMenu.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        timelineTabMenu.Items.AddRange(new ToolStripItem[] { editOption, addOption, deleteOption, optionSeparator, openAtBottomOption });
        timelineTabMenu.Name = "timelineOption";
        timelineTabMenu.Size = new Size(189, 114);
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
        // TimelineTab
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = Color.Transparent;
        Controls.Add(timelineTabBtn);
        Margin = new Padding(0);
        Name = "TimelineTab";
        Size = new Size(74, 36);
        timelineTabMenu.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ContextMenuStrip timelineTabMenu;
    private ToolStripMenuItem editOption;
    private ToolStripMenuItem addOption;
    private ToolStripMenuItem deleteOption;
    private ToolStripSeparator optionSeparator;
    private ToolStripMenuItem openAtBottomOption;
    public Button timelineTabBtn;
}
