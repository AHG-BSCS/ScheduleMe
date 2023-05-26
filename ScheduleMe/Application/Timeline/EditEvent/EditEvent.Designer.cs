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
        addSavePanel = new Panel();
        panel2 = new Panel();
        fromLbl = new Label();
        timelineEndDatePicker = new DateTimePicker();
        label1 = new Label();
        timelineStartDatePicker = new DateTimePicker();
        panel1 = new Panel();
        deleteBtn = new Button();
        addRowBtn = new Button();
        saveBtn = new Button();
        timelineTabPanel.SuspendLayout();
        eventsInfoTLPanel.SuspendLayout();
        addSavePanel.SuspendLayout();
        panel2.SuspendLayout();
        panel1.SuspendLayout();
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
        // eventsInfoTLPanel
        // 
        eventsInfoTLPanel.BackColor = Color.FromArgb(15, 76, 129);
        eventsInfoTLPanel.ColumnCount = 5;
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
        eventsInfoTLPanel.Controls.Add(eventColorHeader, 4, 0);
        eventsInfoTLPanel.Controls.Add(eventEndDateHeader, 3, 0);
        eventsInfoTLPanel.Controls.Add(eventStartDateHeader, 2, 0);
        eventsInfoTLPanel.Controls.Add(eventDescriptionHeader, 1, 0);
        eventsInfoTLPanel.Controls.Add(eventTitleHeader, 0, 0);
        eventsInfoTLPanel.Dock = DockStyle.Top;
        eventsInfoTLPanel.ForeColor = Color.White;
        eventsInfoTLPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        eventsInfoTLPanel.Location = new Point(0, 90);
        eventsInfoTLPanel.Margin = new Padding(0);
        eventsInfoTLPanel.Name = "eventsInfoTLPanel";
        eventsInfoTLPanel.Padding = new Padding(3, 4, 0, 0);
        eventsInfoTLPanel.RowCount = 1;
        eventsInfoTLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        eventsInfoTLPanel.Size = new Size(984, 30);
        eventsInfoTLPanel.TabIndex = 0;
        // 
        // eventColorHeader
        // 
        eventColorHeader.AutoSize = true;
        eventColorHeader.Dock = DockStyle.Top;
        eventColorHeader.FlatStyle = FlatStyle.System;
        eventColorHeader.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        eventColorHeader.Location = new Point(950, 4);
        eventColorHeader.Margin = new Padding(2, 0, 0, 0);
        eventColorHeader.Name = "eventColorHeader";
        eventColorHeader.Size = new Size(34, 22);
        eventColorHeader.TabIndex = 0;
        eventColorHeader.Text = "Color";
        eventColorHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventEndDateHeader
        // 
        eventEndDateHeader.AutoSize = true;
        eventEndDateHeader.Dock = DockStyle.Top;
        eventEndDateHeader.FlatStyle = FlatStyle.System;
        eventEndDateHeader.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        eventEndDateHeader.Location = new Point(780, 4);
        eventEndDateHeader.Margin = new Padding(2, 0, 0, 0);
        eventEndDateHeader.Name = "eventEndDateHeader";
        eventEndDateHeader.Size = new Size(168, 22);
        eventEndDateHeader.TabIndex = 0;
        eventEndDateHeader.Text = "End Date/Time";
        eventEndDateHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventStartDateHeader
        // 
        eventStartDateHeader.AutoSize = true;
        eventStartDateHeader.Dock = DockStyle.Top;
        eventStartDateHeader.FlatStyle = FlatStyle.System;
        eventStartDateHeader.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        eventStartDateHeader.Location = new Point(610, 4);
        eventStartDateHeader.Margin = new Padding(2, 0, 0, 0);
        eventStartDateHeader.Name = "eventStartDateHeader";
        eventStartDateHeader.Size = new Size(168, 22);
        eventStartDateHeader.TabIndex = 0;
        eventStartDateHeader.Text = "Start Date/Time";
        eventStartDateHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventDescriptionHeader
        // 
        eventDescriptionHeader.AutoSize = true;
        eventDescriptionHeader.Dock = DockStyle.Top;
        eventDescriptionHeader.FlatStyle = FlatStyle.System;
        eventDescriptionHeader.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        eventDescriptionHeader.Location = new Point(217, 4);
        eventDescriptionHeader.Margin = new Padding(2, 0, 0, 0);
        eventDescriptionHeader.Name = "eventDescriptionHeader";
        eventDescriptionHeader.Size = new Size(391, 22);
        eventDescriptionHeader.TabIndex = 0;
        eventDescriptionHeader.Text = "Description";
        eventDescriptionHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventTitleHeader
        // 
        eventTitleHeader.AutoSize = true;
        eventTitleHeader.Dock = DockStyle.Top;
        eventTitleHeader.FlatStyle = FlatStyle.System;
        eventTitleHeader.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        eventTitleHeader.Location = new Point(5, 4);
        eventTitleHeader.Margin = new Padding(2, 0, 0, 0);
        eventTitleHeader.Name = "eventTitleHeader";
        eventTitleHeader.Size = new Size(210, 22);
        eventTitleHeader.TabIndex = 0;
        eventTitleHeader.Text = "Title";
        eventTitleHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // eventInfoPanel
        // 
        eventInfoPanel.AutoSize = true;
        eventInfoPanel.Dock = DockStyle.Top;
        eventInfoPanel.Location = new Point(0, 120);
        eventInfoPanel.Name = "eventInfoPanel";
        eventInfoPanel.Size = new Size(984, 0);
        eventInfoPanel.TabIndex = 0;
        // 
        // addSavePanel
        // 
        addSavePanel.BackColor = Color.Transparent;
        addSavePanel.Controls.Add(panel2);
        addSavePanel.Controls.Add(panel1);
        addSavePanel.Dock = DockStyle.Top;
        addSavePanel.Location = new Point(0, 35);
        addSavePanel.Name = "addSavePanel";
        addSavePanel.Size = new Size(984, 55);
        addSavePanel.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.BackColor = Color.Transparent;
        panel2.Controls.Add(fromLbl);
        panel2.Controls.Add(timelineEndDatePicker);
        panel2.Controls.Add(label1);
        panel2.Controls.Add(timelineStartDatePicker);
        panel2.Dock = DockStyle.Right;
        panel2.Location = new Point(601, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(383, 55);
        panel2.TabIndex = 5;
        // 
        // fromLbl
        // 
        fromLbl.AutoSize = true;
        fromLbl.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        fromLbl.Location = new Point(4, 1);
        fromLbl.Name = "fromLbl";
        fromLbl.Size = new Size(84, 22);
        fromLbl.TabIndex = 0;
        fromLbl.Text = "Starting Date";
        fromLbl.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // timelineEndDatePicker
        // 
        timelineEndDatePicker.CustomFormat = "MMM dd, yyyy";
        timelineEndDatePicker.Format = DateTimePickerFormat.Custom;
        timelineEndDatePicker.Location = new Point(178, 23);
        timelineEndDatePicker.Margin = new Padding(0);
        timelineEndDatePicker.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        timelineEndDatePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        timelineEndDatePicker.Name = "timelineEndDatePicker";
        timelineEndDatePicker.RightToLeft = RightToLeft.No;
        timelineEndDatePicker.Size = new Size(120, 29);
        timelineEndDatePicker.TabIndex = 2;
        timelineEndDatePicker.TabStop = false;
        timelineEndDatePicker.ValueChanged += timelineEndDatePicker_ValueChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(175, 1);
        label1.Name = "label1";
        label1.Size = new Size(77, 22);
        label1.TabIndex = 0;
        label1.Text = "Ending Date";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // timelineStartDatePicker
        // 
        timelineStartDatePicker.CustomFormat = "MMM dd, yyyy";
        timelineStartDatePicker.Format = DateTimePickerFormat.Custom;
        timelineStartDatePicker.Location = new Point(8, 23);
        timelineStartDatePicker.Margin = new Padding(0);
        timelineStartDatePicker.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        timelineStartDatePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        timelineStartDatePicker.Name = "timelineStartDatePicker";
        timelineStartDatePicker.RightToLeft = RightToLeft.No;
        timelineStartDatePicker.Size = new Size(120, 29);
        timelineStartDatePicker.TabIndex = 1;
        timelineStartDatePicker.TabStop = false;
        timelineStartDatePicker.ValueChanged += timelineStartDatePicker_ValueChanged;
        // 
        // panel1
        // 
        panel1.BackColor = Color.Transparent;
        panel1.Controls.Add(deleteBtn);
        panel1.Controls.Add(addRowBtn);
        panel1.Controls.Add(saveBtn);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(226, 55);
        panel1.TabIndex = 4;
        // 
        // deleteBtn
        // 
        deleteBtn.BackColor = Color.FromArgb(15, 76, 129);
        deleteBtn.FlatAppearance.BorderSize = 0;
        deleteBtn.FlatStyle = FlatStyle.Flat;
        deleteBtn.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
        deleteBtn.ForeColor = Color.White;
        deleteBtn.Location = new Point(152, 13);
        deleteBtn.Name = "deleteBtn";
        deleteBtn.Size = new Size(65, 30);
        deleteBtn.TabIndex = 3;
        deleteBtn.TabStop = false;
        deleteBtn.Text = "Delete";
        deleteBtn.UseVisualStyleBackColor = false;
        deleteBtn.Click += deleteBtn_Click;
        // 
        // addRowBtn
        // 
        addRowBtn.BackColor = Color.FromArgb(15, 76, 129);
        addRowBtn.FlatAppearance.BorderSize = 0;
        addRowBtn.FlatStyle = FlatStyle.Flat;
        addRowBtn.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
        addRowBtn.ForeColor = Color.White;
        addRowBtn.Location = new Point(10, 13);
        addRowBtn.Name = "addRowBtn";
        addRowBtn.Size = new Size(65, 30);
        addRowBtn.TabIndex = 0;
        addRowBtn.TabStop = false;
        addRowBtn.Text = "Add Row";
        addRowBtn.UseVisualStyleBackColor = false;
        addRowBtn.Click += addRowBtn_Click;
        // 
        // saveBtn
        // 
        saveBtn.BackColor = Color.FromArgb(15, 76, 129);
        saveBtn.FlatAppearance.BorderSize = 0;
        saveBtn.FlatStyle = FlatStyle.Flat;
        saveBtn.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
        saveBtn.ForeColor = Color.White;
        saveBtn.Location = new Point(81, 13);
        saveBtn.Name = "saveBtn";
        saveBtn.Size = new Size(65, 30);
        saveBtn.TabIndex = 0;
        saveBtn.TabStop = false;
        saveBtn.Text = "Save";
        saveBtn.UseVisualStyleBackColor = false;
        saveBtn.Click += saveBtn_Click;
        // 
        // EditEvent
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoScroll = true;
        BackColor = Color.White;
        ClientSize = new Size(984, 511);
        Controls.Add(eventInfoPanel);
        Controls.Add(eventsInfoTLPanel);
        Controls.Add(addSavePanel);
        Controls.Add(timelineTabPanel);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(3, 4, 3, 4);
        Name = "EditEvent";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Edit Event";
        Load += EditEvent_Load;
        timelineTabPanel.ResumeLayout(false);
        eventsInfoTLPanel.ResumeLayout(false);
        eventsInfoTLPanel.PerformLayout();
        addSavePanel.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button timelineAddTab;
    private TableLayoutPanel eventsInfoTLPanel;
    private Label eventTitleHeader;
    private Label eventStartDateHeader;
    private Label eventDescriptionHeader;
    private Label eventColorHeader;
    private Label eventEndDateHeader;
    internal Panel timelineTabPanel;
    internal Panel eventInfoPanel;
    private Panel addSavePanel;
    private Button addRowBtn;
    private Button saveBtn;
    private Label fromLbl;
    private DateTimePicker timelineStartDatePicker;
    private Label label1;
    private DateTimePicker timelineEndDatePicker;
    private Button deleteBtn;
    private Panel panel2;
    private Panel panel1;
}