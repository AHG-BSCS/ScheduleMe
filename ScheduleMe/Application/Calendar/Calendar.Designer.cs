﻿namespace ScheduleMe.Tab;

partial class Calendar
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
        monthCalendar1 = new MonthCalendar();
        SuspendLayout();
        // 
        // monthCalendar1
        // 
        monthCalendar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        monthCalendar1.CalendarDimensions = new Size(4, 3);
        monthCalendar1.Location = new Point(0, 0);
        monthCalendar1.Name = "monthCalendar1";
        monthCalendar1.TabIndex = 0;
        monthCalendar1.DateChanged += monthCalendar1_DateChanged;
        // 
        // Calendar
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(978, 566);
        Controls.Add(monthCalendar1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Calendar";
        Text = "Calendar";
        ResumeLayout(false);
    }

    #endregion

    private MonthCalendar monthCalendar1;
}