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
        btnAddTab = new Button();
        btnTab2 = new Button();
        btnTab1 = new Button();
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
        panelTimelineTab.Controls.Add(btnAddTab);
        panelTimelineTab.Controls.Add(btnTab2);
        panelTimelineTab.Controls.Add(btnTab1);
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
        // btnAddTab
        // 
        btnAddTab.AutoSize = true;
        btnAddTab.BackColor = Color.FromArgb(15, 76, 129);
        btnAddTab.Dock = DockStyle.Left;
        btnAddTab.FlatAppearance.BorderColor = Color.White;
        btnAddTab.FlatStyle = FlatStyle.Flat;
        btnAddTab.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        btnAddTab.ForeColor = Color.White;
        btnAddTab.Location = new Point(238, 0);
        btnAddTab.Name = "btnAddTab";
        btnAddTab.Size = new Size(38, 35);
        btnAddTab.TabIndex = 2;
        btnAddTab.Text = " +";
        btnAddTab.UseVisualStyleBackColor = false;
        // 
        // btnTab2
        // 
        btnTab2.AutoSize = true;
        btnTab2.BackColor = Color.FromArgb(15, 76, 129);
        btnTab2.Dock = DockStyle.Left;
        btnTab2.FlatAppearance.BorderColor = Color.White;
        btnTab2.FlatStyle = FlatStyle.Flat;
        btnTab2.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        btnTab2.ForeColor = Color.White;
        btnTab2.Location = new Point(133, 0);
        btnTab2.Name = "btnTab2";
        btnTab2.Size = new Size(105, 35);
        btnTab2.TabIndex = 1;
        btnTab2.Text = "CCS Week";
        btnTab2.UseVisualStyleBackColor = false;
        // 
        // btnTab1
        // 
        btnTab1.AutoSize = true;
        btnTab1.BackColor = Color.White;
        btnTab1.Dock = DockStyle.Left;
        btnTab1.FlatAppearance.BorderColor = Color.White;
        btnTab1.FlatStyle = FlatStyle.Flat;
        btnTab1.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        btnTab1.ForeColor = Color.Black;
        btnTab1.Location = new Point(10, 0);
        btnTab1.Name = "btnTab1";
        btnTab1.Size = new Size(123, 35);
        btnTab1.TabIndex = 0;
        btnTab1.Text = "Genshin Impact";
        btnTab1.UseVisualStyleBackColor = false;
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
    private Button btnTab1;
    private Button btnTab2;
    private Button btnAddTab;
    private Panel panelTimelineContainer;
    private PictureBox currentDate;
    private PictureBox additionalInfo;
}