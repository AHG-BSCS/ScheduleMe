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
        eventColorColumn = new FlowLayoutPanel();
        eventEndDateColumn = new FlowLayoutPanel();
        eventStartDateColumn = new FlowLayoutPanel();
        eventDescriptionColumn = new FlowLayoutPanel();
        eventColorHeader = new Label();
        eventEndDateHeader = new Label();
        eventStartDateHeader = new Label();
        eventDescriptionHeader = new Label();
        eventTitleHeader = new Label();
        eventTitleColumn = new FlowLayoutPanel();
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
        timelineTabPanel.Size = new Size(798, 35);
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
        // 
        // eventsInfoTLPanel
        // 
        eventsInfoTLPanel.BackColor = Color.Transparent;
        eventsInfoTLPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        eventsInfoTLPanel.ColumnCount = 5;
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.4235516F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1447582F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.1568756F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.8791046F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3957043F));
        eventsInfoTLPanel.Controls.Add(eventColorColumn, 4, 1);
        eventsInfoTLPanel.Controls.Add(eventEndDateColumn, 3, 1);
        eventsInfoTLPanel.Controls.Add(eventStartDateColumn, 2, 1);
        eventsInfoTLPanel.Controls.Add(eventDescriptionColumn, 1, 1);
        eventsInfoTLPanel.Controls.Add(eventColorHeader, 4, 0);
        eventsInfoTLPanel.Controls.Add(eventEndDateHeader, 3, 0);
        eventsInfoTLPanel.Controls.Add(eventStartDateHeader, 2, 0);
        eventsInfoTLPanel.Controls.Add(eventDescriptionHeader, 1, 0);
        eventsInfoTLPanel.Controls.Add(eventTitleHeader, 0, 0);
        eventsInfoTLPanel.Controls.Add(eventTitleColumn, 0, 1);
        eventsInfoTLPanel.Dock = DockStyle.Fill;
        eventsInfoTLPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        eventsInfoTLPanel.Location = new Point(0, 35);
        eventsInfoTLPanel.Margin = new Padding(0);
        eventsInfoTLPanel.Name = "eventsInfoTLPanel";
        eventsInfoTLPanel.RowCount = 2;
        eventsInfoTLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        eventsInfoTLPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        eventsInfoTLPanel.Size = new Size(798, 467);
        eventsInfoTLPanel.TabIndex = 0;
        // 
        // eventColorColumn
        // 
        eventColorColumn.Dock = DockStyle.Fill;
        eventColorColumn.Location = new Point(700, 40);
        eventColorColumn.Name = "eventColorColumn";
        eventColorColumn.Size = new Size(94, 423);
        eventColorColumn.TabIndex = 0;
        // 
        // eventEndDateColumn
        // 
        eventEndDateColumn.Dock = DockStyle.Fill;
        eventEndDateColumn.Location = new Point(550, 40);
        eventEndDateColumn.Name = "eventEndDateColumn";
        eventEndDateColumn.Size = new Size(143, 423);
        eventEndDateColumn.TabIndex = 0;
        // 
        // eventStartDateColumn
        // 
        eventStartDateColumn.Dock = DockStyle.Fill;
        eventStartDateColumn.Location = new Point(398, 40);
        eventStartDateColumn.Name = "eventStartDateColumn";
        eventStartDateColumn.Size = new Size(145, 423);
        eventStartDateColumn.TabIndex = 0;
        // 
        // eventDescriptionColumn
        // 
        eventDescriptionColumn.Dock = DockStyle.Fill;
        eventDescriptionColumn.Location = new Point(198, 40);
        eventDescriptionColumn.Name = "eventDescriptionColumn";
        eventDescriptionColumn.Size = new Size(193, 423);
        eventDescriptionColumn.TabIndex = 0;
        // 
        // eventColorHeader
        // 
        eventColorHeader.AutoSize = true;
        eventColorHeader.BackColor = Color.Silver;
        eventColorHeader.Dock = DockStyle.Fill;
        eventColorHeader.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        eventColorHeader.Location = new Point(700, 1);
        eventColorHeader.Name = "eventColorHeader";
        eventColorHeader.Size = new Size(94, 35);
        eventColorHeader.TabIndex = 0;
        eventColorHeader.Text = "Color";
        eventColorHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventEndDateHeader
        // 
        eventEndDateHeader.AutoSize = true;
        eventEndDateHeader.BackColor = Color.Silver;
        eventEndDateHeader.Dock = DockStyle.Fill;
        eventEndDateHeader.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        eventEndDateHeader.Location = new Point(550, 1);
        eventEndDateHeader.Name = "eventEndDateHeader";
        eventEndDateHeader.Size = new Size(143, 35);
        eventEndDateHeader.TabIndex = 0;
        eventEndDateHeader.Text = "End Date/Time";
        eventEndDateHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventStartDateHeader
        // 
        eventStartDateHeader.AutoSize = true;
        eventStartDateHeader.BackColor = Color.Silver;
        eventStartDateHeader.Dock = DockStyle.Fill;
        eventStartDateHeader.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        eventStartDateHeader.Location = new Point(398, 1);
        eventStartDateHeader.Name = "eventStartDateHeader";
        eventStartDateHeader.Size = new Size(145, 35);
        eventStartDateHeader.TabIndex = 0;
        eventStartDateHeader.Text = "Start Date/Time";
        eventStartDateHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventDescriptionHeader
        // 
        eventDescriptionHeader.AutoSize = true;
        eventDescriptionHeader.BackColor = Color.Silver;
        eventDescriptionHeader.Dock = DockStyle.Fill;
        eventDescriptionHeader.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        eventDescriptionHeader.Location = new Point(198, 1);
        eventDescriptionHeader.Name = "eventDescriptionHeader";
        eventDescriptionHeader.Size = new Size(193, 35);
        eventDescriptionHeader.TabIndex = 0;
        eventDescriptionHeader.Text = "Description";
        eventDescriptionHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventTitleHeader
        // 
        eventTitleHeader.AutoSize = true;
        eventTitleHeader.BackColor = Color.Silver;
        eventTitleHeader.Dock = DockStyle.Fill;
        eventTitleHeader.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        eventTitleHeader.Location = new Point(4, 1);
        eventTitleHeader.Name = "eventTitleHeader";
        eventTitleHeader.Size = new Size(187, 35);
        eventTitleHeader.TabIndex = 0;
        eventTitleHeader.Text = "Title";
        eventTitleHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventTitleColumn
        // 
        eventTitleColumn.Dock = DockStyle.Fill;
        eventTitleColumn.Location = new Point(4, 40);
        eventTitleColumn.Name = "eventTitleColumn";
        eventTitleColumn.Size = new Size(187, 423);
        eventTitleColumn.TabIndex = 0;
        // 
        // EditEvent
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(798, 502);
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
    private FlowLayoutPanel eventColorColumn;
    private FlowLayoutPanel eventEndDateColumn;
    private FlowLayoutPanel eventStartDateColumn;
    private FlowLayoutPanel eventDescriptionColumn;
    private FlowLayoutPanel eventTitleColumn;
}