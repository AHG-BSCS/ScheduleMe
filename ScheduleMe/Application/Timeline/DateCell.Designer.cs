namespace ScheduleMe.Tab;

partial class DateCell
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
        tlPanelDateCell = new TableLayoutPanel();
        lblDate = new Label();
        lblDayName = new Label();
        tlPanelDateCell.SuspendLayout();
        SuspendLayout();
        // 
        // tlPanelDateCell
        // 
        tlPanelDateCell.ColumnCount = 1;
        tlPanelDateCell.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlPanelDateCell.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlPanelDateCell.Controls.Add(lblDate, 0, 1);
        tlPanelDateCell.Controls.Add(lblDayName, 0, 0);
        tlPanelDateCell.Location = new Point(30, 32);
        tlPanelDateCell.Name = "tlPanelDateCell";
        tlPanelDateCell.RowCount = 2;
        tlPanelDateCell.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlPanelDateCell.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlPanelDateCell.Size = new Size(46, 64);
        tlPanelDateCell.TabIndex = 1;
        // 
        // lblDate
        // 
        lblDate.AutoSize = true;
        lblDate.Dock = DockStyle.Fill;
        lblDate.Location = new Point(3, 32);
        lblDate.Name = "lblDate";
        lblDate.Size = new Size(40, 32);
        lblDate.TabIndex = 1;
        lblDate.Text = "10";
        lblDate.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblDayName
        // 
        lblDayName.AutoSize = true;
        lblDayName.Dock = DockStyle.Fill;
        lblDayName.Location = new Point(3, 0);
        lblDayName.Name = "lblDayName";
        lblDayName.Size = new Size(40, 32);
        lblDayName.TabIndex = 0;
        lblDayName.Text = "Wed";
        lblDayName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // DateCell
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tlPanelDateCell);
        Name = "DateCell";
        Size = new Size(116, 146);
        tlPanelDateCell.ResumeLayout(false);
        tlPanelDateCell.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tlPanelDateCell;
    private Label lblDate;
    private Label lblDayName;
}
