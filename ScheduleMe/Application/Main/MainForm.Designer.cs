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
            pnlSettingBtn = new Panel();
            btnSettingWindow = new Button();
            picSetting = new PictureBox();
            pnlWeatherBtn = new Panel();
            btnWeatherTab = new Button();
            picWeather = new PictureBox();
            pnlNoteBtn = new Panel();
            btnNoteTab = new Button();
            picNote = new PictureBox();
            pnlTimetableBtn = new Panel();
            btnTimetableTab = new Button();
            picTimetable = new PictureBox();
            pnlTimelineBtn = new Panel();
            btnTimelineTab = new Button();
            picTimeline = new PictureBox();
            pnlCalendarBtn = new Panel();
            btnCalendarTab = new Button();
            picCalendar = new PictureBox();
            pnlAboutBtn = new Panel();
            btnAboutWindow = new Button();
            picAbout = new PictureBox();
            tabPanel = new Panel();
            sideNavPanel.SuspendLayout();
            pnlSettingBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSetting).BeginInit();
            pnlWeatherBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWeather).BeginInit();
            pnlNoteBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNote).BeginInit();
            pnlTimetableBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimetable).BeginInit();
            pnlTimelineBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimeline).BeginInit();
            pnlCalendarBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCalendar).BeginInit();
            pnlAboutBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAbout).BeginInit();
            SuspendLayout();
            // 
            // sideNavPanel
            // 
            sideNavPanel.BackColor = Color.FromArgb(15, 76, 129);
            sideNavPanel.Controls.Add(pnlSettingBtn);
            sideNavPanel.Controls.Add(pnlWeatherBtn);
            sideNavPanel.Controls.Add(pnlNoteBtn);
            sideNavPanel.Controls.Add(pnlTimetableBtn);
            sideNavPanel.Controls.Add(pnlTimelineBtn);
            sideNavPanel.Controls.Add(pnlCalendarBtn);
            sideNavPanel.Controls.Add(pnlAboutBtn);
            sideNavPanel.Dock = DockStyle.Left;
            sideNavPanel.Location = new Point(0, 0);
            sideNavPanel.Margin = new Padding(3, 2, 3, 2);
            sideNavPanel.Name = "sideNavPanel";
            sideNavPanel.Padding = new Padding(0, 28, 0, 10);
            sideNavPanel.Size = new Size(140, 550);
            sideNavPanel.TabIndex = 0;
            // 
            // pnlSettingBtn
            // 
            pnlSettingBtn.BackColor = Color.Transparent;
            pnlSettingBtn.Controls.Add(btnSettingWindow);
            pnlSettingBtn.Controls.Add(picSetting);
            pnlSettingBtn.Dock = DockStyle.Bottom;
            pnlSettingBtn.ForeColor = Color.White;
            pnlSettingBtn.Location = new Point(0, 452);
            pnlSettingBtn.Name = "pnlSettingBtn";
            pnlSettingBtn.Padding = new Padding(5, 8, 0, 8);
            pnlSettingBtn.Size = new Size(140, 44);
            pnlSettingBtn.TabIndex = 0;
            pnlSettingBtn.Click += pnlSettingBtn_Click;
            // 
            // btnSettingWindow
            // 
            btnSettingWindow.Dock = DockStyle.Left;
            btnSettingWindow.FlatAppearance.BorderSize = 0;
            btnSettingWindow.FlatStyle = FlatStyle.Flat;
            btnSettingWindow.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettingWindow.ForeColor = Color.White;
            btnSettingWindow.Location = new Point(43, 8);
            btnSettingWindow.Margin = new Padding(3, 2, 3, 2);
            btnSettingWindow.Name = "btnSettingWindow";
            btnSettingWindow.Size = new Size(94, 28);
            btnSettingWindow.TabIndex = 5;
            btnSettingWindow.Text = "Setting";
            btnSettingWindow.TextAlign = ContentAlignment.MiddleLeft;
            btnSettingWindow.UseVisualStyleBackColor = true;
            // 
            // picSetting
            // 
            picSetting.BackgroundImage = Properties.Resources.Setting;
            picSetting.BackgroundImageLayout = ImageLayout.Zoom;
            picSetting.Dock = DockStyle.Left;
            picSetting.Location = new Point(5, 8);
            picSetting.Name = "picSetting";
            picSetting.Size = new Size(38, 28);
            picSetting.TabIndex = 0;
            picSetting.TabStop = false;
            // 
            // pnlWeatherBtn
            // 
            pnlWeatherBtn.BackColor = Color.Transparent;
            pnlWeatherBtn.Controls.Add(btnWeatherTab);
            pnlWeatherBtn.Controls.Add(picWeather);
            pnlWeatherBtn.Dock = DockStyle.Top;
            pnlWeatherBtn.ForeColor = Color.White;
            pnlWeatherBtn.Location = new Point(0, 204);
            pnlWeatherBtn.Name = "pnlWeatherBtn";
            pnlWeatherBtn.Padding = new Padding(5, 8, 0, 8);
            pnlWeatherBtn.Size = new Size(140, 44);
            pnlWeatherBtn.TabIndex = 0;
            pnlWeatherBtn.Click += pnlWeatherBtn_Click;
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
            btnWeatherTab.Size = new Size(97, 28);
            btnWeatherTab.TabIndex = 4;
            btnWeatherTab.Text = "Weather";
            btnWeatherTab.TextAlign = ContentAlignment.MiddleLeft;
            btnWeatherTab.UseVisualStyleBackColor = true;
            // 
            // picWeather
            // 
            picWeather.BackgroundImage = Properties.Resources.Weather;
            picWeather.BackgroundImageLayout = ImageLayout.Zoom;
            picWeather.Dock = DockStyle.Left;
            picWeather.Location = new Point(5, 8);
            picWeather.Name = "picWeather";
            picWeather.Size = new Size(38, 28);
            picWeather.TabIndex = 0;
            picWeather.TabStop = false;
            // 
            // pnlNoteBtn
            // 
            pnlNoteBtn.BackColor = Color.Transparent;
            pnlNoteBtn.Controls.Add(btnNoteTab);
            pnlNoteBtn.Controls.Add(picNote);
            pnlNoteBtn.Dock = DockStyle.Top;
            pnlNoteBtn.ForeColor = Color.White;
            pnlNoteBtn.Location = new Point(0, 160);
            pnlNoteBtn.Name = "pnlNoteBtn";
            pnlNoteBtn.Padding = new Padding(5, 8, 0, 8);
            pnlNoteBtn.Size = new Size(140, 44);
            pnlNoteBtn.TabIndex = 0;
            pnlNoteBtn.Click += pnlNoteBtn_Click;
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
            btnNoteTab.Size = new Size(97, 28);
            btnNoteTab.TabIndex = 3;
            btnNoteTab.Text = "Note";
            btnNoteTab.TextAlign = ContentAlignment.MiddleLeft;
            btnNoteTab.UseVisualStyleBackColor = true;
            // 
            // picNote
            // 
            picNote.BackgroundImage = (Image)resources.GetObject("picNote.BackgroundImage");
            picNote.BackgroundImageLayout = ImageLayout.Zoom;
            picNote.Dock = DockStyle.Left;
            picNote.Location = new Point(5, 8);
            picNote.Name = "picNote";
            picNote.Size = new Size(38, 28);
            picNote.TabIndex = 0;
            picNote.TabStop = false;
            // 
            // pnlTimetableBtn
            // 
            pnlTimetableBtn.BackColor = Color.Transparent;
            pnlTimetableBtn.Controls.Add(btnTimetableTab);
            pnlTimetableBtn.Controls.Add(picTimetable);
            pnlTimetableBtn.Dock = DockStyle.Top;
            pnlTimetableBtn.ForeColor = Color.White;
            pnlTimetableBtn.Location = new Point(0, 116);
            pnlTimetableBtn.Name = "pnlTimetableBtn";
            pnlTimetableBtn.Padding = new Padding(5, 8, 0, 8);
            pnlTimetableBtn.Size = new Size(140, 44);
            pnlTimetableBtn.TabIndex = 0;
            pnlTimetableBtn.Click += pnlTimetableBtn_Click;
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
            btnTimetableTab.Size = new Size(97, 28);
            btnTimetableTab.TabIndex = 2;
            btnTimetableTab.Text = "Timetable";
            btnTimetableTab.TextAlign = ContentAlignment.MiddleLeft;
            btnTimetableTab.UseVisualStyleBackColor = true;
            // 
            // picTimetable
            // 
            picTimetable.BackgroundImage = Properties.Resources.Timetable;
            picTimetable.BackgroundImageLayout = ImageLayout.Zoom;
            picTimetable.Dock = DockStyle.Left;
            picTimetable.Location = new Point(5, 8);
            picTimetable.Name = "picTimetable";
            picTimetable.Size = new Size(38, 28);
            picTimetable.TabIndex = 0;
            picTimetable.TabStop = false;
            // 
            // pnlTimelineBtn
            // 
            pnlTimelineBtn.BackColor = Color.Transparent;
            pnlTimelineBtn.Controls.Add(btnTimelineTab);
            pnlTimelineBtn.Controls.Add(picTimeline);
            pnlTimelineBtn.Dock = DockStyle.Top;
            pnlTimelineBtn.ForeColor = Color.White;
            pnlTimelineBtn.Location = new Point(0, 72);
            pnlTimelineBtn.Name = "pnlTimelineBtn";
            pnlTimelineBtn.Padding = new Padding(5, 8, 0, 8);
            pnlTimelineBtn.Size = new Size(140, 44);
            pnlTimelineBtn.TabIndex = 0;
            pnlTimelineBtn.Click += pnlTimelineBtn_Click;
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
            btnTimelineTab.Size = new Size(97, 28);
            btnTimelineTab.TabIndex = 1;
            btnTimelineTab.Text = "Timeline";
            btnTimelineTab.TextAlign = ContentAlignment.MiddleLeft;
            btnTimelineTab.UseVisualStyleBackColor = true;
            // 
            // picTimeline
            // 
            picTimeline.BackgroundImage = Properties.Resources.Timeline;
            picTimeline.BackgroundImageLayout = ImageLayout.Zoom;
            picTimeline.Dock = DockStyle.Left;
            picTimeline.Location = new Point(5, 8);
            picTimeline.Name = "picTimeline";
            picTimeline.Size = new Size(38, 28);
            picTimeline.TabIndex = 0;
            picTimeline.TabStop = false;
            // 
            // pnlCalendarBtn
            // 
            pnlCalendarBtn.BackColor = Color.Transparent;
            pnlCalendarBtn.Controls.Add(btnCalendarTab);
            pnlCalendarBtn.Controls.Add(picCalendar);
            pnlCalendarBtn.Dock = DockStyle.Top;
            pnlCalendarBtn.ForeColor = Color.White;
            pnlCalendarBtn.Location = new Point(0, 28);
            pnlCalendarBtn.Name = "pnlCalendarBtn";
            pnlCalendarBtn.Padding = new Padding(5, 8, 0, 8);
            pnlCalendarBtn.Size = new Size(140, 44);
            pnlCalendarBtn.TabIndex = 0;
            pnlCalendarBtn.Click += pnlCalendarBtn_Click;
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
            // 
            // picCalendar
            // 
            picCalendar.BackgroundImage = Properties.Resources.Calendar;
            picCalendar.BackgroundImageLayout = ImageLayout.Zoom;
            picCalendar.Dock = DockStyle.Left;
            picCalendar.Location = new Point(5, 8);
            picCalendar.Name = "picCalendar";
            picCalendar.Size = new Size(38, 28);
            picCalendar.TabIndex = 0;
            picCalendar.TabStop = false;
            // 
            // pnlAboutBtn
            // 
            pnlAboutBtn.BackColor = Color.Transparent;
            pnlAboutBtn.Controls.Add(btnAboutWindow);
            pnlAboutBtn.Controls.Add(picAbout);
            pnlAboutBtn.Dock = DockStyle.Bottom;
            pnlAboutBtn.ForeColor = Color.White;
            pnlAboutBtn.Location = new Point(0, 496);
            pnlAboutBtn.Name = "pnlAboutBtn";
            pnlAboutBtn.Padding = new Padding(5, 8, 0, 8);
            pnlAboutBtn.Size = new Size(140, 44);
            pnlAboutBtn.TabIndex = 0;
            pnlAboutBtn.Click += pnlAboutBtn_Click;
            // 
            // btnAboutWindow
            // 
            btnAboutWindow.Dock = DockStyle.Left;
            btnAboutWindow.FlatAppearance.BorderSize = 0;
            btnAboutWindow.FlatStyle = FlatStyle.Flat;
            btnAboutWindow.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAboutWindow.ForeColor = Color.White;
            btnAboutWindow.Location = new Point(43, 8);
            btnAboutWindow.Margin = new Padding(3, 2, 3, 2);
            btnAboutWindow.Name = "btnAboutWindow";
            btnAboutWindow.Size = new Size(97, 28);
            btnAboutWindow.TabIndex = 6;
            btnAboutWindow.Text = "About";
            btnAboutWindow.TextAlign = ContentAlignment.MiddleLeft;
            btnAboutWindow.UseVisualStyleBackColor = true;
            // 
            // picAbout
            // 
            picAbout.BackgroundImage = Properties.Resources.About;
            picAbout.BackgroundImageLayout = ImageLayout.Zoom;
            picAbout.Dock = DockStyle.Left;
            picAbout.Location = new Point(5, 8);
            picAbout.Name = "picAbout";
            picAbout.Size = new Size(38, 28);
            picAbout.TabIndex = 0;
            picAbout.TabStop = false;
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
            pnlSettingBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSetting).EndInit();
            pnlWeatherBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picWeather).EndInit();
            pnlNoteBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picNote).EndInit();
            pnlTimetableBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTimetable).EndInit();
            pnlTimelineBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTimeline).EndInit();
            pnlCalendarBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCalendar).EndInit();
            pnlAboutBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAbout).EndInit();
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
        private PictureBox picCalendar;
        private Panel pnlWeatherBtn;
        private PictureBox picWeather;
        private Panel pnlNoteBtn;
        private PictureBox picNote;
        private Panel pnlTimetableBtn;
        private PictureBox picTimetable;
        private Panel pnlTimelineBtn;
        private PictureBox picTimeline;
        private Panel pnlCalendarBtn;
        private Panel pnlAboutBtn;
        private PictureBox picAbout;
        private Panel pnlSettingBtn;
        private PictureBox picSetting;
    }
}