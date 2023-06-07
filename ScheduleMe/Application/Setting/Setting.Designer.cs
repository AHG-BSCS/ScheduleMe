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
        checkBox1 = new CheckBox();
        SuspendLayout();
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(11, 11);
        checkBox1.Margin = new Padding(2);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(84, 19);
        checkBox1.TabIndex = 2;
        checkBox1.Text = "Dark Mode";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // Setting
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(834, 511);
        Controls.Add(checkBox1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Setting";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Setting";
        TopMost = true;
        Load += Setting_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private CheckBox checkBox1;
}