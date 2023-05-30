namespace ScheduleMe.Application.Calendar
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
            textBox1 = new TextBox();
            eventNameLbl = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            saveEventButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 23);
            textBox1.TabIndex = 0;
            // 
            // eventNameLbl
            // 
            eventNameLbl.AutoSize = true;
            eventNameLbl.Location = new Point(57, 147);
            eventNameLbl.Name = "eventNameLbl";
            eventNameLbl.Size = new Size(39, 15);
            eventNameLbl.TabIndex = 1;
            eventNameLbl.Text = "Event:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 41);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Date:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 23);
            textBox2.TabIndex = 3;
            // 
            // saveEventButton
            // 
            saveEventButton.Location = new Point(353, 255);
            saveEventButton.Name = "saveEventButton";
            saveEventButton.Size = new Size(85, 23);
            saveEventButton.TabIndex = 4;
            saveEventButton.Text = "Save Event";
            saveEventButton.UseVisualStyleBackColor = true;
            // 
            // AddEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 317);
            Controls.Add(saveEventButton);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(eventNameLbl);
            Controls.Add(textBox1);
            Name = "AddEventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label eventNameLbl;
        private Label label1;
        private TextBox textBox2;
        private Button saveEventButton;
    }
}