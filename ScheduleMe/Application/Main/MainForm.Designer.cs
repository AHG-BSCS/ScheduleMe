﻿namespace ScheduleMe
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
            lblSetting = new Label();
            picSetting = new PictureBox();
            pnlWeatherBtn = new Panel();
            lblWeather = new Label();
            picWeather = new PictureBox();
            pnlNoteBtn = new Panel();
            lblNote = new Label();
            picNote = new PictureBox();
            pnlTimetableBtn = new Panel();
            lblTimetable = new Label();
            picTimetable = new PictureBox();
            pnlTimelineBtn = new Panel();
            lblTimeline = new Label();
            picTimeline = new PictureBox();
            pnlCalendarBtn = new Panel();
            lblCalendar = new Label();
            picCalendar = new PictureBox();
            pnlAboutBtn = new Panel();
            lblAbout = new Label();
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
            pnlSettingBtn.Controls.Add(lblSetting);
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
            // lblSetting
            // 
            lblSetting.AutoSize = true;
            lblSetting.BackColor = Color.Transparent;
            lblSetting.Dock = DockStyle.Left;
            lblSetting.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSetting.ForeColor = Color.White;
            lblSetting.Location = new Point(43, 8);
            lblSetting.Name = "lblSetting";
            lblSetting.Size = new Size(59, 25);
            lblSetting.TabIndex = 0;
            lblSetting.Text = "Setting";
            lblSetting.Click += lblSetting_Click;
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
            picSetting.Click += picSetting_Click;
            // 
            // pnlWeatherBtn
            // 
            pnlWeatherBtn.BackColor = Color.Transparent;
            pnlWeatherBtn.Controls.Add(lblWeather);
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
            // lblWeather
            // 
            lblWeather.AutoSize = true;
            lblWeather.BackColor = Color.Transparent;
            lblWeather.Dock = DockStyle.Left;
            lblWeather.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeather.ForeColor = Color.White;
            lblWeather.Location = new Point(43, 8);
            lblWeather.Name = "lblWeather";
            lblWeather.Size = new Size(67, 25);
            lblWeather.TabIndex = 0;
            lblWeather.Text = "Weather";
            lblWeather.Click += lblWeather_Click;
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
            picWeather.Click += picWeather_Click;
            // 
            // pnlNoteBtn
            // 
            pnlNoteBtn.BackColor = Color.Transparent;
            pnlNoteBtn.Controls.Add(lblNote);
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
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.BackColor = Color.Transparent;
            lblNote.Dock = DockStyle.Left;
            lblNote.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNote.ForeColor = Color.White;
            lblNote.Location = new Point(43, 8);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(44, 25);
            lblNote.TabIndex = 0;
            lblNote.Text = "Note";
            lblNote.Click += lblNote_Click;
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
            picNote.Click += picNote_Click;
            // 
            // pnlTimetableBtn
            // 
            pnlTimetableBtn.BackColor = Color.Transparent;
            pnlTimetableBtn.Controls.Add(lblTimetable);
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
            // lblTimetable
            // 
            lblTimetable.AutoSize = true;
            lblTimetable.BackColor = Color.Transparent;
            lblTimetable.Dock = DockStyle.Left;
            lblTimetable.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimetable.ForeColor = Color.White;
            lblTimetable.Location = new Point(43, 8);
            lblTimetable.Name = "lblTimetable";
            lblTimetable.Size = new Size(76, 25);
            lblTimetable.TabIndex = 0;
            lblTimetable.Text = "Timetable";
            lblTimetable.Click += lblTimetable_Click;
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
            picTimetable.Click += picTimetable_Click;
            // 
            // pnlTimelineBtn
            // 
            pnlTimelineBtn.BackColor = Color.Transparent;
            pnlTimelineBtn.Controls.Add(lblTimeline);
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
            // lblTimeline
            // 
            lblTimeline.AutoSize = true;
            lblTimeline.BackColor = Color.Transparent;
            lblTimeline.Dock = DockStyle.Left;
            lblTimeline.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimeline.ForeColor = Color.White;
            lblTimeline.Location = new Point(43, 8);
            lblTimeline.Name = "lblTimeline";
            lblTimeline.Size = new Size(67, 25);
            lblTimeline.TabIndex = 0;
            lblTimeline.Text = "Timeline";
            lblTimeline.Click += lblTimeline_Click;
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
            picTimeline.Click += picTimeline_Click;
            // 
            // pnlCalendarBtn
            // 
            pnlCalendarBtn.BackColor = Color.Transparent;
            pnlCalendarBtn.Controls.Add(lblCalendar);
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
            // lblCalendar
            // 
            lblCalendar.AutoSize = true;
            lblCalendar.BackColor = Color.Transparent;
            lblCalendar.Dock = DockStyle.Left;
            lblCalendar.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCalendar.ForeColor = Color.White;
            lblCalendar.Location = new Point(43, 8);
            lblCalendar.Name = "lblCalendar";
            lblCalendar.Size = new Size(68, 25);
            lblCalendar.TabIndex = 0;
            lblCalendar.Text = "Calendar";
            lblCalendar.Click += lblCalendar_Click;
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
            picCalendar.Click += picCalendar_Click;
            // 
            // pnlAboutBtn
            // 
            pnlAboutBtn.BackColor = Color.Transparent;
            pnlAboutBtn.Controls.Add(lblAbout);
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
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.BackColor = Color.Transparent;
            lblAbout.Dock = DockStyle.Left;
            lblAbout.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAbout.ForeColor = Color.White;
            lblAbout.Location = new Point(43, 8);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(52, 25);
            lblAbout.TabIndex = 0;
            lblAbout.Text = "About";
            lblAbout.Click += lblAbout_Click;
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
            picAbout.Click += picAbout_Click;
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
            pnlSettingBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSetting).EndInit();
            pnlWeatherBtn.ResumeLayout(false);
            pnlWeatherBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picWeather).EndInit();
            pnlNoteBtn.ResumeLayout(false);
            pnlNoteBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNote).EndInit();
            pnlTimetableBtn.ResumeLayout(false);
            pnlTimetableBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimetable).EndInit();
            pnlTimelineBtn.ResumeLayout(false);
            pnlTimelineBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimeline).EndInit();
            pnlCalendarBtn.ResumeLayout(false);
            pnlCalendarBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCalendar).EndInit();
            pnlAboutBtn.ResumeLayout(false);
            pnlAboutBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAbout).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private Label lblCalendar;
        private Label lblWeather;
        private Label lblNote;
        private Label lblTimetable;
        private Label lblTimeline;
        private Label lblSetting;
        private Label lblAbout;
    }
}