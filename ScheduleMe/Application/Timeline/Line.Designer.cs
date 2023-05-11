namespace ScheduleMe.Tab;

partial class Line
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
        lblLine = new Label();
        SuspendLayout();
        // 
        // lblLine
        // 
        lblLine.BackColor = Color.Gray;
        lblLine.Enabled = false;
        lblLine.Location = new Point(23, 0);
        lblLine.Margin = new Padding(0);
        lblLine.Name = "lblLine";
        lblLine.Size = new Size(1, 250);
        lblLine.TabIndex = 1;
        lblLine.Text = "   ";
        lblLine.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Line
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblLine);
        Name = "Line";
        Size = new Size(47, 289);
        ResumeLayout(false);
    }

    #endregion

    public Label lblLine;
}
