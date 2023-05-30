namespace ScheduleMe.Tab

{
    partial class UserControlDays
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
            daysLbl = new Label();
            numDayLbl = new Label();
            SuspendLayout();
            // 
            // daysLbl
            // 
            daysLbl.AutoSize = true;
            daysLbl.Location = new Point(13, 22);
            daysLbl.Name = "daysLbl";
            daysLbl.Size = new Size(38, 15);
            daysLbl.TabIndex = 0;
            daysLbl.Text = "label1";
            // 
            // numDayLbl
            // 
            numDayLbl.AutoSize = true;
            numDayLbl.Font = new Font("Sitka Small", 12F, FontStyle.Italic, GraphicsUnit.Point);
            numDayLbl.Location = new Point(13, 10);
            numDayLbl.Name = "numDayLbl";
            numDayLbl.Size = new Size(32, 24);
            numDayLbl.TabIndex = 0;
            numDayLbl.Text = "00";
            // 
            // UserControlDays
            // 
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(numDayLbl);
            Name = "UserControlDays";
            Size = new Size(108, 80);
            Load += UserControlDays_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label daysLbl;
        private Label numDayLbl;
    }
}
