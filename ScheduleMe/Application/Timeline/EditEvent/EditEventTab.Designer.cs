namespace ScheduleMe.Tab;
partial class EditEventTab
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
        editEventTabMenu = new ContextMenuStrip(components);
        addOption = new ToolStripMenuItem();
        deleteOption = new ToolStripMenuItem();
        editEventTabMenu.SuspendLayout();
        SuspendLayout();
        // 
        // eventTab
        // 
        eventTab.AutoSize = true;
        eventTab.BackColor = Color.FromArgb(15, 76, 129);
        eventTab.ContextMenuStrip = editEventTabMenu;
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
        // EditEventTabBase
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = Color.Transparent;
        Controls.Add(eventTab);
        Margin = new Padding(0);
        Name = "EditEventTabBase";
        Size = new Size(72, 36);
        editEventTabMenu.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button eventTab;
    private ContextMenuStrip editEventTabMenu;
    private ToolStripMenuItem addOption;
    private ToolStripMenuItem deleteOption;
}
