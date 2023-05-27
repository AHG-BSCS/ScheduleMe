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
        timelineTabBtn = new Button();
        editEventTabMenu = new ContextMenuStrip(components);
        addOption = new ToolStripMenuItem();
        deleteOption = new ToolStripMenuItem();
        editEventTabMenu.SuspendLayout();
        SuspendLayout();
        // 
        // timelineTabBtn
        // 
        timelineTabBtn.AutoSize = true;
        timelineTabBtn.BackColor = Color.FromArgb(15, 76, 129);
        timelineTabBtn.ContextMenuStrip = editEventTabMenu;
        timelineTabBtn.Dock = DockStyle.Fill;
        timelineTabBtn.FlatAppearance.BorderColor = Color.White;
        timelineTabBtn.FlatAppearance.BorderSize = 0;
        timelineTabBtn.FlatStyle = FlatStyle.Flat;
        timelineTabBtn.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        timelineTabBtn.ForeColor = Color.White;
        timelineTabBtn.Location = new Point(0, 0);
        timelineTabBtn.Margin = new Padding(0);
        timelineTabBtn.Name = "timelineTabBtn";
        timelineTabBtn.Size = new Size(72, 36);
        timelineTabBtn.TabIndex = 0;
        timelineTabBtn.TabStop = false;
        timelineTabBtn.Text = "New Tab";
        timelineTabBtn.UseVisualStyleBackColor = false;
        timelineTabBtn.Click += eventTab_Click;
        // 
        // editEventTabMenu
        // 
        editEventTabMenu.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        editEventTabMenu.Items.AddRange(new ToolStripItem[] { addOption, deleteOption });
        editEventTabMenu.Name = "timelineOption";
        editEventTabMenu.Size = new Size(116, 56);
        editEventTabMenu.Text = "Option";
        editEventTabMenu.ItemClicked += editEventTabMenu_ItemClicked;
        // 
        // addOption
        // 
        addOption.Name = "addOption";
        addOption.Size = new Size(115, 26);
        addOption.Text = "Add";
        // 
        // deleteOption
        // 
        deleteOption.Name = "deleteOption";
        deleteOption.Size = new Size(115, 26);
        deleteOption.Text = "Delete";
        // 
        // EditEventTab
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = Color.Transparent;
        Controls.Add(timelineTabBtn);
        Margin = new Padding(0);
        Name = "EditEventTab";
        Size = new Size(72, 36);
        editEventTabMenu.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ContextMenuStrip editEventTabMenu;
    private ToolStripMenuItem addOption;
    private ToolStripMenuItem deleteOption;
    public Button timelineTabBtn;
}
