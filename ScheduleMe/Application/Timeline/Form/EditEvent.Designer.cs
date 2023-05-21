namespace ScheduleMe.Tab;

partial class EditEvent
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
        timelineTabPanel = new Panel();
        timelineAddTab = new Button();
        eventsInfoTLPanel = new TableLayoutPanel();
        eventColorHeader = new Label();
        eventEndDateHeader = new Label();
        eventStartDateHeader = new Label();
        eventDescriptionHeader = new Label();
        eventTitleHeader = new Label();
        eventInfoPanel = new Panel();
        addRowBtn = new Button();
        timelineTabPanel.SuspendLayout();
        eventsInfoTLPanel.SuspendLayout();
        SuspendLayout();
        // 
        // timelineTabPanel
        // 
        timelineTabPanel.BackColor = Color.FromArgb(15, 76, 129);
        timelineTabPanel.Controls.Add(timelineAddTab);
        timelineTabPanel.Dock = DockStyle.Top;
        timelineTabPanel.Location = new Point(0, 0);
        timelineTabPanel.Name = "timelineTabPanel";
        timelineTabPanel.Padding = new Padding(10, 0, 10, 0);
        timelineTabPanel.Size = new Size(984, 35);
        timelineTabPanel.TabIndex = 0;
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
        // eventsInfoTLPanel
        // 
        eventsInfoTLPanel.BackColor = SystemColors.ControlDark;
        eventsInfoTLPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        eventsInfoTLPanel.ColumnCount = 5;
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
        eventsInfoTLPanel.Controls.Add(eventColorHeader, 4, 0);
        eventsInfoTLPanel.Controls.Add(eventEndDateHeader, 3, 0);
        eventsInfoTLPanel.Controls.Add(eventStartDateHeader, 2, 0);
        eventsInfoTLPanel.Controls.Add(eventDescriptionHeader, 1, 0);
        eventsInfoTLPanel.Controls.Add(eventTitleHeader, 0, 0);
        eventsInfoTLPanel.Dock = DockStyle.Top;
        eventsInfoTLPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        eventsInfoTLPanel.Location = new Point(0, 35);
        eventsInfoTLPanel.Margin = new Padding(0);
        eventsInfoTLPanel.Name = "eventsInfoTLPanel";
        eventsInfoTLPanel.RowCount = 1;
        eventsInfoTLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        eventsInfoTLPanel.Size = new Size(984, 35);
        eventsInfoTLPanel.TabIndex = 0;
        // 
        // eventColorHeader
        // 
        eventColorHeader.AutoSize = true;
        eventColorHeader.BackColor = SystemColors.ControlDark;
        eventColorHeader.Dock = DockStyle.Fill;
        eventColorHeader.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        eventColorHeader.Location = new Point(940, 1);
        eventColorHeader.Name = "eventColorHeader";
        eventColorHeader.Size = new Size(40, 35);
        eventColorHeader.TabIndex = 0;
        eventColorHeader.Text = "Color";
        eventColorHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventEndDateHeader
        // 
        eventEndDateHeader.AutoSize = true;
        eventEndDateHeader.BackColor = SystemColors.ControlDark;
        eventEndDateHeader.Dock = DockStyle.Fill;
        eventEndDateHeader.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        eventEndDateHeader.Location = new Point(739, 1);
        eventEndDateHeader.Name = "eventEndDateHeader";
        eventEndDateHeader.Size = new Size(194, 35);
        eventEndDateHeader.TabIndex = 0;
        eventEndDateHeader.Text = "End Date/Time";
        eventEndDateHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventStartDateHeader
        // 
        eventStartDateHeader.AutoSize = true;
        eventStartDateHeader.BackColor = SystemColors.ControlDark;
        eventStartDateHeader.Dock = DockStyle.Fill;
        eventStartDateHeader.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        eventStartDateHeader.Location = new Point(538, 1);
        eventStartDateHeader.Name = "eventStartDateHeader";
        eventStartDateHeader.Size = new Size(194, 35);
        eventStartDateHeader.TabIndex = 0;
        eventStartDateHeader.Text = "Start Date/Time";
        eventStartDateHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventDescriptionHeader
        // 
        eventDescriptionHeader.AutoSize = true;
        eventDescriptionHeader.BackColor = SystemColors.ControlDark;
        eventDescriptionHeader.Dock = DockStyle.Fill;
        eventDescriptionHeader.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        eventDescriptionHeader.Location = new Point(218, 1);
        eventDescriptionHeader.Name = "eventDescriptionHeader";
        eventDescriptionHeader.Size = new Size(313, 35);
        eventDescriptionHeader.TabIndex = 0;
        eventDescriptionHeader.Text = "Description";
        eventDescriptionHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventTitleHeader
        // 
        eventTitleHeader.AutoSize = true;
        eventTitleHeader.BackColor = SystemColors.ControlDark;
        eventTitleHeader.Dock = DockStyle.Fill;
        eventTitleHeader.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        eventTitleHeader.Location = new Point(4, 1);
        eventTitleHeader.Name = "eventTitleHeader";
        eventTitleHeader.Size = new Size(207, 35);
        eventTitleHeader.TabIndex = 0;
        eventTitleHeader.Text = "Title";
        eventTitleHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventInfoPanel
        // 
        eventInfoPanel.AutoSize = true;
        eventInfoPanel.Dock = DockStyle.Top;
        eventInfoPanel.Location = new Point(0, 70);
        eventInfoPanel.Name = "eventInfoPanel";
        eventInfoPanel.Size = new Size(984, 0);
        eventInfoPanel.TabIndex = 0;
        // 
        // addRowBtn
        // 
        addRowBtn.BackColor = SystemColors.ControlDark;
        addRowBtn.Dock = DockStyle.Top;
        addRowBtn.FlatAppearance.BorderSize = 0;
        addRowBtn.FlatStyle = FlatStyle.Flat;
        addRowBtn.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        addRowBtn.ForeColor = Color.Black;
        addRowBtn.Location = new Point(0, 70);
        addRowBtn.Name = "addRowBtn";
        addRowBtn.Size = new Size(984, 35);
        addRowBtn.TabIndex = 1;
        addRowBtn.TabStop = false;
        addRowBtn.Text = "+";
        addRowBtn.UseVisualStyleBackColor = false;
        addRowBtn.Click += addRowBtn_Click;
        // 
        // EditEvent
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White;
        ClientSize = new Size(984, 511);
        Controls.Add(addRowBtn);
        Controls.Add(eventInfoPanel);
        Controls.Add(eventsInfoTLPanel);
        Controls.Add(timelineTabPanel);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Margin = new Padding(3, 4, 3, 4);
        Name = "EditEvent";
        Text = "Edit Event";
        timelineTabPanel.ResumeLayout(false);
        eventsInfoTLPanel.ResumeLayout(false);
        eventsInfoTLPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel timelineTabPanel;
    private Button timelineAddTab;
    private TableLayoutPanel eventsInfoTLPanel;
    private Label eventTitleHeader;
    private Label eventStartDateHeader;
    private Label eventDescriptionHeader;
    private Label eventColorHeader;
    private Label eventEndDateHeader;
    private Panel eventInfoPanel;
    private Button addRowBtn;
}