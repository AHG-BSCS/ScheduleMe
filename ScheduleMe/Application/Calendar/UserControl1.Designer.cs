namespace ScheduleMe.Tab
{
    partial class UCMonthYearDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MonthYearControl = new Label();
            monthYearLbl = new Label();
            SuspendLayout();
            // 
            // MonthYearControl
            // 
            MonthYearControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MonthYearControl.AutoSize = true;
            MonthYearControl.Font = new Font("Gill Sans MT", 36F, FontStyle.Bold, GraphicsUnit.Point);
            MonthYearControl.Location = new Point(3, 0);
            MonthYearControl.Name = "MonthYearControl";
            MonthYearControl.Size = new Size(0, 67);
            MonthYearControl.TabIndex = 18;
            MonthYearControl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // monthYearLbl
            // 
            monthYearLbl.Dock = DockStyle.Fill;
            monthYearLbl.Font = new Font("Dubai", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            monthYearLbl.Location = new Point(0, 0);
            monthYearLbl.Name = "monthYearLbl";
            monthYearLbl.RightToLeft = RightToLeft.No;
            monthYearLbl.Size = new Size(295, 67);
            monthYearLbl.TabIndex = 19;
            monthYearLbl.Text = "Month";
            monthYearLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCMonthYearDisplay
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(monthYearLbl);
            Controls.Add(MonthYearControl);
            Name = "UCMonthYearDisplay";
            Size = new Size(295, 67);
            Load += UCMonthYearDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MonthYearControl;
        private Label monthYearLbl;
    }
}
