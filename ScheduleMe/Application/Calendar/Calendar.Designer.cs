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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
        label1 = new Label();
        sundayLbl = new Label();
        mondayLbl = new Label();
        wednesdayLbl = new Label();
        tuesdayLbl = new Label();
        saturdayLbl = new Label();
        fridayLbl = new Label();
        thursdayLbl = new Label();
        calendarContainer = new FlowLayoutPanel();
        nextBtn = new Button();
        previousBtn = new Button();
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
        // sundayLbl
        // 
        sundayLbl.AutoSize = true;
        sundayLbl.Location = new Point(260, 101);
        sundayLbl.Name = "sundayLbl";
        sundayLbl.Size = new Size(50, 22);
        sundayLbl.TabIndex = 7;
        sundayLbl.Text = "Sunday";
        // 
        // mondayLbl
        // 
        mondayLbl.AutoSize = true;
        mondayLbl.Location = new Point(372, 101);
        mondayLbl.Name = "mondayLbl";
        mondayLbl.Size = new Size(54, 22);
        mondayLbl.TabIndex = 8;
        mondayLbl.Text = "Monday";
        // 
        // wednesdayLbl
        // 
        wednesdayLbl.AutoSize = true;
        wednesdayLbl.Location = new Point(587, 101);
        wednesdayLbl.Name = "wednesdayLbl";
        wednesdayLbl.Size = new Size(72, 22);
        wednesdayLbl.TabIndex = 10;
        wednesdayLbl.Text = "Wednesday";
        // 
        // tuesdayLbl
        // 
        tuesdayLbl.AutoSize = true;
        tuesdayLbl.Location = new Point(486, 101);
        tuesdayLbl.Name = "tuesdayLbl";
        tuesdayLbl.Size = new Size(55, 22);
        tuesdayLbl.TabIndex = 9;
        tuesdayLbl.Text = "Tuesday";
        // 
        // saturdayLbl
        // 
        saturdayLbl.AutoSize = true;
        saturdayLbl.Location = new Point(937, 101);
        saturdayLbl.Name = "saturdayLbl";
        saturdayLbl.Size = new Size(59, 22);
        saturdayLbl.TabIndex = 13;
        saturdayLbl.Text = "Saturday";
        // 
        // fridayLbl
        // 
        fridayLbl.AutoSize = true;
        fridayLbl.Location = new Point(829, 101);
        fridayLbl.Name = "fridayLbl";
        fridayLbl.Size = new Size(44, 22);
        fridayLbl.TabIndex = 12;
        fridayLbl.Text = "Friday";
        // 
        // thursdayLbl
        // 
        thursdayLbl.AutoSize = true;
        thursdayLbl.Location = new Point(710, 101);
        thursdayLbl.Name = "thursdayLbl";
        thursdayLbl.Size = new Size(61, 22);
        thursdayLbl.TabIndex = 11;
        thursdayLbl.Text = "Thursday";
        // 
        // calendarContainer
        // 
        calendarContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        calendarContainer.BackColor = Color.Transparent;
        calendarContainer.Location = new Point(228, 143);
        calendarContainer.Name = "calendarContainer";
        calendarContainer.Size = new Size(817, 594);
        calendarContainer.TabIndex = 14;
        // 
        // nextBtn
        // 
        nextBtn.BackColor = SystemColors.ButtonFace;
        nextBtn.Image = Properties.Resources.right_arrow;
        nextBtn.Location = new Point(1091, 350);
        nextBtn.Name = "nextBtn";
        nextBtn.Size = new Size(63, 67);
        nextBtn.TabIndex = 15;
        nextBtn.UseVisualStyleBackColor = false;
        nextBtn.Click += nextBtn_Click;
        // 
        // previousBtn
        // 
        previousBtn.BackColor = SystemColors.ButtonFace;
        previousBtn.BackgroundImage = (Image)resources.GetObject("previousBtn.BackgroundImage");
        previousBtn.Image = Properties.Resources.left_arrow;
        previousBtn.Location = new Point(82, 350);
        previousBtn.Name = "previousBtn";
        previousBtn.Size = new Size(63, 67);
        previousBtn.TabIndex = 16;
        previousBtn.UseVisualStyleBackColor = false;
        previousBtn.Click += previousBtn_Click;
        // 
        // Calendar
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1166, 749);
        Controls.Add(previousBtn);
        Controls.Add(nextBtn);
        Controls.Add(calendarContainer);
        Controls.Add(saturdayLbl);
        Controls.Add(fridayLbl);
        Controls.Add(thursdayLbl);
        Controls.Add(wednesdayLbl);
        Controls.Add(tuesdayLbl);
        Controls.Add(mondayLbl);
        Controls.Add(sundayLbl);
        Controls.Add(label1);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4);
        Name = "Calendar";
        Text = "Calendar";
        WindowState = FormWindowState.Maximized;
        Load += Calendar_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label sundayLbl;
    private Label mondayLbl;
    private Label wednesdayLbl;
    private Label tuesdayLbl;
    private Label saturdayLbl;
    private Label fridayLbl;
    private Label thursdayLbl;
    private FlowLayoutPanel calendarContainer;
    private Button nextBtn;
    private Button previousBtn;
}