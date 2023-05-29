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
        logoScheduleMe = new PictureBox();
        lblScheduleMe = new Label();
        lblVersion = new Label();
        lblProjectType = new Label();
        lblDeveloper = new Label();
        linklblGithub = new LinkLabel();
        lblSection = new Label();
        ((System.ComponentModel.ISupportInitialize)logoScheduleMe).BeginInit();
        SuspendLayout();
        // 
        // logoScheduleMe
        // 
        logoScheduleMe.Image = Properties.Resources.scheduleme_it2_logo;
        logoScheduleMe.Location = new Point(12, 12);
        logoScheduleMe.Name = "logoScheduleMe";
        logoScheduleMe.Size = new Size(160, 160);
        logoScheduleMe.SizeMode = PictureBoxSizeMode.Zoom;
        logoScheduleMe.TabIndex = 0;
        logoScheduleMe.TabStop = false;
        // 
        // lblScheduleMe
        // 
        lblScheduleMe.AutoSize = true;
        lblScheduleMe.Font = new Font("Dubai", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
        lblScheduleMe.Location = new Point(189, 11);
        lblScheduleMe.Name = "lblScheduleMe";
        lblScheduleMe.Size = new Size(161, 45);
        lblScheduleMe.TabIndex = 1;
        lblScheduleMe.Text = "ScheduleMe";
        // 
        // lblVersion
        // 
        lblVersion.AutoSize = true;
        lblVersion.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        lblVersion.Location = new Point(194, 61);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new Size(89, 22);
        lblVersion.TabIndex = 2;
        lblVersion.Text = "version dev-gh";
        // 
        // lblProjectType
        // 
        lblProjectType.AutoSize = true;
        lblProjectType.Font = new Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        lblProjectType.Location = new Point(194, 111);
        lblProjectType.Name = "lblProjectType";
        lblProjectType.Size = new Size(132, 21);
        lblProjectType.TabIndex = 3;
        lblProjectType.Text = "Final Project of ITEC 103";
        // 
        // lblDeveloper
        // 
        lblDeveloper.AutoSize = true;
        lblDeveloper.Font = new Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        lblDeveloper.Location = new Point(194, 90);
        lblDeveloper.Name = "lblDeveloper";
        lblDeveloper.Size = new Size(160, 21);
        lblDeveloper.TabIndex = 4;
        lblDeveloper.Text = "Developed By Al Hans Gaming";
        // 
        // linklblGithub
        // 
        linklblGithub.AutoSize = true;
        linklblGithub.Cursor = Cursors.Hand;
        linklblGithub.Font = new Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        linklblGithub.Location = new Point(194, 151);
        linklblGithub.Name = "linklblGithub";
        linklblGithub.Size = new Size(179, 21);
        linklblGithub.TabIndex = 5;
        linklblGithub.TabStop = true;
        linklblGithub.Text = "https://github.com/AHG-BSCS1A";
        // 
        // lblSection
        // 
        lblSection.AutoSize = true;
        lblSection.Font = new Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        lblSection.Location = new Point(194, 132);
        lblSection.Name = "lblSection";
        lblSection.Size = new Size(94, 21);
        lblSection.TabIndex = 6;
        lblSection.Text = "LSPU - BSCS 1A";
        // 
        // About
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White;
        ClientSize = new Size(393, 196);
        Controls.Add(lblSection);
        Controls.Add(linklblGithub);
        Controls.Add(lblDeveloper);
        Controls.Add(lblProjectType);
        Controls.Add(lblVersion);
        Controls.Add(lblScheduleMe);
        Controls.Add(logoScheduleMe);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "About";
        StartPosition = FormStartPosition.CenterParent;
        Text = "About ScheduleMe";
        TopMost = true;
        FormClosing += About_FormClosing;
        ((System.ComponentModel.ISupportInitialize)logoScheduleMe).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox logoScheduleMe;
    private Label lblScheduleMe;
    private Label lblVersion;
    private Label lblProjectType;
    private Label lblDeveloper;
    private LinkLabel linklblGithub;
    private Label lblSection;
}