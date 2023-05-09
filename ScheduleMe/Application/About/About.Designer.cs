namespace ScheduleMe.Tab;

partial class About
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
        pictureBox1 = new PictureBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        linkLabel1 = new LinkLabel();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.scheduleme_it2_logo;
        pictureBox1.Location = new Point(12, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(144, 156);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Dubai", 24F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(162, 9);
        label1.Name = "label1";
        label1.Size = new Size(189, 54);
        label1.TabIndex = 1;
        label1.Text = "ScheduleMe";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(170, 50);
        label2.Name = "label2";
        label2.Size = new Size(68, 15);
        label2.TabIndex = 2;
        label2.Text = "Version 1.0";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(170, 102);
        label3.Name = "label3";
        label3.Size = new Size(211, 15);
        label3.TabIndex = 3;
        label3.Text = "Final Project of BS Computer Science";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(170, 124);
        label4.Name = "label4";
        label4.Size = new Size(174, 15);
        label4.TabIndex = 4;
        label4.Text = "Developed By Al Hans Gaming";
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
        linkLabel1.Location = new Point(170, 144);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(181, 15);
        linkLabel1.TabIndex = 5;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "https://github.com/AHG-BSCS1A";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // About
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White;
        ClientSize = new Size(399, 181);
        Controls.Add(linkLabel1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "About";
        Text = "About ScheduleMe";
        TopMost = true;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private LinkLabel linkLabel1;
}