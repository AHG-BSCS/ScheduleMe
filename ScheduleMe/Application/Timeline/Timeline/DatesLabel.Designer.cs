namespace ScheduleMe.Tab;

partial class DatesLabel
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblDay = new Label();
        lblDate = new Label();
        SuspendLayout();
        // 
        // lblDay
        // 
        lblDay.BackColor = Color.Transparent;
        lblDay.Dock = DockStyle.Top;
        lblDay.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        lblDay.ForeColor = Color.Black;
        lblDay.Location = new Point(0, 0);
        lblDay.Name = "lblDay";
        lblDay.Size = new Size(35, 20);
        lblDay.TabIndex = 0;
        lblDay.Text = "Day";
        lblDay.TextAlign = ContentAlignment.TopCenter;
        // 
        // lblDate
        // 
        lblDate.BackColor = Color.Transparent;
        lblDate.Dock = DockStyle.Bottom;
        lblDate.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        lblDate.ForeColor = Color.Black;
        lblDate.Location = new Point(0, 20);
        lblDate.Name = "lblDate";
        lblDate.Size = new Size(35, 20);
        lblDate.TabIndex = 1;
        lblDate.Text = "12";
        lblDate.TextAlign = ContentAlignment.TopCenter;
        // 
        // DayDates
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White;
        Controls.Add(lblDay);
        Controls.Add(lblDate);
        Name = "DayDates";
        Size = new Size(35, 40);
        ResumeLayout(false);
    }

    #endregion

    private Label lblDay;
    private Label lblDate;
}
