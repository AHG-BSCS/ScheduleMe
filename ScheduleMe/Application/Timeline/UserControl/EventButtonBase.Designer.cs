﻿namespace ScheduleMe.Tab;

partial class EventButtonBase
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
        editOption = new ToolStripMenuItem();
        addOption = new ToolStripMenuItem();
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
        eventName.FlatAppearance.MouseDownBackColor = Color.Transparent;
        eventName.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        eventName.FlatStyle = FlatStyle.Flat;
        eventName.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
        eventName.ForeColor = Color.White;
        eventName.Location = new Point(0, 0);
        eventName.Name = "eventName";
        eventName.Size = new Size(65, 30);
        eventName.TabIndex = 0;
        eventName.Text = "Event";
        eventName.UseVisualStyleBackColor = false;
        // 
        // eventButtonMenu
        // 
        eventButtonMenu.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        eventButtonMenu.Items.AddRange(new ToolStripItem[] { editOption, addOption, deleteOption });
        eventButtonMenu.Name = "timelineOption";
        eventButtonMenu.Size = new Size(116, 82);
        eventButtonMenu.Text = "Option";
        // 
        // editOption
        // 
        editOption.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        editOption.Name = "editOption";
        editOption.Size = new Size(180, 26);
        editOption.Text = "Edit";
        // 
        // addOption
        // 
        addOption.Name = "addOption";
        addOption.Size = new Size(180, 26);
        addOption.Text = "Add";
        // 
        // deleteOption
        // 
        deleteOption.Name = "deleteOption";
        deleteOption.Size = new Size(180, 26);
        deleteOption.Text = "Delete";
        // 
        // EventButtonBase
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = Color.White;
        Controls.Add(eventName);
        Margin = new Padding(0);
        Name = "EventButtonBase";
        Padding = new Padding(0, 0, 3, 0);
        Size = new Size(68, 30);
        eventButtonMenu.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Button eventName;
    private ContextMenuStrip eventButtonMenu;
    private ToolStripMenuItem editOption;
    private ToolStripMenuItem addOption;
    private ToolStripMenuItem deleteOption;
}
