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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.label1 = new System.Windows.Forms.Label();
            this.sundayLbl = new System.Windows.Forms.Label();
            this.mondayLbl = new System.Windows.Forms.Label();
            this.wednesdayLbl = new System.Windows.Forms.Label();
            this.tuesdayLbl = new System.Windows.Forms.Label();
            this.saturdayLbl = new System.Windows.Forms.Label();
            this.fridayLbl = new System.Windows.Forms.Label();
            this.thursdayLbl = new System.Windows.Forms.Label();
            this.calendarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.yearNowLbl = new System.Windows.Forms.Label();
            this.prevYrBtn = new System.Windows.Forms.Button();
            this.nextYrBtn = new System.Windows.Forms.Button();
            this.monthNowLbl = new System.Windows.Forms.Label();
            this.dayNowLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calendar";
            // 
            // sundayLbl
            // 
            this.sundayLbl.AutoSize = true;
            this.sundayLbl.Location = new System.Drawing.Point(260, 167);
            this.sundayLbl.Name = "sundayLbl";
            this.sundayLbl.Size = new System.Drawing.Size(65, 29);
            this.sundayLbl.TabIndex = 7;
            this.sundayLbl.Text = "Sunday";
            // 
            // mondayLbl
            // 
            this.mondayLbl.AutoSize = true;
            this.mondayLbl.Location = new System.Drawing.Point(372, 167);
            this.mondayLbl.Name = "mondayLbl";
            this.mondayLbl.Size = new System.Drawing.Size(70, 29);
            this.mondayLbl.TabIndex = 8;
            this.mondayLbl.Text = "Monday";
            // 
            // wednesdayLbl
            // 
            this.wednesdayLbl.AutoSize = true;
            this.wednesdayLbl.Location = new System.Drawing.Point(584, 167);
            this.wednesdayLbl.Name = "wednesdayLbl";
            this.wednesdayLbl.Size = new System.Drawing.Size(95, 29);
            this.wednesdayLbl.TabIndex = 10;
            this.wednesdayLbl.Text = "Wednesday";
            // 
            // tuesdayLbl
            // 
            this.tuesdayLbl.AutoSize = true;
            this.tuesdayLbl.Location = new System.Drawing.Point(486, 167);
            this.tuesdayLbl.Name = "tuesdayLbl";
            this.tuesdayLbl.Size = new System.Drawing.Size(72, 29);
            this.tuesdayLbl.TabIndex = 9;
            this.tuesdayLbl.Text = "Tuesday";
            // 
            // saturdayLbl
            // 
            this.saturdayLbl.AutoSize = true;
            this.saturdayLbl.Location = new System.Drawing.Point(937, 167);
            this.saturdayLbl.Name = "saturdayLbl";
            this.saturdayLbl.Size = new System.Drawing.Size(76, 29);
            this.saturdayLbl.TabIndex = 13;
            this.saturdayLbl.Text = "Saturday";
            // 
            // fridayLbl
            // 
            this.fridayLbl.AutoSize = true;
            this.fridayLbl.Location = new System.Drawing.Point(829, 167);
            this.fridayLbl.Name = "fridayLbl";
            this.fridayLbl.Size = new System.Drawing.Size(57, 29);
            this.fridayLbl.TabIndex = 12;
            this.fridayLbl.Text = "Friday";
            // 
            // thursdayLbl
            // 
            this.thursdayLbl.AutoSize = true;
            this.thursdayLbl.Location = new System.Drawing.Point(710, 167);
            this.thursdayLbl.Name = "thursdayLbl";
            this.thursdayLbl.Size = new System.Drawing.Size(79, 29);
            this.thursdayLbl.TabIndex = 11;
            this.thursdayLbl.Text = "Thursday";
            // 
            // calendarContainer
            // 
            this.calendarContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarContainer.BackColor = System.Drawing.Color.Transparent;
            this.calendarContainer.Location = new System.Drawing.Point(228, 190);
            this.calendarContainer.Name = "calendarContainer";
            this.calendarContainer.Size = new System.Drawing.Size(817, 633);
            this.calendarContainer.TabIndex = 14;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nextBtn.Image = global::ScheduleMe.Properties.Resources.btnRightArrow;
            this.nextBtn.Location = new System.Drawing.Point(1091, 402);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(63, 67);
            this.nextBtn.TabIndex = 15;
            this.nextBtn.UseVisualStyleBackColor = false;
            // 
            // previousBtn
            // 
            this.previousBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.previousBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousBtn.BackgroundImage")));
            this.previousBtn.Image = global::ScheduleMe.Properties.Resources.btnLeftArrow;
            this.previousBtn.Location = new System.Drawing.Point(82, 404);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(63, 67);
            this.previousBtn.TabIndex = 16;
            this.previousBtn.UseVisualStyleBackColor = false;
            // 
            // yearNowLbl
            // 
            this.yearNowLbl.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearNowLbl.Location = new System.Drawing.Point(466, 18);
            this.yearNowLbl.Name = "yearNowLbl";
            this.yearNowLbl.Size = new System.Drawing.Size(325, 67);
            this.yearNowLbl.TabIndex = 17;
            this.yearNowLbl.Text = "month year";
            this.yearNowLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prevYrBtn
            // 
            this.prevYrBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.prevYrBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prevYrBtn.BackgroundImage")));
            this.prevYrBtn.Image = global::ScheduleMe.Properties.Resources.btnLeftArrow;
            this.prevYrBtn.Location = new System.Drawing.Point(401, 18);
            this.prevYrBtn.Name = "prevYrBtn";
            this.prevYrBtn.Size = new System.Drawing.Size(63, 67);
            this.prevYrBtn.TabIndex = 18;
            this.prevYrBtn.UseVisualStyleBackColor = false;
            // 
            // nextYrBtn
            // 
            this.nextYrBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nextYrBtn.Image = global::ScheduleMe.Properties.Resources.btnRightArrow;
            this.nextYrBtn.Location = new System.Drawing.Point(793, 19);
            this.nextYrBtn.Name = "nextYrBtn";
            this.nextYrBtn.Size = new System.Drawing.Size(63, 67);
            this.nextYrBtn.TabIndex = 19;
            this.nextYrBtn.UseVisualStyleBackColor = false;
            // 
            // monthNowLbl
            // 
            this.monthNowLbl.Font = new System.Drawing.Font("Gill Sans MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthNowLbl.Location = new System.Drawing.Point(228, 111);
            this.monthNowLbl.Name = "monthNowLbl";
            this.monthNowLbl.Size = new System.Drawing.Size(197, 40);
            this.monthNowLbl.TabIndex = 20;
            this.monthNowLbl.Text = "month";
            this.monthNowLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dayNowLbl
            // 
            this.dayNowLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dayNowLbl.Font = new System.Drawing.Font("Gill Sans MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dayNowLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dayNowLbl.Location = new System.Drawing.Point(903, 111);
            this.dayNowLbl.Name = "dayNowLbl";
            this.dayNowLbl.Size = new System.Drawing.Size(64, 40);
            this.dayNowLbl.TabIndex = 21;
            this.dayNowLbl.Text = "day";
            this.dayNowLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1166, 749);
            this.Controls.Add(this.dayNowLbl);
            this.Controls.Add(this.monthNowLbl);
            this.Controls.Add(this.nextYrBtn);
            this.Controls.Add(this.prevYrBtn);
            this.Controls.Add(this.yearNowLbl);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.calendarContainer);
            this.Controls.Add(this.saturdayLbl);
            this.Controls.Add(this.fridayLbl);
            this.Controls.Add(this.thursdayLbl);
            this.Controls.Add(this.wednesdayLbl);
            this.Controls.Add(this.tuesdayLbl);
            this.Controls.Add(this.mondayLbl);
            this.Controls.Add(this.sundayLbl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calendar_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    private Label yearNowLbl;
    private Button prevYrBtn;
    private Button nextYrBtn;
    private Label monthNowLbl;
    private Label dayNowLbl;
    private System.Windows.Forms.Timer timer1;
}