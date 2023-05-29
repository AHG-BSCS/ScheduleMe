namespace ScheduleMe.Tab;

partial class TimelineEvent
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
        components = new System.ComponentModel.Container();
        btnEvent = new Button();
        mnuEvent = new ContextMenuStrip(components);
        mnuDelete = new ToolStripMenuItem();
        mnuEvent.SuspendLayout();
        SuspendLayout();
        // 
        // btnEvent
        // 
        btnEvent.BackColor = Color.FromArgb(15, 76, 129);
        btnEvent.ContextMenuStrip = mnuEvent;
        btnEvent.Dock = DockStyle.Fill;
        btnEvent.FlatAppearance.BorderSize = 0;
        btnEvent.FlatStyle = FlatStyle.Flat;
        btnEvent.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
        btnEvent.ForeColor = Color.White;
        btnEvent.Location = new Point(0, 0);
        btnEvent.Name = "btnEvent";
        btnEvent.Size = new Size(68, 30);
        btnEvent.TabIndex = 0;
        btnEvent.TabStop = false;
        btnEvent.Text = "Event";
        btnEvent.UseVisualStyleBackColor = false;
        // 
        // mnuEvent
        // 
        mnuEvent.BackColor = SystemColors.Control;
        mnuEvent.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        mnuEvent.Items.AddRange(new ToolStripItem[] { mnuDelete });
        mnuEvent.Name = "timelineOption";
        mnuEvent.Size = new Size(181, 52);
        mnuEvent.Text = "Option";
        mnuEvent.ItemClicked += mnuEvent_ItemClicked;
        // 
        // mnuDelete
        // 
        mnuDelete.Image = Properties.Resources.Delete;
        mnuDelete.Name = "mnuDelete";
        mnuDelete.Size = new Size(180, 26);
        mnuDelete.Text = "Delete";
        // 
        // TimelineEvent
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = Color.White;
        Controls.Add(btnEvent);
        Margin = new Padding(0);
        Name = "TimelineEvent";
        Size = new Size(68, 30);
        mnuEvent.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Button btnEvent;
    private ContextMenuStrip mnuEvent;
    private ToolStripMenuItem mnuDelete;
}
