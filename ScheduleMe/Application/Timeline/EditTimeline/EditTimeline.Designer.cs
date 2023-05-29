namespace ScheduleMe.Tab;

partial class EditTimeline
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
        pnlEditTimelineTabTools = new Panel();
        pnlTimelineTabs = new Panel();
        btnAddTab = new Button();
        pnlColumnLabels = new TableLayoutPanel();
        lblColor = new Label();
        lblEndDate = new Label();
        lblStartDate = new Label();
        lblDescription = new Label();
        lblTitle = new Label();
        pnlEventRows = new Panel();
        pnlEditTimelineTool = new Panel();
        pnlTimelineDates = new Panel();
        txtTimelineName = new TextBox();
        lblTimelineName = new Label();
        lblStartingDate = new Label();
        pckEndDate = new DateTimePicker();
        lblEndingDate = new Label();
        pckStartDate = new DateTimePicker();
        pnlToolButtons = new Panel();
        btnDelete = new Button();
        btnSave = new Button();
        btnAddRow = new Button();
        pnlEditTimelineTabTools.SuspendLayout();
        pnlColumnLabels.SuspendLayout();
        pnlEditTimelineTool.SuspendLayout();
        pnlTimelineDates.SuspendLayout();
        pnlToolButtons.SuspendLayout();
        SuspendLayout();
        // 
        // pnlEditTimelineTabTools
        // 
        pnlEditTimelineTabTools.BackColor = Color.FromArgb(15, 76, 129);
        pnlEditTimelineTabTools.Controls.Add(pnlTimelineTabs);
        pnlEditTimelineTabTools.Controls.Add(btnAddTab);
        pnlEditTimelineTabTools.Dock = DockStyle.Top;
        pnlEditTimelineTabTools.Location = new Point(0, 0);
        pnlEditTimelineTabTools.Name = "pnlEditTimelineTabTools";
        pnlEditTimelineTabTools.Padding = new Padding(10, 0, 10, 0);
        pnlEditTimelineTabTools.Size = new Size(984, 35);
        pnlEditTimelineTabTools.TabIndex = 0;
        // 
        // pnlTimelineTabs
        // 
        pnlTimelineTabs.Dock = DockStyle.Fill;
        pnlTimelineTabs.Location = new Point(48, 0);
        pnlTimelineTabs.Name = "pnlTimelineTabs";
        pnlTimelineTabs.Size = new Size(926, 35);
        pnlTimelineTabs.TabIndex = 0;
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
        // pnlColumnLabels
        // 
        pnlColumnLabels.BackColor = Color.FromArgb(15, 76, 129);
        pnlColumnLabels.ColumnCount = 5;
        pnlColumnLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        pnlColumnLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        pnlColumnLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        pnlColumnLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        pnlColumnLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
        pnlColumnLabels.Controls.Add(lblColor, 4, 0);
        pnlColumnLabels.Controls.Add(lblEndDate, 3, 0);
        pnlColumnLabels.Controls.Add(lblStartDate, 2, 0);
        pnlColumnLabels.Controls.Add(lblDescription, 1, 0);
        pnlColumnLabels.Controls.Add(lblTitle, 0, 0);
        pnlColumnLabels.Dock = DockStyle.Top;
        pnlColumnLabels.ForeColor = Color.White;
        pnlColumnLabels.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        pnlColumnLabels.Location = new Point(0, 90);
        pnlColumnLabels.Margin = new Padding(0);
        pnlColumnLabels.Name = "pnlColumnLabels";
        pnlColumnLabels.Padding = new Padding(3, 4, 0, 0);
        pnlColumnLabels.RowCount = 1;
        pnlColumnLabels.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        pnlColumnLabels.Size = new Size(984, 30);
        pnlColumnLabels.TabIndex = 0;
        // 
        // lblColor
        // 
        lblColor.AutoSize = true;
        lblColor.Dock = DockStyle.Top;
        lblColor.FlatStyle = FlatStyle.System;
        lblColor.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblColor.Location = new Point(950, 4);
        lblColor.Margin = new Padding(2, 0, 0, 0);
        lblColor.Name = "lblColor";
        lblColor.Size = new Size(34, 22);
        lblColor.TabIndex = 0;
        lblColor.Text = "Color";
        lblColor.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblEndDate
        // 
        lblEndDate.AutoSize = true;
        lblEndDate.Dock = DockStyle.Top;
        lblEndDate.FlatStyle = FlatStyle.System;
        lblEndDate.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblEndDate.Location = new Point(780, 4);
        lblEndDate.Margin = new Padding(2, 0, 0, 0);
        lblEndDate.Name = "lblEndDate";
        lblEndDate.Size = new Size(168, 22);
        lblEndDate.TabIndex = 0;
        lblEndDate.Text = "End Date/Time";
        lblEndDate.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblStartDate
        // 
        lblStartDate.AutoSize = true;
        lblStartDate.Dock = DockStyle.Top;
        lblStartDate.FlatStyle = FlatStyle.System;
        lblStartDate.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblStartDate.Location = new Point(610, 4);
        lblStartDate.Margin = new Padding(2, 0, 0, 0);
        lblStartDate.Name = "lblStartDate";
        lblStartDate.Size = new Size(168, 22);
        lblStartDate.TabIndex = 0;
        lblStartDate.Text = "Start Date/Time";
        lblStartDate.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Dock = DockStyle.Top;
        lblDescription.FlatStyle = FlatStyle.System;
        lblDescription.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblDescription.Location = new Point(217, 4);
        lblDescription.Margin = new Padding(2, 0, 0, 0);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new Size(391, 22);
        lblDescription.TabIndex = 0;
        lblDescription.Text = "Description";
        lblDescription.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Dock = DockStyle.Top;
        lblTitle.FlatStyle = FlatStyle.System;
        lblTitle.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitle.Location = new Point(5, 4);
        lblTitle.Margin = new Padding(2, 0, 0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(210, 22);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Title";
        lblTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlEventRows
        // 
        pnlEventRows.AutoSize = true;
        pnlEventRows.Dock = DockStyle.Top;
        pnlEventRows.Location = new Point(0, 120);
        pnlEventRows.Name = "pnlEventRows";
        pnlEventRows.Size = new Size(984, 0);
        pnlEventRows.TabIndex = 0;
        // 
        // pnlEditTimelineTool
        // 
        pnlEditTimelineTool.BackColor = Color.Transparent;
        pnlEditTimelineTool.Controls.Add(pnlTimelineDates);
        pnlEditTimelineTool.Controls.Add(pnlToolButtons);
        pnlEditTimelineTool.Dock = DockStyle.Top;
        pnlEditTimelineTool.Location = new Point(0, 35);
        pnlEditTimelineTool.Name = "pnlEditTimelineTool";
        pnlEditTimelineTool.Size = new Size(984, 55);
        pnlEditTimelineTool.TabIndex = 0;
        // 
        // pnlTimelineDates
        // 
        pnlTimelineDates.BackColor = Color.Transparent;
        pnlTimelineDates.Controls.Add(txtTimelineName);
        pnlTimelineDates.Controls.Add(lblTimelineName);
        pnlTimelineDates.Controls.Add(lblStartingDate);
        pnlTimelineDates.Controls.Add(pckEndDate);
        pnlTimelineDates.Controls.Add(lblEndingDate);
        pnlTimelineDates.Controls.Add(pckStartDate);
        pnlTimelineDates.Dock = DockStyle.Right;
        pnlTimelineDates.Location = new Point(356, 0);
        pnlTimelineDates.Name = "pnlTimelineDates";
        pnlTimelineDates.Size = new Size(628, 55);
        pnlTimelineDates.TabIndex = 5;
        // 
        // txtTimelineName
        // 
        txtTimelineName.BackColor = Color.White;
        txtTimelineName.BorderStyle = BorderStyle.FixedSingle;
        txtTimelineName.Cursor = Cursors.IBeam;
        txtTimelineName.ForeColor = Color.Black;
        txtTimelineName.Location = new Point(3, 22);
        txtTimelineName.MaxLength = 32;
        txtTimelineName.Name = "txtTimelineName";
        txtTimelineName.Size = new Size(200, 29);
        txtTimelineName.TabIndex = 0;
        txtTimelineName.TabStop = false;
        txtTimelineName.Validated += txtTimelineName_Validated;
        // 
        // lblTimelineName
        // 
        lblTimelineName.AutoSize = true;
        lblTimelineName.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblTimelineName.Location = new Point(3, 0);
        lblTimelineName.Name = "lblTimelineName";
        lblTimelineName.Size = new Size(90, 22);
        lblTimelineName.TabIndex = 3;
        lblTimelineName.Text = "Timeline Name";
        lblTimelineName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblStartingDate
        // 
        lblStartingDate.AutoSize = true;
        lblStartingDate.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblStartingDate.Location = new Point(250, 0);
        lblStartingDate.Name = "lblStartingDate";
        lblStartingDate.Size = new Size(84, 22);
        lblStartingDate.TabIndex = 0;
        lblStartingDate.Text = "Starting Date";
        lblStartingDate.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pckEndDate
        // 
        pckEndDate.Cursor = Cursors.Hand;
        pckEndDate.CustomFormat = "MMM dd, yyyy";
        pckEndDate.Format = DateTimePickerFormat.Custom;
        pckEndDate.Location = new Point(424, 22);
        pckEndDate.Margin = new Padding(0);
        pckEndDate.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        pckEndDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        pckEndDate.Name = "pckEndDate";
        pckEndDate.RightToLeft = RightToLeft.No;
        pckEndDate.Size = new Size(120, 29);
        pckEndDate.TabIndex = 0;
        pckEndDate.TabStop = false;
        pckEndDate.ValueChanged += pckEndDate_ValueChanged;
        // 
        // lblEndingDate
        // 
        lblEndingDate.AutoSize = true;
        lblEndingDate.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblEndingDate.Location = new Point(421, 0);
        lblEndingDate.Name = "lblEndingDate";
        lblEndingDate.Size = new Size(77, 22);
        lblEndingDate.TabIndex = 0;
        lblEndingDate.Text = "Ending Date";
        lblEndingDate.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pckStartDate
        // 
        pckStartDate.Cursor = Cursors.Hand;
        pckStartDate.CustomFormat = "MMM dd, yyyy";
        pckStartDate.Format = DateTimePickerFormat.Custom;
        pckStartDate.Location = new Point(254, 22);
        pckStartDate.Margin = new Padding(0);
        pckStartDate.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        pckStartDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        pckStartDate.Name = "pckStartDate";
        pckStartDate.RightToLeft = RightToLeft.No;
        pckStartDate.Size = new Size(120, 29);
        pckStartDate.TabIndex = 0;
        pckStartDate.TabStop = false;
        pckStartDate.ValueChanged += pckStartDate_ValueChanged;
        // 
        // pnlToolButtons
        // 
        pnlToolButtons.BackColor = Color.Transparent;
        pnlToolButtons.Controls.Add(btnDelete);
        pnlToolButtons.Controls.Add(btnSave);
        pnlToolButtons.Controls.Add(btnAddRow);
        pnlToolButtons.Dock = DockStyle.Left;
        pnlToolButtons.Location = new Point(0, 0);
        pnlToolButtons.Name = "pnlToolButtons";
        pnlToolButtons.Size = new Size(157, 55);
        pnlToolButtons.TabIndex = 4;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.FromArgb(15, 76, 129);
        btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
        btnDelete.Cursor = Cursors.Hand;
        btnDelete.FlatAppearance.BorderSize = 0;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
        btnDelete.ForeColor = Color.White;
        btnDelete.Location = new Point(104, 12);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(40, 30);
        btnDelete.TabIndex = 0;
        btnDelete.TabStop = false;
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(15, 76, 129);
        btnSave.BackgroundImageLayout = ImageLayout.Zoom;
        btnSave.Cursor = Cursors.Hand;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(58, 12);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(40, 30);
        btnSave.TabIndex = 0;
        btnSave.TabStop = false;
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // btnAddRow
        // 
        btnAddRow.BackColor = Color.FromArgb(15, 76, 129);
        btnAddRow.BackgroundImageLayout = ImageLayout.Zoom;
        btnAddRow.Cursor = Cursors.Hand;
        btnAddRow.FlatAppearance.BorderSize = 0;
        btnAddRow.FlatStyle = FlatStyle.Flat;
        btnAddRow.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
        btnAddRow.ForeColor = Color.White;
        btnAddRow.Location = new Point(12, 12);
        btnAddRow.Name = "btnAddRow";
        btnAddRow.Size = new Size(40, 30);
        btnAddRow.TabIndex = 0;
        btnAddRow.TabStop = false;
        btnAddRow.UseVisualStyleBackColor = false;
        btnAddRow.Click += btnAddRow_Click;
        // 
        // EditTimeline
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoScroll = true;
        BackColor = Color.White;
        ClientSize = new Size(984, 511);
        Controls.Add(pnlEventRows);
        Controls.Add(pnlColumnLabels);
        Controls.Add(pnlEditTimelineTool);
        Controls.Add(pnlEditTimelineTabTools);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(3, 4, 3, 4);
        Name = "EditTimeline";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Edit Timeline";
        Load += EditEvent_Load;
        pnlEditTimelineTabTools.ResumeLayout(false);
        pnlColumnLabels.ResumeLayout(false);
        pnlColumnLabels.PerformLayout();
        pnlEditTimelineTool.ResumeLayout(false);
        pnlTimelineDates.ResumeLayout(false);
        pnlTimelineDates.PerformLayout();
        pnlToolButtons.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button btnAddTab;
    private TableLayoutPanel pnlColumnLabels;
    private Label lblTitle;
    private Label lblStartDate;
    private Label lblDescription;
    private Label lblColor;
    private Label lblEndDate;
    internal Panel pnlEditTimelineTabTools;
    internal Panel pnlEventRows;
    private Panel pnlEditTimelineTool;
    private Button btnAddRow;
    private Button btnSave;
    private Label lblStartingDate;
    private DateTimePicker pckStartDate;
    private Label lblEndingDate;
    private DateTimePicker pckEndDate;
    private Button btnDelete;
    private Panel pnlTimelineDates;
    private Panel pnlToolButtons;
    internal Panel pnlTimelineTabs;
    private Label lblTimelineName;
    private TextBox txtTimelineName;
}