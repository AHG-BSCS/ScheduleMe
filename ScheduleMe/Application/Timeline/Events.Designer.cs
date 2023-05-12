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
        eventName = new Button();
        SuspendLayout();
        // 
        // eventName
        // 
        eventName.BackColor = Color.Transparent;
        eventName.Dock = DockStyle.Fill;
        eventName.FlatAppearance.BorderSize = 0;
        eventName.FlatAppearance.MouseDownBackColor = Color.Transparent;
        eventName.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        eventName.FlatStyle = FlatStyle.Flat;
        eventName.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
        eventName.ForeColor = Color.White;
        eventName.Location = new Point(0, 0);
        eventName.Name = "eventName";
        eventName.Size = new Size(68, 30);
        eventName.TabIndex = 0;
        eventName.Text = "Event";
        eventName.UseVisualStyleBackColor = false;
        // 
        // Events
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = Color.FromArgb(15, 76, 129);
        Controls.Add(eventName);
        Name = "Events";
        Size = new Size(68, 30);
        ResumeLayout(false);
    }

    #endregion

    private Button eventName;
}
