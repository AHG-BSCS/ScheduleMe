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
            this.logoScheduleMe = new System.Windows.Forms.PictureBox();
            this.lblScheduleMe = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblProjectType = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.linklblGithub = new System.Windows.Forms.LinkLabel();
            this.lblSection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoScheduleMe)).BeginInit();
            this.SuspendLayout();
            // 
            // logoScheduleMe
            // 
            this.logoScheduleMe.Image = global::ScheduleMe.Properties.Resources.scheduleme_it2_logo;
            this.logoScheduleMe.Location = new System.Drawing.Point(12, 12);
            this.logoScheduleMe.Name = "logoScheduleMe";
            this.logoScheduleMe.Size = new System.Drawing.Size(160, 160);
            this.logoScheduleMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoScheduleMe.TabIndex = 0;
            this.logoScheduleMe.TabStop = false;
            // 
            // lblScheduleMe
            // 
            this.lblScheduleMe.AutoSize = true;
            this.lblScheduleMe.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScheduleMe.Location = new System.Drawing.Point(189, 11);
            this.lblScheduleMe.Name = "lblScheduleMe";
            this.lblScheduleMe.Size = new System.Drawing.Size(202, 57);
            this.lblScheduleMe.TabIndex = 1;
            this.lblScheduleMe.Text = "ScheduleMe";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.Location = new System.Drawing.Point(194, 61);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(116, 29);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "version dev-gh";
            // 
            // lblProjectType
            // 
            this.lblProjectType.AutoSize = true;
            this.lblProjectType.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProjectType.Location = new System.Drawing.Point(194, 111);
            this.lblProjectType.Name = "lblProjectType";
            this.lblProjectType.Size = new System.Drawing.Size(166, 25);
            this.lblProjectType.TabIndex = 3;
            this.lblProjectType.Text = "Final Project of ITEC 103";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeveloper.Location = new System.Drawing.Point(194, 90);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(200, 25);
            this.lblDeveloper.TabIndex = 4;
            this.lblDeveloper.Text = "Developed By Al Hans Gaming";
            // 
            // linklblGithub
            // 
            this.linklblGithub.AutoSize = true;
            this.linklblGithub.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linklblGithub.Location = new System.Drawing.Point(194, 151);
            this.linklblGithub.Name = "linklblGithub";
            this.linklblGithub.Size = new System.Drawing.Size(223, 25);
            this.linklblGithub.TabIndex = 5;
            this.linklblGithub.TabStop = true;
            this.linklblGithub.Text = "https://github.com/AHG-BSCS1A";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSection.Location = new System.Drawing.Point(194, 132);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(115, 25);
            this.lblSection.TabIndex = 6;
            this.lblSection.Text = "LSPU - BSCS 1A";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 196);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.linklblGithub);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.lblProjectType);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblScheduleMe);
            this.Controls.Add(this.logoScheduleMe);
            this.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About ScheduleMe";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoScheduleMe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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