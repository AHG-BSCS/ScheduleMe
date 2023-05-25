namespace ScheduleMe.Tab;

partial class AddTimeline
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
        lblName = new Label();
        lblStartDate = new Label();
        lblEndDate = new Label();
        tBoxName = new TextBox();
        startDatePicker = new DateTimePicker();
        btnSaveTimeline = new Button();
        btnCancelTimeline = new Button();
        endDatePicker = new DateTimePicker();
        SuspendLayout();
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblName.Location = new Point(12, 15);
        lblName.Name = "lblName";
        lblName.Size = new Size(41, 22);
        lblName.TabIndex = 0;
        lblName.Text = "Name";
        lblName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblStartDate
        // 
        lblStartDate.AutoSize = true;
        lblStartDate.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblStartDate.Location = new Point(12, 50);
        lblStartDate.Name = "lblStartDate";
        lblStartDate.Size = new Size(67, 22);
        lblStartDate.TabIndex = 0;
        lblStartDate.Text = "Start Date";
        lblStartDate.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblEndDate
        // 
        lblEndDate.AutoSize = true;
        lblEndDate.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblEndDate.Location = new Point(12, 85);
        lblEndDate.Name = "lblEndDate";
        lblEndDate.Size = new Size(60, 22);
        lblEndDate.TabIndex = 0;
        lblEndDate.Text = "End Date";
        lblEndDate.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tBoxName
        // 
        tBoxName.BackColor = Color.White;
        tBoxName.BorderStyle = BorderStyle.FixedSingle;
        tBoxName.ForeColor = Color.Black;
        tBoxName.Location = new Point(84, 12);
        tBoxName.MaxLength = 32;
        tBoxName.Name = "tBoxName";
        tBoxName.Size = new Size(200, 29);
        tBoxName.TabIndex = 0;
        tBoxName.TabStop = false;
        // 
        // startDatePicker
        // 
        startDatePicker.CustomFormat = "dddd, MMM dd, yyyy";
        startDatePicker.Format = DateTimePickerFormat.Custom;
        startDatePicker.Location = new Point(84, 47);
        startDatePicker.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        startDatePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        startDatePicker.Name = "startDatePicker";
        startDatePicker.RightToLeft = RightToLeft.No;
        startDatePicker.Size = new Size(200, 29);
        startDatePicker.TabIndex = 0;
        startDatePicker.TabStop = false;
        // 
        // btnSaveTimeline
        // 
        btnSaveTimeline.BackColor = Color.FromArgb(128, 128, 255);
        btnSaveTimeline.FlatAppearance.BorderSize = 0;
        btnSaveTimeline.FlatStyle = FlatStyle.Flat;
        btnSaveTimeline.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        btnSaveTimeline.ForeColor = Color.Black;
        btnSaveTimeline.Location = new Point(84, 126);
        btnSaveTimeline.Name = "btnSaveTimeline";
        btnSaveTimeline.Size = new Size(56, 32);
        btnSaveTimeline.TabIndex = 0;
        btnSaveTimeline.TabStop = false;
        btnSaveTimeline.Text = "Add";
        btnSaveTimeline.UseVisualStyleBackColor = false;
        btnSaveTimeline.Click += btnSaveTimeline_Click;
        // 
        // btnCancelTimeline
        // 
        btnCancelTimeline.BackColor = Color.FromArgb(255, 128, 128);
        btnCancelTimeline.FlatAppearance.BorderSize = 0;
        btnCancelTimeline.FlatStyle = FlatStyle.Flat;
        btnCancelTimeline.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        btnCancelTimeline.ForeColor = Color.Black;
        btnCancelTimeline.Location = new Point(146, 126);
        btnCancelTimeline.Name = "btnCancelTimeline";
        btnCancelTimeline.Size = new Size(56, 32);
        btnCancelTimeline.TabIndex = 1;
        btnCancelTimeline.TabStop = false;
        btnCancelTimeline.Text = "Cancel";
        btnCancelTimeline.UseVisualStyleBackColor = false;
        btnCancelTimeline.Click += btnCancelTimeline_Click;
        // 
        // endDatePicker
        // 
        endDatePicker.CustomFormat = "dddd, MMM dd, yyyy";
        endDatePicker.Format = DateTimePickerFormat.Custom;
        endDatePicker.Location = new Point(84, 82);
        endDatePicker.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        endDatePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        endDatePicker.Name = "endDatePicker";
        endDatePicker.RightToLeft = RightToLeft.No;
        endDatePicker.Size = new Size(200, 29);
        endDatePicker.TabIndex = 2;
        endDatePicker.TabStop = false;
        // 
        // AddTimeline
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(15, 76, 129);
        ClientSize = new Size(294, 170);
        Controls.Add(endDatePicker);
        Controls.Add(btnCancelTimeline);
        Controls.Add(btnSaveTimeline);
        Controls.Add(startDatePicker);
        Controls.Add(tBoxName);
        Controls.Add(lblEndDate);
        Controls.Add(lblStartDate);
        Controls.Add(lblName);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 4, 3, 4);
        Name = "AddTimeline";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Add Timeline";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblName;
    private Label lblStartDate;
    private Label lblEndDate;
    private TextBox tBoxName;
    private DateTimePicker startDatePicker;
    private Button btnSaveTimeline;
    private Button btnCancelTimeline;
    private DateTimePicker endDatePicker;
}