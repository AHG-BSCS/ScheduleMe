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
            this.btnSettingWindow = new System.Windows.Forms.Button();
            this.btnAboutWindow = new System.Windows.Forms.Button();
            this.btnWeatherTab = new System.Windows.Forms.Button();
            this.btnNoteTab = new System.Windows.Forms.Button();
            this.btnTimetableTab = new System.Windows.Forms.Button();
            this.btnTimelineTab = new System.Windows.Forms.Button();
            this.btnCalendarTab = new System.Windows.Forms.Button();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.sideNavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideNavPanel
            // 
            this.sideNavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.sideNavPanel.Controls.Add(this.btnSettingWindow);
            this.sideNavPanel.Controls.Add(this.btnAboutWindow);
            this.sideNavPanel.Controls.Add(this.btnWeatherTab);
            this.sideNavPanel.Controls.Add(this.btnNoteTab);
            this.sideNavPanel.Controls.Add(this.btnTimetableTab);
            this.sideNavPanel.Controls.Add(this.btnTimelineTab);
            this.sideNavPanel.Controls.Add(this.btnCalendarTab);
            this.sideNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNavPanel.Location = new System.Drawing.Point(0, 0);
            this.sideNavPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideNavPanel.Name = "sideNavPanel";
            this.sideNavPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.sideNavPanel.Size = new System.Drawing.Size(140, 550);
            this.sideNavPanel.TabIndex = 0;
            // 
            // btnSettingWindow
            // 
            this.btnSettingWindow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettingWindow.FlatAppearance.BorderSize = 0;
            this.btnSettingWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingWindow.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettingWindow.ForeColor = System.Drawing.Color.White;
            this.btnSettingWindow.Location = new System.Drawing.Point(0, 452);
            this.btnSettingWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettingWindow.Name = "btnSettingWindow";
            this.btnSettingWindow.Size = new System.Drawing.Size(140, 44);
            this.btnSettingWindow.TabIndex = 5;
            this.btnSettingWindow.Text = "          Setting";
            this.btnSettingWindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingWindow.UseVisualStyleBackColor = true;
            this.btnSettingWindow.Click += new System.EventHandler(this.btnSettingWindow_Click);
            // 
            // btnAboutWindow
            // 
            this.btnAboutWindow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAboutWindow.FlatAppearance.BorderSize = 0;
            this.btnAboutWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutWindow.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAboutWindow.ForeColor = System.Drawing.Color.White;
            this.btnAboutWindow.Location = new System.Drawing.Point(0, 496);
            this.btnAboutWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAboutWindow.Name = "btnAboutWindow";
            this.btnAboutWindow.Size = new System.Drawing.Size(140, 44);
            this.btnAboutWindow.TabIndex = 6;
            this.btnAboutWindow.Text = "          About";
            this.btnAboutWindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutWindow.UseVisualStyleBackColor = true;
            this.btnAboutWindow.Click += new System.EventHandler(this.btnAboutWindow_Click);
            // 
            // btnWeatherTab
            // 
            this.btnWeatherTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWeatherTab.FlatAppearance.BorderSize = 0;
            this.btnWeatherTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeatherTab.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWeatherTab.ForeColor = System.Drawing.Color.White;
            this.btnWeatherTab.Location = new System.Drawing.Point(0, 186);
            this.btnWeatherTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWeatherTab.Name = "btnWeatherTab";
            this.btnWeatherTab.Size = new System.Drawing.Size(140, 44);
            this.btnWeatherTab.TabIndex = 4;
            this.btnWeatherTab.Text = "          Weather";
            this.btnWeatherTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeatherTab.UseVisualStyleBackColor = true;
            this.btnWeatherTab.Click += new System.EventHandler(this.btnWeatherTab_Click);
            // 
            // btnNoteTab
            // 
            this.btnNoteTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNoteTab.FlatAppearance.BorderSize = 0;
            this.btnNoteTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoteTab.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNoteTab.ForeColor = System.Drawing.Color.White;
            this.btnNoteTab.Location = new System.Drawing.Point(0, 142);
            this.btnNoteTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoteTab.Name = "btnNoteTab";
            this.btnNoteTab.Size = new System.Drawing.Size(140, 44);
            this.btnNoteTab.TabIndex = 3;
            this.btnNoteTab.Text = "          Note";
            this.btnNoteTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoteTab.UseVisualStyleBackColor = true;
            this.btnNoteTab.Click += new System.EventHandler(this.btnNoteTab_Click);
            // 
            // btnTimetableTab
            // 
            this.btnTimetableTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimetableTab.FlatAppearance.BorderSize = 0;
            this.btnTimetableTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimetableTab.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimetableTab.ForeColor = System.Drawing.Color.White;
            this.btnTimetableTab.Location = new System.Drawing.Point(0, 98);
            this.btnTimetableTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimetableTab.Name = "btnTimetableTab";
            this.btnTimetableTab.Size = new System.Drawing.Size(140, 44);
            this.btnTimetableTab.TabIndex = 2;
            this.btnTimetableTab.Text = "          Timetable";
            this.btnTimetableTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimetableTab.UseVisualStyleBackColor = true;
            this.btnTimetableTab.Click += new System.EventHandler(this.btnTimetableTab_Click);
            // 
            // btnTimelineTab
            // 
            this.btnTimelineTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimelineTab.FlatAppearance.BorderSize = 0;
            this.btnTimelineTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimelineTab.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimelineTab.ForeColor = System.Drawing.Color.White;
            this.btnTimelineTab.Location = new System.Drawing.Point(0, 54);
            this.btnTimelineTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimelineTab.Name = "btnTimelineTab";
            this.btnTimelineTab.Size = new System.Drawing.Size(140, 44);
            this.btnTimelineTab.TabIndex = 1;
            this.btnTimelineTab.Text = "          Timeline";
            this.btnTimelineTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimelineTab.UseVisualStyleBackColor = true;
            this.btnTimelineTab.Click += new System.EventHandler(this.btnTimelineTab_Click);
            // 
            // btnCalendarTab
            // 
            this.btnCalendarTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendarTab.FlatAppearance.BorderSize = 0;
            this.btnCalendarTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarTab.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalendarTab.ForeColor = System.Drawing.Color.White;
            this.btnCalendarTab.Location = new System.Drawing.Point(0, 10);
            this.btnCalendarTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalendarTab.Name = "btnCalendarTab";
            this.btnCalendarTab.Size = new System.Drawing.Size(140, 44);
            this.btnCalendarTab.TabIndex = 0;
            this.btnCalendarTab.Text = "          Calendar";
            this.btnCalendarTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendarTab.UseVisualStyleBackColor = true;
            this.btnCalendarTab.Click += new System.EventHandler(this.btnCalendarTab_Click);
            // 
            // tabPanel
            // 
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ScheduleMe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sideNavPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnNoteTab;
        private Button btnTimetableTab;
        private Button btnCalendarTab;
        private Button btnTimelineTab;
        private Button btnWeatherTab;
        private Button btnAboutWindow;
        private Panel tabPanel;
        public Button btnSettingWindow;
        public Panel sideNavPanel;
    }
}