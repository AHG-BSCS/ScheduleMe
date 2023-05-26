namespace ScheduleMe.Tab;

partial class TimelineMain
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
        timelineTabToolPanel = new Panel();
        panelTimelineTab = new Panel();
        currentDate = new PictureBox();
        timelineAddTab = new Button();
        panelTimelineContainer = new Panel();
        timelineMenu = new ContextMenuStrip(components);
        editOption = new ToolStripMenuItem();
        optionSeparator = new ToolStripSeparator();
        openAtBottomOption = new ToolStripMenuItem();
        timelineTabToolPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)currentDate).BeginInit();
        timelineMenu.SuspendLayout();
        SuspendLayout();
        // 
        // timelineTabToolPanel
        // 
        timelineTabToolPanel.BackColor = Color.FromArgb(15, 76, 129);
        timelineTabToolPanel.Controls.Add(panelTimelineTab);
        timelineTabToolPanel.Controls.Add(currentDate);
        timelineTabToolPanel.Controls.Add(timelineAddTab);
        timelineTabToolPanel.Dock = DockStyle.Top;
        timelineTabToolPanel.Location = new Point(0, 0);
        timelineTabToolPanel.Name = "timelineTabToolPanel";
        timelineTabToolPanel.Padding = new Padding(10, 0, 10, 0);
        timelineTabToolPanel.Size = new Size(850, 35);
        timelineTabToolPanel.TabIndex = 0;
        // 
        // panelTimelineTab
        // 
        panelTimelineTab.Dock = DockStyle.Fill;
        panelTimelineTab.Location = new Point(48, 0);
        panelTimelineTab.Name = "panelTimelineTab";
        panelTimelineTab.Size = new Size(757, 35);
        panelTimelineTab.TabIndex = 0;
        // 
        // currentDate
        // 
        currentDate.BackColor = Color.Transparent;
        currentDate.BackgroundImage = Properties.Resources.icon_placeholder;
        currentDate.BackgroundImageLayout = ImageLayout.Zoom;
        currentDate.Dock = DockStyle.Right;
        currentDate.Location = new Point(805, 0);
        currentDate.Name = "currentDate";
        currentDate.Size = new Size(35, 35);
        currentDate.TabIndex = 3;
        currentDate.TabStop = false;
        currentDate.Click += currentDate_Click;
        // 
        // timelineAddTab
        // 
        timelineAddTab.BackColor = Color.FromArgb(15, 76, 129);
        timelineAddTab.Dock = DockStyle.Left;
        timelineAddTab.FlatAppearance.BorderColor = Color.White;
        timelineAddTab.FlatAppearance.BorderSize = 2;
        timelineAddTab.FlatStyle = FlatStyle.Flat;
        timelineAddTab.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        timelineAddTab.ForeColor = Color.White;
        timelineAddTab.Location = new Point(10, 0);
        timelineAddTab.Margin = new Padding(0);
        timelineAddTab.Name = "timelineAddTab";
        timelineAddTab.Size = new Size(38, 35);
        timelineAddTab.TabIndex = 0;
        timelineAddTab.TabStop = false;
        timelineAddTab.Text = " +";
        timelineAddTab.UseVisualStyleBackColor = false;
        timelineAddTab.Click += timelineAddTab_Click;
        // 
        // panelTimelineContainer
        // 
        panelTimelineContainer.AutoScroll = true;
        panelTimelineContainer.BackColor = Color.Transparent;
        panelTimelineContainer.ContextMenuStrip = timelineMenu;
        panelTimelineContainer.Dock = DockStyle.Top;
        panelTimelineContainer.Location = new Point(0, 35);
        panelTimelineContainer.Name = "panelTimelineContainer";
        panelTimelineContainer.Size = new Size(850, 35);
        panelTimelineContainer.TabIndex = 0;
        // 
        // timelineMenu
        // 
        timelineMenu.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        timelineMenu.Items.AddRange(new ToolStripItem[] { editOption, optionSeparator, openAtBottomOption });
        timelineMenu.Name = "timelineOption";
        timelineMenu.Size = new Size(189, 62);
        timelineMenu.Text = "Option";
        timelineMenu.ItemClicked += timelineMenu_ItemClicked;
        // 
        // editOption
        // 
        editOption.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        editOption.Name = "editOption";
        editOption.Size = new Size(188, 26);
        editOption.Text = "Edit";
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
        // TimelineMain
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = Color.White;
        ClientSize = new Size(850, 70);
        Controls.Add(panelTimelineContainer);
        Controls.Add(timelineTabToolPanel);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 4, 3, 4);
        Name = "TimelineMain";
        ShowIcon = false;
        Text = "Timeline";
        WindowState = FormWindowState.Maximized;
        Load += Timeline_Load;
        timelineTabToolPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)currentDate).EndInit();
        timelineMenu.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Button timelineAddTab;
    private PictureBox currentDate;
    internal Panel panelTimelineContainer;
    public Panel timelineTabToolPanel;
    public Panel panelTimelineTab;
    private ContextMenuStrip timelineMenu;
    private ToolStripMenuItem editOption;
    private ToolStripSeparator optionSeparator;
    private ToolStripMenuItem openAtBottomOption;
}