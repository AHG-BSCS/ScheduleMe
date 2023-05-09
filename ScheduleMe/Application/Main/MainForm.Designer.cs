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
            sideNavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sideNavPanel
            // 
            sideNavPanel.BackColor = Color.FromArgb(15, 76, 129);
            sideNavPanel.Controls.Add(btnSettingWindow);
            sideNavPanel.Controls.Add(btnAboutWindow);
            sideNavPanel.Controls.Add(btnWeatherTab);
            sideNavPanel.Controls.Add(btnNoteTab);
            sideNavPanel.Controls.Add(btnTimetableTab);
            sideNavPanel.Controls.Add(btnTimelineTab);
            sideNavPanel.Controls.Add(btnCalendarTab);
            sideNavPanel.Dock = DockStyle.Left;
            sideNavPanel.Location = new Point(0, 0);
            sideNavPanel.Margin = new Padding(3, 2, 3, 2);
            sideNavPanel.Name = "sideNavPanel";
            sideNavPanel.Size = new Size(140, 548);
            sideNavPanel.TabIndex = 0;
            // 
            // btnSettingWindow
            // 
            btnSettingWindow.Dock = DockStyle.Bottom;
            btnSettingWindow.FlatAppearance.BorderSize = 0;
            btnSettingWindow.FlatStyle = FlatStyle.Flat;
            btnSettingWindow.Location = new Point(0, 460);
            btnSettingWindow.Margin = new Padding(3, 2, 3, 2);
            btnSettingWindow.Name = "btnSettingWindow";
            btnSettingWindow.Padding = new Padding(35, 0, 0, 0);
            btnSettingWindow.Size = new Size(140, 44);
            btnSettingWindow.TabIndex = 6;
            btnSettingWindow.Text = "Setting";
            btnSettingWindow.TextAlign = ContentAlignment.MiddleLeft;
            btnSettingWindow.UseVisualStyleBackColor = true;
            btnSettingWindow.Click += btnSettingWindow_Click;
            // 
            // btnAboutWindow
            // 
            btnAboutWindow.Dock = DockStyle.Bottom;
            btnAboutWindow.FlatAppearance.BorderSize = 0;
            btnAboutWindow.FlatStyle = FlatStyle.Flat;
            btnAboutWindow.Location = new Point(0, 504);
            btnAboutWindow.Margin = new Padding(3, 2, 3, 2);
            btnAboutWindow.Name = "btnAboutWindow";
            btnAboutWindow.Padding = new Padding(35, 0, 0, 0);
            btnAboutWindow.Size = new Size(140, 44);
            btnAboutWindow.TabIndex = 5;
            btnAboutWindow.Text = "About";
            btnAboutWindow.TextAlign = ContentAlignment.MiddleLeft;
            btnAboutWindow.UseVisualStyleBackColor = true;
            btnAboutWindow.Click += btnAboutWindow_Click;
            // 
            // btnWeatherTab
            // 
            btnWeatherTab.Dock = DockStyle.Top;
            btnWeatherTab.FlatAppearance.BorderSize = 0;
            btnWeatherTab.FlatStyle = FlatStyle.Flat;
            btnWeatherTab.Location = new Point(0, 176);
            btnWeatherTab.Margin = new Padding(3, 2, 3, 2);
            btnWeatherTab.Name = "btnWeatherTab";
            btnWeatherTab.Padding = new Padding(35, 0, 0, 0);
            btnWeatherTab.Size = new Size(140, 44);
            btnWeatherTab.TabIndex = 4;
            btnWeatherTab.Text = "Weather";
            btnWeatherTab.TextAlign = ContentAlignment.MiddleLeft;
            btnWeatherTab.UseVisualStyleBackColor = true;
            btnWeatherTab.Click += btnWeatherTab_Click;
            // 
            // btnNoteTab
            // 
            btnNoteTab.Dock = DockStyle.Top;
            btnNoteTab.FlatAppearance.BorderSize = 0;
            btnNoteTab.FlatStyle = FlatStyle.Flat;
            btnNoteTab.Location = new Point(0, 132);
            btnNoteTab.Margin = new Padding(3, 2, 3, 2);
            btnNoteTab.Name = "btnNoteTab";
            btnNoteTab.Padding = new Padding(35, 0, 0, 0);
            btnNoteTab.Size = new Size(140, 44);
            btnNoteTab.TabIndex = 0;
            btnNoteTab.Text = "Note";
            btnNoteTab.TextAlign = ContentAlignment.MiddleLeft;
            btnNoteTab.UseVisualStyleBackColor = true;
            btnNoteTab.Click += btnNoteTab_Click;
            // 
            // btnTimetableTab
            // 
            btnTimetableTab.Dock = DockStyle.Top;
            btnTimetableTab.FlatAppearance.BorderSize = 0;
            btnTimetableTab.FlatStyle = FlatStyle.Flat;
            btnTimetableTab.Location = new Point(0, 88);
            btnTimetableTab.Margin = new Padding(3, 2, 3, 2);
            btnTimetableTab.Name = "btnTimetableTab";
            btnTimetableTab.Padding = new Padding(35, 0, 0, 0);
            btnTimetableTab.Size = new Size(140, 44);
            btnTimetableTab.TabIndex = 1;
            btnTimetableTab.Text = "Timetable";
            btnTimetableTab.TextAlign = ContentAlignment.MiddleLeft;
            btnTimetableTab.UseVisualStyleBackColor = true;
            btnTimetableTab.Click += btnTimetableTab_Click;
            // 
            // btnTimelineTab
            // 
            btnTimelineTab.Dock = DockStyle.Top;
            btnTimelineTab.FlatAppearance.BorderSize = 0;
            btnTimelineTab.FlatStyle = FlatStyle.Flat;
            btnTimelineTab.Location = new Point(0, 44);
            btnTimelineTab.Margin = new Padding(3, 2, 3, 2);
            btnTimelineTab.Name = "btnTimelineTab";
            btnTimelineTab.Padding = new Padding(35, 0, 0, 0);
            btnTimelineTab.Size = new Size(140, 44);
            btnTimelineTab.TabIndex = 3;
            btnTimelineTab.Text = "Timeline";
            btnTimelineTab.TextAlign = ContentAlignment.MiddleLeft;
            btnTimelineTab.UseVisualStyleBackColor = true;
            btnTimelineTab.Click += btnTimelineTab_Click;
            // 
            // btnCalendarTab
            // 
            btnCalendarTab.Dock = DockStyle.Top;
            btnCalendarTab.FlatAppearance.BorderSize = 0;
            btnCalendarTab.FlatStyle = FlatStyle.Flat;
            btnCalendarTab.Location = new Point(0, 0);
            btnCalendarTab.Margin = new Padding(3, 2, 3, 2);
            btnCalendarTab.Name = "btnCalendarTab";
            btnCalendarTab.Padding = new Padding(35, 0, 0, 0);
            btnCalendarTab.Size = new Size(140, 44);
            btnCalendarTab.TabIndex = 2;
            btnCalendarTab.Text = "Calendar";
            btnCalendarTab.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendarTab.UseVisualStyleBackColor = true;
            btnCalendarTab.Click += btnCalendarTab_Click;
            // 
            // tabPanel
            // 
            tabPanel.Dock = DockStyle.Fill;
            tabPanel.Location = new Point(140, 0);
            tabPanel.Name = "tabPanel";
            tabPanel.Size = new Size(850, 548);
            tabPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(990, 548);
            Controls.Add(tabPanel);
            Controls.Add(sideNavPanel);
            Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScheduleMe";
            WindowState = FormWindowState.Maximized;
            sideNavPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sideNavPanel;
        private Button btnNoteTab;
        private Button btnTimetableTab;
        private Button btnCalendarTab;
        private Button btnTimelineTab;
        private Button btnWeatherTab;
        private Button btnAboutWindow;
        private Button btnSettingWindow;
        private Panel tabPanel;
    }
}