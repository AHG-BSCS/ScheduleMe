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
        pictureBox1.Image = Properties.Resources.scheduleme;
        pictureBox1.Location = new Point(28, 41);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(164, 161);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(198, 41);
        label1.Name = "label1";
        label1.Size = new Size(234, 50);
        label1.TabIndex = 1;
        label1.Text = "ScheduleMe";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(208, 91);
        label2.Name = "label2";
        label2.Size = new Size(80, 20);
        label2.TabIndex = 2;
        label2.Text = "Version 1.0";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(208, 142);
        label3.Name = "label3";
        label3.Size = new Size(253, 20);
        label3.TabIndex = 3;
        label3.Text = "Final Project of BS Computer Science";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(208, 162);
        label4.Name = "label4";
        label4.Size = new Size(213, 20);
        label4.TabIndex = 4;
        label4.Text = "Developed By Al Hans Gaming";
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Location = new Point(212, 215);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(227, 20);
        linkLabel1.TabIndex = 5;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "https://github.com/AHG-BSCS1A";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // form_about
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(506, 270);
        Controls.Add(linkLabel1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        Name = "form_about";
        StartPosition = FormStartPosition.CenterParent;
        Text = "About ScheduleMe";
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