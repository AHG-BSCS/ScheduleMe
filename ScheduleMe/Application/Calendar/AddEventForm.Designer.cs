namespace ScheduleMe.Tab

{
    partial class AddEventForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            eventNameTxtBx = new TextBox();
            eventNameLbl = new Label();
            label1 = new Label();
            eventDateTxtBx = new TextBox();
            saveEventButton = new Button();
            SuspendLayout();
            // 
            // eventNameTxtBx
            // 
            eventNameTxtBx.Location = new Point(12, 101);
            eventNameTxtBx.Margin = new Padding(3, 4, 3, 4);
            eventNameTxtBx.Name = "eventNameTxtBx";
            eventNameTxtBx.Size = new Size(186, 29);
            eventNameTxtBx.TabIndex = 0;
            // 
            // eventNameLbl
            // 
            eventNameLbl.AutoSize = true;
            eventNameLbl.Location = new Point(12, 75);
            eventNameLbl.Name = "eventNameLbl";
            eventNameLbl.Size = new Size(43, 22);
            eventNameLbl.TabIndex = 1;
            eventNameLbl.Text = "Event:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(38, 22);
            label1.TabIndex = 2;
            label1.Text = "Date:";
            // 
            // eventDateTxtBx
            // 
            eventDateTxtBx.Location = new Point(12, 33);
            eventDateTxtBx.Margin = new Padding(3, 4, 3, 4);
            eventDateTxtBx.Name = "eventDateTxtBx";
            eventDateTxtBx.ReadOnly = true;
            eventDateTxtBx.Size = new Size(186, 29);
            eventDateTxtBx.TabIndex = 3;
            eventDateTxtBx.TextAlign = HorizontalAlignment.Center;
            // 
            // saveEventButton
            // 
            saveEventButton.Location = new Point(61, 148);
            saveEventButton.Margin = new Padding(3, 4, 3, 4);
            saveEventButton.Name = "saveEventButton";
            saveEventButton.Size = new Size(85, 34);
            saveEventButton.TabIndex = 4;
            saveEventButton.Text = "Save Event";
            saveEventButton.UseVisualStyleBackColor = true;
            saveEventButton.Click += saveEventButton_Click;
            // 
            // AddEventForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(212, 195);
            Controls.Add(saveEventButton);
            Controls.Add(eventDateTxtBx);
            Controls.Add(label1);
            Controls.Add(eventNameLbl);
            Controls.Add(eventNameTxtBx);
            Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(228, 234);
            Name = "AddEventForm";
            Load += AddEventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox eventNameTxtBx;
        private Label eventNameLbl;
        private Label label1;
        private TextBox eventDateTxtBx;
        private Button saveEventButton;
    }
}