namespace ScheduleMe.Tab;

partial class EventContainer
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
        panelEvent = new Panel();
        SuspendLayout();
        // 
        // panelEvent
        // 
        panelEvent.Location = new Point(3, 3);
        panelEvent.Name = "panelEvent";
        panelEvent.Size = new Size(200, 46);
        panelEvent.TabIndex = 0;
        panelEvent.Paint += panelEvent_Paint;
        // 
        // EventContainer
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        Controls.Add(panelEvent);
        Name = "EventContainer";
        Size = new Size(208, 58);
        ResumeLayout(false);
    }

    #endregion

    private Panel panelEvent;
}
