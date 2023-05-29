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
        btnTab = new Button();
        mnuTab = new ContextMenuStrip(components);
        mnuAdd = new ToolStripMenuItem();
        mnuEdit = new ToolStripMenuItem();
        mnuDelete = new ToolStripMenuItem();
        mnuSeparator = new ToolStripSeparator();
        mnuOpenAtBottom = new ToolStripMenuItem();
        mnuTab.SuspendLayout();
        SuspendLayout();
        // 
        // btnTab
        // 
        btnTab.AutoSize = true;
        btnTab.BackColor = Color.FromArgb(15, 76, 129);
        btnTab.ContextMenuStrip = mnuTab;
        btnTab.Cursor = Cursors.Hand;
        btnTab.Dock = DockStyle.Fill;
        btnTab.FlatAppearance.BorderColor = Color.White;
        btnTab.FlatAppearance.BorderSize = 0;
        btnTab.FlatStyle = FlatStyle.Flat;
        btnTab.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        btnTab.ForeColor = Color.White;
        btnTab.Location = new Point(0, 0);
        btnTab.Margin = new Padding(0);
        btnTab.Name = "btnTab";
        btnTab.Size = new Size(74, 36);
        btnTab.TabIndex = 0;
        btnTab.TabStop = false;
        btnTab.Text = "New Tab";
        btnTab.UseVisualStyleBackColor = false;
        btnTab.Click += btnTab_Click;
        // 
        // mnuTab
        // 
        mnuTab.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        mnuTab.Items.AddRange(new ToolStripItem[] { mnuAdd, mnuEdit, mnuDelete, mnuSeparator, mnuOpenAtBottom });
        mnuTab.Name = "timelineOption";
        mnuTab.Size = new Size(189, 136);
        mnuTab.Text = "Option";
        mnuTab.ItemClicked += mnuTab_ItemClicked;
        // 
        // mnuAdd
        // 
        mnuAdd.Image = Properties.Resources.mnuAdd;
        mnuAdd.Name = "mnuAdd";
        mnuAdd.Size = new Size(188, 26);
        mnuAdd.Text = "Add";
        // 
        // mnuEdit
        // 
        mnuEdit.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        mnuEdit.Image = Properties.Resources.mnuEdit;
        mnuEdit.Name = "mnuEdit";
        mnuEdit.Size = new Size(188, 26);
        mnuEdit.Text = "Edit";
        // 
        // mnuDelete
        // 
        mnuDelete.Image = Properties.Resources.mnuDelete;
        mnuDelete.Name = "mnuDelete";
        mnuDelete.Size = new Size(188, 26);
        mnuDelete.Text = "Delete";
        // 
        // mnuSeparator
        // 
        mnuSeparator.Name = "mnuSeparator";
        mnuSeparator.Size = new Size(185, 6);
        // 
        // mnuOpenAtBottom
        // 
        mnuOpenAtBottom.Image = Properties.Resources.mnuDIsplay;
        mnuOpenAtBottom.Name = "mnuOpenAtBottom";
        mnuOpenAtBottom.Size = new Size(188, 26);
        mnuOpenAtBottom.Text = "Open at the bottom";
        // 
        // TimelineTab
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = Color.Transparent;
        Controls.Add(btnTab);
        Margin = new Padding(0);
        Name = "TimelineTab";
        Size = new Size(74, 36);
        mnuTab.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ContextMenuStrip mnuTab;
    private ToolStripMenuItem mnuEdit;
    private ToolStripMenuItem mnuAdd;
    private ToolStripMenuItem mnuDelete;
    private ToolStripSeparator mnuSeparator;
    private ToolStripMenuItem mnuOpenAtBottom;
    public Button btnTab;
}
