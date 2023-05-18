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
        timelineTab2 = new Button();
        timelineTab1 = new Button();
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
        panelTimelineTab.Controls.Add(timelineTab2);
        panelTimelineTab.Controls.Add(timelineTab1);
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
        timelineAddTab.AutoSize = true;
        timelineAddTab.BackColor = Color.FromArgb(15, 76, 129);
        timelineAddTab.Dock = DockStyle.Left;
        timelineAddTab.FlatAppearance.BorderColor = Color.White;
        timelineAddTab.FlatStyle = FlatStyle.Flat;
        timelineAddTab.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        timelineAddTab.ForeColor = Color.White;
        timelineAddTab.Location = new Point(238, 0);
        timelineAddTab.Name = "timelineAddTab";
        timelineAddTab.Size = new Size(38, 35);
        timelineAddTab.TabIndex = 2;
        timelineAddTab.Text = " +";
        timelineAddTab.UseVisualStyleBackColor = false;
        timelineAddTab.Click += timelineAddTab_Click;
        // 
        // timelineTab2
        // 
        timelineTab2.AutoSize = true;
        timelineTab2.BackColor = Color.FromArgb(15, 76, 129);
        timelineTab2.Dock = DockStyle.Left;
        timelineTab2.FlatAppearance.BorderColor = Color.White;
        timelineTab2.FlatStyle = FlatStyle.Flat;
        timelineTab2.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        timelineTab2.ForeColor = Color.White;
        timelineTab2.Location = new Point(133, 0);
        timelineTab2.Name = "timelineTab2";
        timelineTab2.Size = new Size(105, 35);
        timelineTab2.TabIndex = 1;
        timelineTab2.Text = "CCS Week";
        timelineTab2.UseVisualStyleBackColor = false;
        // 
        // timelineTab1
        // 
        timelineTab1.AutoSize = true;
        timelineTab1.BackColor = Color.White;
        timelineTab1.Dock = DockStyle.Left;
        timelineTab1.FlatAppearance.BorderColor = Color.White;
        timelineTab1.FlatStyle = FlatStyle.Flat;
        timelineTab1.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        timelineTab1.ForeColor = Color.Black;
        timelineTab1.Location = new Point(10, 0);
        timelineTab1.Name = "timelineTab1";
        timelineTab1.Size = new Size(123, 35);
        timelineTab1.TabIndex = 0;
        timelineTab1.Text = "Genshin Impact";
        timelineTab1.UseVisualStyleBackColor = false;
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
        panelTimelineTab.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)additionalInfo).EndInit();
        ((System.ComponentModel.ISupportInitialize)currentDate).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panelTimelineTab;
    private Button timelineTab1;
    private Button timelineTab2;
    private Button timelineAddTab;
    private Panel panelTimelineContainer;
    private PictureBox currentDate;
    private PictureBox additionalInfo;
}