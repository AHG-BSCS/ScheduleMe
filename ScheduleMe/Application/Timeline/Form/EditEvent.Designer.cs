namespace ScheduleMe.Tab;

partial class EditEvent
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
        tab1 = new TabPage();
        tab2 = new TabPage();
        tabControl1.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tab1);
        tabControl1.Controls.Add(tab2);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Margin = new Padding(3, 4, 3, 4);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(800, 502);
        tabControl1.TabIndex = 0;
        tabControl1.TabStop = false;
        // 
        // tab1
        // 
        tab1.Location = new Point(4, 31);
        tab1.Margin = new Padding(3, 4, 3, 4);
        tab1.Name = "tab1";
        tab1.Padding = new Padding(3, 4, 3, 4);
        tab1.Size = new Size(792, 467);
        tab1.TabIndex = 0;
        tab1.Text = "Tab1";
        tab1.UseVisualStyleBackColor = true;
        // 
        // tab2
        // 
        tab2.Location = new Point(4, 31);
        tab2.Margin = new Padding(3, 4, 3, 4);
        tab2.Name = "tab2";
        tab2.Padding = new Padding(3, 4, 3, 4);
        tab2.Size = new Size(792, 467);
        tab2.TabIndex = 1;
        tab2.Text = "Tab2";
        tab2.UseVisualStyleBackColor = true;
        // 
        // EditEvent
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(800, 502);
        Controls.Add(tabControl1);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Margin = new Padding(3, 4, 3, 4);
        Name = "EditEvent";
        Text = "Edit Event";
        tabControl1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tab1;
    private TabPage tab2;
}