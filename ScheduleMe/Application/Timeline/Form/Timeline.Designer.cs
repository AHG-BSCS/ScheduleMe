namespace ScheduleMe.Tab;

partial class Timeline
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
        panelTimelineTab = new Panel();
        additionalInfo = new PictureBox();
        currentDate = new PictureBox();
        timelineAddTab = new Button();
        panelTimelineContainer = new Panel();
        panelTimelineTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)additionalInfo).BeginInit();
        ((System.ComponentModel.ISupportInitialize)currentDate).BeginInit();
        SuspendLayout();
        // 
        // panelTimelineTab
        // 
        panelTimelineTab.BackColor = Color.FromArgb(15, 76, 129);
        panelTimelineTab.Controls.Add(additionalInfo);
        panelTimelineTab.Controls.Add(currentDate);
        panelTimelineTab.Controls.Add(timelineAddTab);
        panelTimelineTab.Dock = DockStyle.Top;
        panelTimelineTab.Location = new Point(0, 0);
        panelTimelineTab.Name = "panelTimelineTab";
        panelTimelineTab.Padding = new Padding(10, 0, 10, 0);
        panelTimelineTab.Size = new Size(850, 35);
        panelTimelineTab.TabIndex = 0;
        // 
        // additionalInfo
        // 
        additionalInfo.BackColor = Color.Transparent;
        additionalInfo.BackgroundImage = Properties.Resources.icon_placeholder;
        additionalInfo.BackgroundImageLayout = ImageLayout.Zoom;
        additionalInfo.Dock = DockStyle.Right;
        additionalInfo.Location = new Point(770, 0);
        additionalInfo.Name = "additionalInfo";
        additionalInfo.Size = new Size(35, 35);
        additionalInfo.TabIndex = 4;
        additionalInfo.TabStop = false;
        additionalInfo.Click += additionalInfo_Click;
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
        panelTimelineContainer.Dock = DockStyle.Top;
        panelTimelineContainer.Location = new Point(0, 35);
        panelTimelineContainer.Name = "panelTimelineContainer";
        panelTimelineContainer.Size = new Size(850, 102);
        panelTimelineContainer.TabIndex = 1;
        // 
        // Timeline
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White;
        ClientSize = new Size(850, 550);
        Controls.Add(panelTimelineContainer);
        Controls.Add(panelTimelineTab);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 4, 3, 4);
        Name = "Timeline";
        Text = "Timeline";
        WindowState = FormWindowState.Maximized;
        Load += Timeline_Load;
        panelTimelineTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)additionalInfo).EndInit();
        ((System.ComponentModel.ISupportInitialize)currentDate).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panelTimelineTab;
    private Button timelineAddTab;
    private Panel panelTimelineContainer;
    private PictureBox currentDate;
    private PictureBox additionalInfo;
}