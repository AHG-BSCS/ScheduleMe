namespace ScheduleMe.Tab;

partial class Calendar
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
        flowLayoutPanel1 = new FlowLayoutPanel();
        nextMonthBtn = new Button();
        previousMonthBtn = new Button();
        label2 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(57, 22);
        label1.TabIndex = 2;
        label1.Text = "Calendar";
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flowLayoutPanel1.Location = new Point(56, 141);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(825, 397);
        flowLayoutPanel1.TabIndex = 3;
        // 
        // nextMonthBtn
        // 
        nextMonthBtn.Location = new Point(895, 311);
        nextMonthBtn.Name = "nextMonthBtn";
        nextMonthBtn.Size = new Size(31, 53);
        nextMonthBtn.TabIndex = 4;
        nextMonthBtn.Text = "button1";
        nextMonthBtn.UseVisualStyleBackColor = true;
        // 
        // previousMonthBtn
        // 
        previousMonthBtn.Location = new Point(12, 311);
        previousMonthBtn.Name = "previousMonthBtn";
        previousMonthBtn.Size = new Size(31, 53);
        previousMonthBtn.TabIndex = 6;
        previousMonthBtn.Text = "button1";
        previousMonthBtn.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(99, 93);
        label2.Name = "label2";
        label2.Size = new Size(42, 22);
        label2.TabIndex = 7;
        label2.Text = "label2";
        label2.Click += label2_Click;
        // 
        // Calendar
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White;
        ClientSize = new Size(938, 550);
        Controls.Add(label2);
        Controls.Add(previousMonthBtn);
        Controls.Add(nextMonthBtn);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(label1);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4);
        Name = "Calendar";
        Text = "Calendar";
        WindowState = FormWindowState.Maximized;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button nextMonthBtn;
    private Button previousMonthBtn;
    private Label label2;
}