namespace ScheduleMe.Tab;

partial class Setting
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
        label1 = new Label();
        checkBox1 = new CheckBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(44, 15);
        label1.TabIndex = 1;
        label1.Text = "Setting";
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(12, 50);
        checkBox1.Margin = new Padding(2, 2, 2, 2);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(84, 19);
        checkBox1.TabIndex = 2;
        checkBox1.Text = "Dark Mode";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // Setting
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White;
        ClientSize = new Size(834, 511);
        Controls.Add(checkBox1);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Setting";
        Text = "Setting";
        TopMost = true;
        FormClosed += Setting_FormClosed;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private CheckBox checkBox1;
}