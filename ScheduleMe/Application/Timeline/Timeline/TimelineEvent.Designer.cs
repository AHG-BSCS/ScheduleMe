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
        eventName = new Button();
        eventButtonMenu = new ContextMenuStrip(components);
        deleteOption = new ToolStripMenuItem();
        eventButtonMenu.SuspendLayout();
        SuspendLayout();
        // 
        // eventName
        // 
        eventName.BackColor = Color.FromArgb(15, 76, 129);
        eventName.ContextMenuStrip = eventButtonMenu;
        eventName.Dock = DockStyle.Fill;
        eventName.FlatAppearance.BorderSize = 0;
        eventName.FlatStyle = FlatStyle.Flat;
        eventName.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
        eventName.ForeColor = Color.White;
        eventName.Location = new Point(0, 0);
        eventName.Name = "eventName";
        eventName.Size = new Size(68, 30);
        eventName.TabIndex = 0;
        eventName.TabStop = false;
        eventName.Text = "Event";
        eventName.UseVisualStyleBackColor = false;
        // 
        // eventButtonMenu
        // 
        eventButtonMenu.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        eventButtonMenu.Items.AddRange(new ToolStripItem[] { deleteOption });
        eventButtonMenu.Name = "timelineOption";
        eventButtonMenu.Size = new Size(116, 30);
        eventButtonMenu.Text = "Option";
        eventButtonMenu.ItemClicked += eventButtonMenu_ItemClicked;
        // 
        // deleteOption
        // 
        deleteOption.Name = "deleteOption";
        deleteOption.Size = new Size(115, 26);
        deleteOption.Text = "Delete";
        // 
        // EventButton
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = Color.White;
        Controls.Add(eventName);
        Margin = new Padding(0);
        Name = "EventButton";
        Size = new Size(68, 30);
        eventButtonMenu.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Button eventName;
    private ContextMenuStrip eventButtonMenu;
    private ToolStripMenuItem deleteOption;
}
