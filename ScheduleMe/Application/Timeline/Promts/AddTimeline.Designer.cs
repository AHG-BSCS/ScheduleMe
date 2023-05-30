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
        txtName = new TextBox();
        pckStartDate = new DateTimePicker();
        btnAdd = new Button();
        btnCancel = new Button();
        pckEndDate = new DateTimePicker();
        SuspendLayout();
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblName.Location = new Point(12, 17);
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
        lblStartDate.Location = new Point(12, 52);
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
        lblEndDate.Location = new Point(12, 87);
        lblEndDate.Name = "lblEndDate";
        lblEndDate.Size = new Size(60, 22);
        lblEndDate.TabIndex = 0;
        lblEndDate.Text = "End Date";
        lblEndDate.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtName
        // 
        txtName.BackColor = Color.White;
        txtName.BorderStyle = BorderStyle.FixedSingle;
        txtName.Cursor = Cursors.IBeam;
        txtName.ForeColor = Color.Black;
        txtName.Location = new Point(84, 14);
        txtName.MaxLength = 32;
        txtName.Name = "txtName";
        txtName.Size = new Size(200, 29);
        txtName.TabIndex = 0;
        txtName.TabStop = false;
        // 
        // pckStartDate
        // 
        pckStartDate.Cursor = Cursors.Hand;
        pckStartDate.CustomFormat = "dddd, MMM dd, yyyy";
        pckStartDate.Format = DateTimePickerFormat.Custom;
        pckStartDate.Location = new Point(84, 49);
        pckStartDate.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        pckStartDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        pckStartDate.Name = "pckStartDate";
        pckStartDate.RightToLeft = RightToLeft.No;
        pckStartDate.Size = new Size(200, 29);
        pckStartDate.TabIndex = 0;
        pckStartDate.TabStop = false;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.FromArgb(128, 128, 255);
        btnAdd.Cursor = Cursors.Hand;
        btnAdd.FlatAppearance.BorderSize = 0;
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        btnAdd.ForeColor = Color.Black;
        btnAdd.Location = new Point(84, 128);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(56, 32);
        btnAdd.TabIndex = 0;
        btnAdd.TabStop = false;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnCancel
        // 
        btnCancel.BackColor = Color.FromArgb(255, 128, 128);
        btnCancel.Cursor = Cursors.Hand;
        btnCancel.FlatAppearance.BorderSize = 0;
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        btnCancel.ForeColor = Color.Black;
        btnCancel.Location = new Point(146, 128);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(56, 32);
        btnCancel.TabIndex = 1;
        btnCancel.TabStop = false;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Click += btnCancel_Click;
        // 
        // pckEndDate
        // 
        pckEndDate.Cursor = Cursors.Hand;
        pckEndDate.CustomFormat = "dddd, MMM dd, yyyy";
        pckEndDate.Format = DateTimePickerFormat.Custom;
        pckEndDate.Location = new Point(84, 84);
        pckEndDate.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        pckEndDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        pckEndDate.Name = "pckEndDate";
        pckEndDate.RightToLeft = RightToLeft.No;
        pckEndDate.Size = new Size(200, 29);
        pckEndDate.TabIndex = 2;
        pckEndDate.TabStop = false;
        // 
        // AddTimeline
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(15, 76, 129);
        ClientSize = new Size(297, 175);
        Controls.Add(pckEndDate);
        Controls.Add(btnCancel);
        Controls.Add(btnAdd);
        Controls.Add(pckStartDate);
        Controls.Add(txtName);
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
    private TextBox txtName;
    private DateTimePicker pckStartDate;
    private Button btnAdd;
    private Button btnCancel;
    private DateTimePicker pckEndDate;
}