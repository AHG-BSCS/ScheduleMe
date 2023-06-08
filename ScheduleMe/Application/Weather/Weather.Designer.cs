namespace ScheduleMe.Tab;

partial class Weather
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
        pictureBox1 = new PictureBox();
        label2 = new Label();
        label3 = new Label();
        textBox1 = new TextBox();
        button1 = new Button();
        label4 = new Label();
        pictureBox2 = new PictureBox();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        panel1 = new Panel();
        label12 = new Label();
        label11 = new Label();
        label10 = new Label();
        label9 = new Label();
        label8 = new Label();
        pictureBox7 = new PictureBox();
        pictureBox6 = new PictureBox();
        pictureBox5 = new PictureBox();
        pictureBox4 = new PictureBox();
        pictureBox3 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new Point(406, 167);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(50, 50);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(462, 180);
        label2.Name = "label2";
        label2.Size = new Size(92, 25);
        label2.TabIndex = 3;
        label2.Text = "CONDITION";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Dubai", 24F, FontStyle.Bold, GraphicsUnit.Point);
        label3.Location = new Point(566, 22);
        label3.Name = "label3";
        label3.Size = new Size(88, 54);
        label3.TabIndex = 4;
        label3.Text = "CITY";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        label3.TextChanged += label3_TextChanged;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(959, 462);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(182, 29);
        textBox1.TabIndex = 5;
        textBox1.Text = "San Pablo Laguna";
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(15, 76, 129);
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        button1.ForeColor = Color.White;
        button1.Location = new Point(959, 509);
        button1.Name = "button1";
        button1.Size = new Size(60, 30);
        button1.TabIndex = 6;
        button1.Text = "Search";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        label4.Location = new Point(60, 413);
        label4.Name = "label4";
        label4.Size = new Size(131, 25);
        label4.TabIndex = 7;
        label4.Text = "5 DAY FORECAST:";
        // 
        // pictureBox2
        // 
        pictureBox2.Location = new Point(406, 241);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(50, 50);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 8;
        pictureBox2.TabStop = false;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        label5.Location = new Point(462, 254);
        label5.Name = "label5";
        label5.Size = new Size(129, 25);
        label5.TabIndex = 9;
        label5.Text = "CHANCE OF RAIN";
        label5.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Dubai", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
        label6.Location = new Point(566, 61);
        label6.Name = "label6";
        label6.Size = new Size(98, 64);
        label6.TabIndex = 10;
        label6.Text = "36.0";
        label6.TextAlign = ContentAlignment.MiddleCenter;
        label6.Click += label6_Click;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        label7.Location = new Point(576, 116);
        label7.Name = "label7";
        label7.Size = new Size(68, 25);
        label7.TabIndex = 11;
        label7.Text = "feels like";
        label7.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel1
        // 
        panel1.Controls.Add(label12);
        panel1.Controls.Add(label11);
        panel1.Controls.Add(label10);
        panel1.Controls.Add(label9);
        panel1.Controls.Add(label8);
        panel1.Controls.Add(pictureBox7);
        panel1.Controls.Add(pictureBox6);
        panel1.Controls.Add(pictureBox5);
        panel1.Controls.Add(pictureBox4);
        panel1.Controls.Add(pictureBox3);
        panel1.Location = new Point(67, 445);
        panel1.Name = "panel1";
        panel1.Size = new Size(875, 172);
        panel1.TabIndex = 12;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(748, 130);
        label12.Name = "label12";
        label12.Size = new Size(55, 22);
        label12.TabIndex = 9;
        label12.Text = "loading...";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(572, 130);
        label11.Name = "label11";
        label11.Size = new Size(55, 22);
        label11.TabIndex = 8;
        label11.Text = "loading...";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(392, 130);
        label10.Name = "label10";
        label10.Size = new Size(36, 22);
        label10.TabIndex = 7;
        label10.Text = "day3";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(204, 130);
        label9.Name = "label9";
        label9.Size = new Size(36, 22);
        label9.TabIndex = 6;
        label9.Text = "day2";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(14, 130);
        label8.Name = "label8";
        label8.Size = new Size(44, 22);
        label8.TabIndex = 5;
        label8.Text = "Today";
        // 
        // pictureBox7
        // 
        pictureBox7.Location = new Point(748, 17);
        pictureBox7.Name = "pictureBox7";
        pictureBox7.Size = new Size(100, 100);
        pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox7.TabIndex = 4;
        pictureBox7.TabStop = false;
        // 
        // pictureBox6
        // 
        pictureBox6.Location = new Point(572, 17);
        pictureBox6.Name = "pictureBox6";
        pictureBox6.Size = new Size(100, 100);
        pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox6.TabIndex = 3;
        pictureBox6.TabStop = false;
        // 
        // pictureBox5
        // 
        pictureBox5.Location = new Point(392, 17);
        pictureBox5.Name = "pictureBox5";
        pictureBox5.Size = new Size(100, 100);
        pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox5.TabIndex = 2;
        pictureBox5.TabStop = false;
        // 
        // pictureBox4
        // 
        pictureBox4.Location = new Point(204, 17);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new Size(100, 100);
        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox4.TabIndex = 1;
        pictureBox4.TabStop = false;
        // 
        // pictureBox3
        // 
        pictureBox3.Location = new Point(14, 17);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(100, 100);
        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox3.TabIndex = 0;
        pictureBox3.TabStop = false;
        // 
        // Weather
        // 
        AutoScaleMode = AutoScaleMode.Inherit;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1162, 640);
        Controls.Add(panel1);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(pictureBox2);
        Controls.Add(label4);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(pictureBox1);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 4, 3, 4);
        Name = "Weather";
        Text = "Weather";
        WindowState = FormWindowState.Maximized;
        Load += Weather_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private PictureBox pictureBox1;
    private Label label2;
    private Label label3;
    private TextBox textBox1;
    private Button button1;
    private Label label4;
    private PictureBox pictureBox2;
    private Label label5;
    private Label label6;
    private Label label7;
    private Panel panel1;
    private PictureBox pictureBox7;
    private PictureBox pictureBox6;
    private PictureBox pictureBox5;
    private PictureBox pictureBox4;
    private PictureBox pictureBox3;
    private Label label8;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
}