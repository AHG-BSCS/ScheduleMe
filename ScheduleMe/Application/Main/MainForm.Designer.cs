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
            sideNavPanel.Padding = new Padding(0, 10, 0, 10);
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
            btnWeatherTab.Dock = DockStyle.Top;
            btnWeatherTab.FlatAppearance.BorderSize = 0;
            btnWeatherTab.FlatStyle = FlatStyle.Flat;
            btnWeatherTab.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnWeatherTab.ForeColor = Color.White;
            btnWeatherTab.Location = new Point(0, 186);
            btnWeatherTab.Margin = new Padding(3, 2, 3, 2);
            btnWeatherTab.Name = "btnWeatherTab";
            btnWeatherTab.Size = new Size(140, 44);
            btnWeatherTab.TabIndex = 4;
            btnWeatherTab.Text = "          Weather";
            btnWeatherTab.TextAlign = ContentAlignment.MiddleLeft;
            btnWeatherTab.UseVisualStyleBackColor = true;
            btnWeatherTab.Click += btnWeatherTab_Click;
            // 
            // btnNoteTab
            // 
            btnNoteTab.Dock = DockStyle.Top;
            btnNoteTab.FlatAppearance.BorderSize = 0;
            btnNoteTab.FlatStyle = FlatStyle.Flat;
            btnNoteTab.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNoteTab.ForeColor = Color.White;
            btnNoteTab.Location = new Point(0, 142);
            btnNoteTab.Margin = new Padding(3, 2, 3, 2);
            btnNoteTab.Name = "btnNoteTab";
            btnNoteTab.Size = new Size(140, 44);
            btnNoteTab.TabIndex = 3;
            btnNoteTab.Text = "          Note";
            btnNoteTab.TextAlign = ContentAlignment.MiddleLeft;
            btnNoteTab.UseVisualStyleBackColor = true;
            btnNoteTab.Click += btnNoteTab_Click;
            // 
            // btnTimetableTab
            // 
            btnTimetableTab.Dock = DockStyle.Top;
            btnTimetableTab.FlatAppearance.BorderSize = 0;
            btnTimetableTab.FlatStyle = FlatStyle.Flat;
            btnTimetableTab.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimetableTab.ForeColor = Color.White;
            btnTimetableTab.Location = new Point(0, 98);
            btnTimetableTab.Margin = new Padding(3, 2, 3, 2);
            btnTimetableTab.Name = "btnTimetableTab";
            btnTimetableTab.Size = new Size(140, 44);
            btnTimetableTab.TabIndex = 2;
            btnTimetableTab.Text = "          Timetable";
            btnTimetableTab.TextAlign = ContentAlignment.MiddleLeft;
            btnTimetableTab.UseVisualStyleBackColor = true;
            btnTimetableTab.Click += btnTimetableTab_Click;
            // 
            // btnTimelineTab
            // 
            btnTimelineTab.Dock = DockStyle.Top;
            btnTimelineTab.FlatAppearance.BorderSize = 0;
            btnTimelineTab.FlatStyle = FlatStyle.Flat;
            btnTimelineTab.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimelineTab.ForeColor = Color.White;
            btnTimelineTab.Location = new Point(0, 54);
            btnTimelineTab.Margin = new Padding(3, 2, 3, 2);
            btnTimelineTab.Name = "btnTimelineTab";
            btnTimelineTab.Size = new Size(140, 44);
            btnTimelineTab.TabIndex = 1;
            btnTimelineTab.Text = "          Timeline";
            btnTimelineTab.TextAlign = ContentAlignment.MiddleLeft;
            btnTimelineTab.UseVisualStyleBackColor = true;
            btnTimelineTab.Click += btnTimelineTab_Click;
            // 
            // btnCalendarTab
            // 
            btnCalendarTab.Dock = DockStyle.Top;
            btnCalendarTab.FlatAppearance.BorderSize = 0;
            btnCalendarTab.FlatStyle = FlatStyle.Flat;
            btnCalendarTab.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalendarTab.ForeColor = Color.White;
            btnCalendarTab.Location = new Point(0, 10);
            btnCalendarTab.Margin = new Padding(3, 2, 3, 2);
            btnCalendarTab.Name = "btnCalendarTab";
            btnCalendarTab.Size = new Size(140, 44);
            btnCalendarTab.TabIndex = 0;
            btnCalendarTab.Text = "          Calendar";
            btnCalendarTab.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendarTab.UseVisualStyleBackColor = true;
            btnCalendarTab.Click += btnCalendarTab_Click;
            // 
            // tabPanel
            // 
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
            sideNavPanel.ResumeLayout(false);
            ResumeLayout(false);
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