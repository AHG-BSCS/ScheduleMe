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
            this.sideNavPanel = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnWeather = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnTimeline = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.sideNavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideNavPanel
            // 
            this.sideNavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.sideNavPanel.Controls.Add(this.btnSetting);
            this.sideNavPanel.Controls.Add(this.btnWeather);
            this.sideNavPanel.Controls.Add(this.btnNote);
            this.sideNavPanel.Controls.Add(this.btnTimetable);
            this.sideNavPanel.Controls.Add(this.btnTimeline);
            this.sideNavPanel.Controls.Add(this.btnCalendar);
            this.sideNavPanel.Controls.Add(this.btnAbout);
            this.sideNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNavPanel.Location = new System.Drawing.Point(0, 0);
            this.sideNavPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideNavPanel.Name = "sideNavPanel";
            this.sideNavPanel.Padding = new System.Windows.Forms.Padding(0, 28, 0, 10);
            this.sideNavPanel.Size = new System.Drawing.Size(140, 550);
            this.sideNavPanel.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = global::ScheduleMe.Properties.Resources.tabSetting;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(0, 452);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(140, 44);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.TabStop = false;
            this.btnSetting.Text = "              Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnWeather
            // 
            this.btnWeather.BackColor = System.Drawing.Color.Transparent;
            this.btnWeather.BackgroundImage = global::ScheduleMe.Properties.Resources.tabWeather;
            this.btnWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWeather.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeather.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWeather.FlatAppearance.BorderSize = 0;
            this.btnWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeather.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWeather.ForeColor = System.Drawing.Color.White;
            this.btnWeather.Location = new System.Drawing.Point(0, 209);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(140, 44);
            this.btnWeather.TabIndex = 4;
            this.btnWeather.TabStop = false;
            this.btnWeather.Text = "              Weather";
            this.btnWeather.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeather.UseVisualStyleBackColor = false;
            this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
            // 
            // btnNote
            // 
            this.btnNote.BackColor = System.Drawing.Color.Transparent;
            this.btnNote.BackgroundImage = global::ScheduleMe.Properties.Resources.tabNote;
            this.btnNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNote.FlatAppearance.BorderSize = 0;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNote.ForeColor = System.Drawing.Color.White;
            this.btnNote.Location = new System.Drawing.Point(0, 165);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(140, 44);
            this.btnNote.TabIndex = 3;
            this.btnNote.TabStop = false;
            this.btnNote.Text = "              Note";
            this.btnNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNote.UseVisualStyleBackColor = false;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnTimetable
            // 
            this.btnTimetable.BackColor = System.Drawing.Color.Transparent;
            this.btnTimetable.BackgroundImage = global::ScheduleMe.Properties.Resources.tabTimetable;
            this.btnTimetable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimetable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimetable.FlatAppearance.BorderSize = 0;
            this.btnTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimetable.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimetable.ForeColor = System.Drawing.Color.White;
            this.btnTimetable.Location = new System.Drawing.Point(0, 121);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(140, 44);
            this.btnTimetable.TabIndex = 2;
            this.btnTimetable.TabStop = false;
            this.btnTimetable.Text = "              Timetable";
            this.btnTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimetable.UseVisualStyleBackColor = false;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
            // 
            // btnTimeline
            // 
            this.btnTimeline.BackColor = System.Drawing.Color.Transparent;
            this.btnTimeline.BackgroundImage = global::ScheduleMe.Properties.Resources.tabTimeline;
            this.btnTimeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimeline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeline.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimeline.FlatAppearance.BorderSize = 0;
            this.btnTimeline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeline.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimeline.ForeColor = System.Drawing.Color.White;
            this.btnTimeline.Location = new System.Drawing.Point(0, 77);
            this.btnTimeline.Name = "btnTimeline";
            this.btnTimeline.Size = new System.Drawing.Size(140, 44);
            this.btnTimeline.TabIndex = 1;
            this.btnTimeline.TabStop = false;
            this.btnTimeline.Text = "              Timeline";
            this.btnTimeline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeline.UseVisualStyleBackColor = false;
            this.btnTimeline.Click += new System.EventHandler(this.btnTimeline_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendar.BackgroundImage = global::ScheduleMe.Properties.Resources.tabCalendar;
            this.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnCalendar.Location = new System.Drawing.Point(0, 28);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(140, 49);
            this.btnCalendar.TabIndex = 0;
            this.btnCalendar.TabStop = false;
            this.btnCalendar.Text = "              Calendar";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = global::ScheduleMe.Properties.Resources.tabAbout;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(0, 496);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(140, 44);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "              About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tabPanel
            // 
            this.tabPanel.AutoScroll = true;
            this.tabPanel.BackColor = System.Drawing.Color.White;
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Location = new System.Drawing.Point(140, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(850, 550);
            this.tabPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 550);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.sideNavPanel);
            this.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleMe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sideNavPanel.ResumeLayout(false);
            this.ResumeLayout(false);

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