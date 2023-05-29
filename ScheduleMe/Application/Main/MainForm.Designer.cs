namespace ScheduleMe
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sideNavPanel = new Panel();
            btnSettingWindow = new Button();
            btnAboutWindow = new Button();
            btnWeatherTab = new Button();
            btnNoteTab = new Button();
            btnTimetableTab = new Button();
            btnTimelineTab = new Button();
            btnCalendarTab = new Button();
            tabPanel = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            sideNavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // sideNavPanel
            // 
            sideNavPanel.BackColor = Color.FromArgb(15, 76, 129);
            sideNavPanel.Controls.Add(panel5);
            sideNavPanel.Controls.Add(panel4);
            sideNavPanel.Controls.Add(panel3);
            sideNavPanel.Controls.Add(panel2);
            sideNavPanel.Controls.Add(panel1);
            sideNavPanel.Controls.Add(btnSettingWindow);
            sideNavPanel.Controls.Add(btnAboutWindow);
            sideNavPanel.Dock = DockStyle.Left;
            sideNavPanel.Location = new Point(0, 0);
            sideNavPanel.Margin = new Padding(3, 2, 3, 2);
            sideNavPanel.Name = "sideNavPanel";
            sideNavPanel.Padding = new Padding(0, 35, 0, 10);
            sideNavPanel.Size = new Size(140, 550);
            sideNavPanel.TabIndex = 0;
            // 
            // btnSettingWindow
            // 
            btnSettingWindow.Dock = DockStyle.Bottom;
            btnSettingWindow.FlatAppearance.BorderSize = 0;
            btnSettingWindow.FlatStyle = FlatStyle.Flat;
            btnSettingWindow.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettingWindow.ForeColor = Color.White;
            btnSettingWindow.Location = new Point(0, 452);
            btnSettingWindow.Margin = new Padding(3, 2, 3, 2);
            btnSettingWindow.Name = "btnSettingWindow";
            btnSettingWindow.Size = new Size(140, 44);
            btnSettingWindow.TabIndex = 5;
            btnSettingWindow.Text = "          Setting";
            btnSettingWindow.TextAlign = ContentAlignment.MiddleLeft;
            btnSettingWindow.UseVisualStyleBackColor = true;
            btnSettingWindow.Click += btnSettingWindow_Click;
            // 
            // btnAboutWindow
            // 
            btnAboutWindow.Dock = DockStyle.Bottom;
            btnAboutWindow.FlatAppearance.BorderSize = 0;
            btnAboutWindow.FlatStyle = FlatStyle.Flat;
            btnAboutWindow.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAboutWindow.ForeColor = Color.White;
            btnAboutWindow.Location = new Point(0, 496);
            btnAboutWindow.Margin = new Padding(3, 2, 3, 2);
            btnAboutWindow.Name = "btnAboutWindow";
            btnAboutWindow.Size = new Size(140, 44);
            btnAboutWindow.TabIndex = 6;
            btnAboutWindow.Text = "          About";
            btnAboutWindow.TextAlign = ContentAlignment.MiddleLeft;
            btnAboutWindow.UseVisualStyleBackColor = true;
            btnAboutWindow.Click += btnAboutWindow_Click;
            // 
            // btnWeatherTab
            // 
            btnWeatherTab.Dock = DockStyle.Left;
            btnWeatherTab.FlatAppearance.BorderSize = 0;
            btnWeatherTab.FlatStyle = FlatStyle.Flat;
            btnWeatherTab.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnWeatherTab.ForeColor = Color.White;
            btnWeatherTab.Location = new Point(43, 8);
            btnWeatherTab.Margin = new Padding(3, 2, 3, 2);
            btnWeatherTab.Name = "btnWeatherTab";
            btnWeatherTab.Size = new Size(140, 28);
            btnWeatherTab.TabIndex = 4;
            btnWeatherTab.Text = "Weather";
            btnWeatherTab.TextAlign = ContentAlignment.MiddleLeft;
            btnWeatherTab.UseVisualStyleBackColor = true;
            btnWeatherTab.Click += btnWeatherTab_Click;
            // 
            // btnNoteTab
            // 
            btnNoteTab.Dock = DockStyle.Left;
            btnNoteTab.FlatAppearance.BorderSize = 0;
            btnNoteTab.FlatStyle = FlatStyle.Flat;
            btnNoteTab.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNoteTab.ForeColor = Color.White;
            btnNoteTab.Location = new Point(43, 8);
            btnNoteTab.Margin = new Padding(3, 2, 3, 2);
            btnNoteTab.Name = "btnNoteTab";
            btnNoteTab.Size = new Size(140, 28);
            btnNoteTab.TabIndex = 3;
            btnNoteTab.Text = "Note";
            btnNoteTab.TextAlign = ContentAlignment.MiddleLeft;
            btnNoteTab.UseVisualStyleBackColor = true;
            btnNoteTab.Click += btnNoteTab_Click;
            // 
            // btnTimetableTab
            // 
            btnTimetableTab.Dock = DockStyle.Left;
            btnTimetableTab.FlatAppearance.BorderSize = 0;
            btnTimetableTab.FlatStyle = FlatStyle.Flat;
            btnTimetableTab.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimetableTab.ForeColor = Color.White;
            btnTimetableTab.Location = new Point(43, 8);
            btnTimetableTab.Margin = new Padding(3, 2, 3, 2);
            btnTimetableTab.Name = "btnTimetableTab";
            btnTimetableTab.Size = new Size(140, 28);
            btnTimetableTab.TabIndex = 2;
            btnTimetableTab.Text = "Timetable";
            btnTimetableTab.TextAlign = ContentAlignment.MiddleLeft;
            btnTimetableTab.UseVisualStyleBackColor = true;
            btnTimetableTab.Click += btnTimetableTab_Click;
            // 
            // btnTimelineTab
            // 
            btnTimelineTab.Dock = DockStyle.Left;
            btnTimelineTab.FlatAppearance.BorderSize = 0;
            btnTimelineTab.FlatStyle = FlatStyle.Flat;
            btnTimelineTab.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimelineTab.ForeColor = Color.White;
            btnTimelineTab.Location = new Point(43, 8);
            btnTimelineTab.Margin = new Padding(3, 2, 3, 2);
            btnTimelineTab.Name = "btnTimelineTab";
            btnTimelineTab.Size = new Size(140, 28);
            btnTimelineTab.TabIndex = 1;
            btnTimelineTab.Text = "Timeline";
            btnTimelineTab.TextAlign = ContentAlignment.MiddleLeft;
            btnTimelineTab.UseVisualStyleBackColor = true;
            btnTimelineTab.Click += btnTimelineTab_Click;
            // 
            // btnCalendarTab
            // 
            btnCalendarTab.BackgroundImageLayout = ImageLayout.Zoom;
            btnCalendarTab.Dock = DockStyle.Left;
            btnCalendarTab.FlatAppearance.BorderSize = 0;
            btnCalendarTab.FlatStyle = FlatStyle.Flat;
            btnCalendarTab.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalendarTab.ForeColor = Color.White;
            btnCalendarTab.Location = new Point(43, 8);
            btnCalendarTab.Margin = new Padding(3, 2, 3, 2);
            btnCalendarTab.Name = "btnCalendarTab";
            btnCalendarTab.RightToLeft = RightToLeft.No;
            btnCalendarTab.Size = new Size(97, 28);
            btnCalendarTab.TabIndex = 0;
            btnCalendarTab.Text = "Calendar";
            btnCalendarTab.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendarTab.UseVisualStyleBackColor = true;
            btnCalendarTab.Click += btnCalendarTab_Click;
            // 
            // tabPanel
            // 
            tabPanel.AutoScroll = true;
            tabPanel.BackColor = Color.White;
            tabPanel.Dock = DockStyle.Fill;
            tabPanel.Location = new Point(140, 0);
            tabPanel.Name = "tabPanel";
            tabPanel.Size = new Size(850, 550);
            tabPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(5, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 28);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnCalendarTab);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 8, 0, 8);
            panel1.Size = new Size(140, 44);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnTimelineTab);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5, 8, 0, 8);
            panel2.Size = new Size(140, 44);
            panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Location = new Point(5, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 28);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btnTimetableTab);
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(0, 123);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5, 8, 0, 8);
            panel3.Size = new Size(140, 44);
            panel3.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Location = new Point(5, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 28);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(btnNoteTab);
            panel4.Controls.Add(pictureBox4);
            panel4.Dock = DockStyle.Top;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(0, 167);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5, 8, 0, 8);
            panel4.Size = new Size(140, 44);
            panel4.TabIndex = 9;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Location = new Point(5, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 28);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(btnWeatherTab);
            panel5.Controls.Add(pictureBox5);
            panel5.Dock = DockStyle.Top;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(0, 211);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5, 8, 0, 8);
            panel5.Size = new Size(140, 44);
            panel5.TabIndex = 10;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Dock = DockStyle.Left;
            pictureBox5.Location = new Point(5, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 28);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(990, 550);
            Controls.Add(tabPanel);
            Controls.Add(sideNavPanel);
            Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "ScheduleMe";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            sideNavPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnNoteTab;
        private Button btnTimetableTab;
        private Button btnCalendarTab;
        private Button btnTimelineTab;
        private Button btnWeatherTab;
        private Button btnAboutWindow;
        public Button btnSettingWindow;
        public Panel sideNavPanel;
        public Panel tabPanel;
        private PictureBox pictureBox1;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}