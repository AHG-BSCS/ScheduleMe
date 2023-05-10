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
        lblLine = new Label();
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
        tlPanelDateCell.Dock = DockStyle.Top;
        tlPanelDateCell.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        tlPanelDateCell.Location = new Point(0, 0);
        tlPanelDateCell.Margin = new Padding(0);
        tlPanelDateCell.Name = "tlPanelDateCell";
        tlPanelDateCell.RowCount = 2;
        tlPanelDateCell.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlPanelDateCell.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlPanelDateCell.Size = new Size(47, 30);
        tlPanelDateCell.TabIndex = 1;
        // 
        // lblDate
        // 
        lblDate.AutoSize = true;
        lblDate.Dock = DockStyle.Fill;
        lblDate.Location = new Point(0, 15);
        lblDate.Margin = new Padding(0);
        lblDate.Name = "lblDate";
        lblDate.Size = new Size(47, 15);
        lblDate.TabIndex = 1;
        lblDate.Text = "0";
        lblDate.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblDayName
        // 
        lblDayName.AutoSize = true;
        lblDayName.Dock = DockStyle.Fill;
        lblDayName.Location = new Point(0, 0);
        lblDayName.Margin = new Padding(0);
        lblDayName.Name = "lblDayName";
        lblDayName.Size = new Size(47, 15);
        lblDayName.TabIndex = 0;
        lblDayName.Text = "Day";
        lblDayName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblLine
        // 
        lblLine.BackColor = Color.Gray;
        lblLine.Enabled = false;
        lblLine.Location = new Point(22, 30);
        lblLine.Margin = new Padding(0);
        lblLine.Name = "lblLine";
        lblLine.Size = new Size(1, 250);
        lblLine.TabIndex = 0;
        lblLine.Text = "   ";
        lblLine.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // DateCell
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblLine);
        Controls.Add(tlPanelDateCell);
        Name = "DateCell";
        Size = new Size(47, 289);
        tlPanelDateCell.ResumeLayout(false);
        tlPanelDateCell.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Label lblDate;
    private Label lblDayName;
    public TableLayoutPanel tlPanelDateCell;
    public Label lblLine;
}
