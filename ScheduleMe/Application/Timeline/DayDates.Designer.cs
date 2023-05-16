namespace ScheduleMe.Tab;

partial class DayDates
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
        lblDay.Dock = DockStyle.Top;
        lblDay.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        lblDay.ForeColor = Color.Black;
        lblDay.Location = new Point(0, 0);
        lblDay.Name = "lblDay";
        lblDay.Size = new Size(47, 30);
        lblDay.TabIndex = 0;
        lblDay.Text = "Day";
        lblDay.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblDate
        // 
        lblDate.Dock = DockStyle.Top;
        lblDate.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        lblDate.ForeColor = Color.Black;
        lblDate.Location = new Point(0, 30);
        lblDate.Name = "lblDate";
        lblDate.Size = new Size(47, 15);
        lblDate.TabIndex = 1;
        lblDate.Text = "12";
        lblDate.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // DayDates
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Transparent;
        Controls.Add(lblDate);
        Controls.Add(lblDay);
        Name = "DayDates";
        Size = new Size(47, 66);
        ResumeLayout(false);
    }

    #endregion

    private Label lblDay;
    private Label lblDate;
}
