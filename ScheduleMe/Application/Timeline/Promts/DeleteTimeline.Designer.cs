namespace ScheduleMe.Tab;

partial class DeleteTimeline
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
        yesBtn = new Button();
        button1 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = Color.White;
        label1.Location = new Point(28, 5);
        label1.Name = "label1";
        label1.Size = new Size(89, 22);
        label1.TabIndex = 0;
        label1.Text = "Are You Sure?";
        // 
        // yesBtn
        // 
        yesBtn.BackColor = Color.FromArgb(255, 128, 128);
        yesBtn.FlatAppearance.BorderSize = 0;
        yesBtn.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        yesBtn.Location = new Point(12, 30);
        yesBtn.Name = "yesBtn";
        yesBtn.Size = new Size(55, 30);
        yesBtn.TabIndex = 0;
        yesBtn.TabStop = false;
        yesBtn.Text = "Yes";
        yesBtn.UseVisualStyleBackColor = false;
        yesBtn.Click += yesBtn_Click;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(128, 255, 128);
        button1.FlatAppearance.BorderSize = 0;
        button1.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        button1.Location = new Point(73, 30);
        button1.Name = "button1";
        button1.Size = new Size(55, 30);
        button1.TabIndex = 1;
        button1.TabStop = false;
        button1.Text = "No";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // DeleteTimeline
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(15, 76, 129);
        ClientSize = new Size(141, 72);
        Controls.Add(button1);
        Controls.Add(yesBtn);
        Controls.Add(label1);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 4, 3, 4);
        Name = "DeleteTimeline";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button yesBtn;
    private Button button1;
}