namespace ScheduleMe.Tab;

partial class Timeline
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
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        tabControl1.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        tabControl1.Location = new Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(850, 550);
        tabControl1.TabIndex = 2;
        // 
        // tabPage1
        // 
        tabPage1.BackColor = Color.White;
        tabPage1.Location = new Point(4, 31);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(842, 515);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Genshin Impact";
        // 
        // tabPage2
        // 
        tabPage2.BackColor = Color.White;
        tabPage2.Location = new Point(4, 31);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(842, 515);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "CCS Week";
        // 
        // Timeline
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White;
        ClientSize = new Size(850, 550);
        Controls.Add(tabControl1);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 4, 3, 4);
        Name = "Timeline";
        Text = "Timeline";
        WindowState = FormWindowState.Maximized;
        tabControl1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
}