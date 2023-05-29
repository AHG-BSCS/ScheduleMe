namespace ScheduleMe.Tab;

partial class TimelinePanel
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        pnlTabTool = new Panel();
        pnlTab = new Panel();
        btnJump = new PictureBox();
        btnAddTab = new Button();
        pnlEvents = new Panel();
        mnuTimeline = new ContextMenuStrip(components);
        mnuEdit = new ToolStripMenuItem();
        mnuDeletePanel = new ToolStripMenuItem();
        mnuSeparator = new ToolStripSeparator();
        mnuOpenAtBottom = new ToolStripMenuItem();
        pnlTabTool.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)btnJump).BeginInit();
        mnuTimeline.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTabTool
        // 
        pnlTabTool.BackColor = Color.FromArgb(15, 76, 129);
        pnlTabTool.Controls.Add(pnlTab);
        pnlTabTool.Controls.Add(btnJump);
        pnlTabTool.Controls.Add(btnAddTab);
        pnlTabTool.Dock = DockStyle.Top;
        pnlTabTool.Location = new Point(0, 0);
        pnlTabTool.Name = "pnlTabTool";
        pnlTabTool.Padding = new Padding(10, 0, 10, 0);
        pnlTabTool.Size = new Size(850, 35);
        pnlTabTool.TabIndex = 0;
        // 
        // pnlTab
        // 
        pnlTab.Dock = DockStyle.Fill;
        pnlTab.Location = new Point(48, 0);
        pnlTab.Name = "pnlTab";
        pnlTab.Size = new Size(757, 35);
        pnlTab.TabIndex = 0;
        // 
        // btnJump
        // 
        btnJump.BackColor = Color.Transparent;
        btnJump.BackgroundImageLayout = ImageLayout.Zoom;
        btnJump.Cursor = Cursors.Hand;
        btnJump.Dock = DockStyle.Right;
        btnJump.Location = new Point(805, 0);
        btnJump.Name = "btnJump";
        btnJump.Size = new Size(35, 35);
        btnJump.TabIndex = 3;
        btnJump.TabStop = false;
        btnJump.Click += btnJump_Click;
        // 
        // btnAddTab
        // 
        btnAddTab.BackColor = Color.FromArgb(64, 64, 64);
        btnAddTab.BackgroundImageLayout = ImageLayout.Zoom;
        btnAddTab.Cursor = Cursors.Hand;
        btnAddTab.Dock = DockStyle.Left;
        btnAddTab.FlatAppearance.BorderColor = Color.White;
        btnAddTab.FlatAppearance.BorderSize = 2;
        btnAddTab.FlatStyle = FlatStyle.Flat;
        btnAddTab.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        btnAddTab.ForeColor = Color.White;
        btnAddTab.Location = new Point(10, 0);
        btnAddTab.Margin = new Padding(0);
        btnAddTab.Name = "btnAddTab";
        btnAddTab.Size = new Size(38, 35);
        btnAddTab.TabIndex = 0;
        btnAddTab.TabStop = false;
        btnAddTab.Text = " ";
        btnAddTab.UseVisualStyleBackColor = false;
        btnAddTab.Click += btnAddTab_Click;
        // 
        // pnlEvents
        // 
        pnlEvents.AutoScroll = true;
        pnlEvents.BackColor = Color.Transparent;
        pnlEvents.ContextMenuStrip = mnuTimeline;
        pnlEvents.Dock = DockStyle.Top;
        pnlEvents.Location = new Point(0, 35);
        pnlEvents.Name = "pnlEvents";
        pnlEvents.Size = new Size(850, 0);
        pnlEvents.TabIndex = 0;
        // 
        // mnuTimeline
        // 
        mnuTimeline.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        mnuTimeline.Items.AddRange(new ToolStripItem[] { mnuEdit, mnuDeletePanel, mnuSeparator, mnuOpenAtBottom });
        mnuTimeline.Name = "timelineOption";
        mnuTimeline.Size = new Size(189, 88);
        mnuTimeline.Text = "Option";
        mnuTimeline.ItemClicked += mnuTimeline_ItemClicked;
        // 
        // mnuEdit
        // 
        mnuEdit.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        mnuEdit.ImageAlign = ContentAlignment.MiddleLeft;
        mnuEdit.Name = "mnuEdit";
        mnuEdit.Size = new Size(188, 26);
        mnuEdit.Text = "Edit";
        // 
        // mnuDeletePanel
        // 
        mnuDeletePanel.Name = "mnuDeletePanel";
        mnuDeletePanel.Size = new Size(188, 26);
        mnuDeletePanel.Text = "Delete Panel";
        // 
        // mnuSeparator
        // 
        mnuSeparator.Name = "mnuSeparator";
        mnuSeparator.Size = new Size(185, 6);
        // 
        // mnuOpenAtBottom
        // 
        mnuOpenAtBottom.ImageAlign = ContentAlignment.MiddleLeft;
        mnuOpenAtBottom.Name = "mnuOpenAtBottom";
        mnuOpenAtBottom.Size = new Size(188, 26);
        mnuOpenAtBottom.Text = "Open at the bottom";
        // 
        // TimelinePanel
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White;
        ClientSize = new Size(850, 35);
        Controls.Add(pnlEvents);
        Controls.Add(pnlTabTool);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 4, 3, 4);
        Name = "TimelinePanel";
        ShowIcon = false;
        WindowState = FormWindowState.Maximized;
        Load += Timeline_Load;
        pnlTabTool.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)btnJump).EndInit();
        mnuTimeline.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Button btnAddTab;
    private PictureBox btnJump;
    internal Panel pnlEvents;
    public Panel pnlTabTool;
    public Panel pnlTab;
    private ContextMenuStrip mnuTimeline;
    private ToolStripMenuItem mnuEdit;
    private ToolStripMenuItem mnuOpenAtBottom;
    private ToolStripMenuItem mnuDeletePanel;
    private ToolStripSeparator mnuSeparator;
}