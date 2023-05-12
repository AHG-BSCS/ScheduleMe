namespace ScheduleMe.Tab;

partial class Events
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
        button1 = new Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = Color.Transparent;
        button1.Dock = DockStyle.Fill;
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
        button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
        button1.ForeColor = Color.White;
        button1.Location = new Point(0, 0);
        button1.Name = "button1";
        button1.Size = new Size(68, 30);
        button1.TabIndex = 0;
        button1.Text = "Event";
        button1.UseVisualStyleBackColor = false;
        // 
        // Events
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = Color.FromArgb(15, 76, 129);
        Controls.Add(button1);
        Name = "Events";
        Size = new Size(68, 30);
        ResumeLayout(false);
    }

    #endregion

    private Button button1;
}
