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
            btnSetting = new Button();
            btnWeather = new Button();
            btnNote = new Button();
            btnTimetable = new Button();
            btnTimeline = new Button();
            btnCalendar = new Button();
            btnAbout = new Button();
            tabPanel = new Panel();
            sideNavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sideNavPanel
            // 
            sideNavPanel.BackColor = Color.FromArgb(15, 76, 129);
            sideNavPanel.Controls.Add(btnSetting);
            sideNavPanel.Controls.Add(btnWeather);
            sideNavPanel.Controls.Add(btnNote);
            sideNavPanel.Controls.Add(btnTimetable);
            sideNavPanel.Controls.Add(btnTimeline);
            sideNavPanel.Controls.Add(btnCalendar);
            sideNavPanel.Controls.Add(btnAbout);
            sideNavPanel.Dock = DockStyle.Left;
            sideNavPanel.Location = new Point(0, 0);
            sideNavPanel.Margin = new Padding(3, 2, 3, 2);
            sideNavPanel.Name = "sideNavPanel";
            sideNavPanel.Padding = new Padding(0, 28, 0, 10);
            sideNavPanel.Size = new Size(164, 550);
            sideNavPanel.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.Transparent;
            btnSetting.BackgroundImage = Properties.Resources.tabSetting;
            btnSetting.BackgroundImageLayout = ImageLayout.Zoom;
            btnSetting.Cursor = Cursors.Hand;
            btnSetting.Dock = DockStyle.Bottom;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSetting.ForeColor = Color.White;
            btnSetting.Location = new Point(0, 452);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(164, 44);
            btnSetting.TabIndex = 5;
            btnSetting.TabStop = false;
            btnSetting.Text = "                  Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnWeather
            // 
            btnWeather.BackColor = Color.Transparent;
            btnWeather.BackgroundImage = Properties.Resources.tabWeather;
            btnWeather.BackgroundImageLayout = ImageLayout.Zoom;
            btnWeather.Cursor = Cursors.Hand;
            btnWeather.Dock = DockStyle.Top;
            btnWeather.FlatAppearance.BorderSize = 0;
            btnWeather.FlatStyle = FlatStyle.Flat;
            btnWeather.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnWeather.ForeColor = Color.White;
            btnWeather.Location = new Point(0, 203);
            btnWeather.Name = "btnWeather";
            btnWeather.Size = new Size(164, 44);
            btnWeather.TabIndex = 4;
            btnWeather.TabStop = false;
            btnWeather.Text = "                  Weather";
            btnWeather.TextAlign = ContentAlignment.MiddleLeft;
            btnWeather.UseVisualStyleBackColor = false;
            btnWeather.Click += btnWeather_Click;
            // 
            // btnNote
            // 
            btnNote.BackColor = Color.Transparent;
            btnNote.BackgroundImage = Properties.Resources.tabNote;
            btnNote.BackgroundImageLayout = ImageLayout.Zoom;
            btnNote.Cursor = Cursors.Hand;
            btnNote.Dock = DockStyle.Top;
            btnNote.FlatAppearance.BorderSize = 0;
            btnNote.FlatStyle = FlatStyle.Flat;
            btnNote.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNote.ForeColor = Color.White;
            btnNote.Location = new Point(0, 159);
            btnNote.Name = "btnNote";
            btnNote.Size = new Size(164, 44);
            btnNote.TabIndex = 3;
            btnNote.TabStop = false;
            btnNote.Text = "                  Note";
            btnNote.TextAlign = ContentAlignment.MiddleLeft;
            btnNote.UseVisualStyleBackColor = false;
            btnNote.Click += btnNote_Click;
            // 
            // btnTimetable
            // 
            btnTimetable.BackColor = Color.Transparent;
            btnTimetable.BackgroundImage = Properties.Resources.tabTimetable;
            btnTimetable.BackgroundImageLayout = ImageLayout.Zoom;
            btnTimetable.Cursor = Cursors.Hand;
            btnTimetable.Dock = DockStyle.Top;
            btnTimetable.FlatAppearance.BorderSize = 0;
            btnTimetable.FlatStyle = FlatStyle.Flat;
            btnTimetable.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimetable.ForeColor = Color.White;
            btnTimetable.Location = new Point(0, 115);
            btnTimetable.Name = "btnTimetable";
            btnTimetable.Size = new Size(164, 44);
            btnTimetable.TabIndex = 2;
            btnTimetable.TabStop = false;
            btnTimetable.Text = "                  Timetable";
            btnTimetable.TextAlign = ContentAlignment.MiddleLeft;
            btnTimetable.UseVisualStyleBackColor = false;
            btnTimetable.Click += btnTimetable_Click;
            // 
            // btnTimeline
            // 
            btnTimeline.BackColor = Color.Transparent;
            btnTimeline.BackgroundImage = Properties.Resources.tabTimeline;
            btnTimeline.BackgroundImageLayout = ImageLayout.Zoom;
            btnTimeline.Cursor = Cursors.Hand;
            btnTimeline.Dock = DockStyle.Top;
            btnTimeline.FlatAppearance.BorderSize = 0;
            btnTimeline.FlatStyle = FlatStyle.Flat;
            btnTimeline.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimeline.ForeColor = Color.White;
            btnTimeline.Location = new Point(0, 71);
            btnTimeline.Name = "btnTimeline";
            btnTimeline.Size = new Size(164, 44);
            btnTimeline.TabIndex = 1;
            btnTimeline.TabStop = false;
            btnTimeline.Text = "                  Timeline";
            btnTimeline.TextAlign = ContentAlignment.MiddleLeft;
            btnTimeline.UseVisualStyleBackColor = false;
            btnTimeline.Click += btnTimeline_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.Transparent;
            btnCalendar.BackgroundImage = Properties.Resources.tabCalendar;
            btnCalendar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCalendar.Cursor = Cursors.Hand;
            btnCalendar.Dock = DockStyle.Top;
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalendar.ForeColor = Color.White;
            btnCalendar.Location = new Point(0, 28);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(164, 43);
            btnCalendar.TabIndex = 0;
            btnCalendar.TabStop = false;
            btnCalendar.Text = "                  Calendar";
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.Transparent;
            btnAbout.BackgroundImage = Properties.Resources.tabAbout;
            btnAbout.BackgroundImageLayout = ImageLayout.Zoom;
            btnAbout.Cursor = Cursors.Hand;
            btnAbout.Dock = DockStyle.Bottom;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbout.ForeColor = Color.White;
            btnAbout.Location = new Point(0, 496);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(164, 44);
            btnAbout.TabIndex = 6;
            btnAbout.TabStop = false;
            btnAbout.Text = "                  About";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // tabPanel
            // 
            tabPanel.AutoScroll = true;
            tabPanel.BackColor = Color.White;
            tabPanel.Dock = DockStyle.Fill;
            tabPanel.Location = new Point(164, 0);
            tabPanel.Name = "tabPanel";
            tabPanel.Size = new Size(826, 550);
            tabPanel.TabIndex = 0;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScheduleMe";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            sideNavPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public Panel sideNavPanel;
        public Panel tabPanel;
        private Button btnCalendar;
        private Button btnNote;
        private Button btnTimetable;
        private Button btnTimeline;
        private Button btnAbout;
        private Button btnSetting;
        private Button btnWeather;
    }
}