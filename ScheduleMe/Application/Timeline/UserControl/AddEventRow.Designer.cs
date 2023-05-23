namespace ScheduleMe.Tab;

partial class AddEventRow
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
        eventsInfoTLPanel = new TableLayoutPanel();
        endDatePicker = new DateTimePicker();
        startDatePicker = new DateTimePicker();
        descriptionTBox = new TextBox();
        titleTBox = new TextBox();
        colorPickerBtn = new Button();
        colorDialog = new ColorDialog();
        eventsInfoTLPanel.SuspendLayout();
        SuspendLayout();
        // 
        // eventsInfoTLPanel
        // 
        eventsInfoTLPanel.BackColor = Color.Transparent;
        eventsInfoTLPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        eventsInfoTLPanel.ColumnCount = 5;
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
        eventsInfoTLPanel.Controls.Add(endDatePicker, 3, 0);
        eventsInfoTLPanel.Controls.Add(startDatePicker, 2, 0);
        eventsInfoTLPanel.Controls.Add(descriptionTBox, 1, 0);
        eventsInfoTLPanel.Controls.Add(titleTBox, 0, 0);
        eventsInfoTLPanel.Controls.Add(colorPickerBtn, 4, 0);
        eventsInfoTLPanel.Dock = DockStyle.Fill;
        eventsInfoTLPanel.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        eventsInfoTLPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        eventsInfoTLPanel.Location = new Point(0, 0);
        eventsInfoTLPanel.Margin = new Padding(0);
        eventsInfoTLPanel.Name = "eventsInfoTLPanel";
        eventsInfoTLPanel.RowCount = 1;
        eventsInfoTLPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        eventsInfoTLPanel.Size = new Size(1000, 31);
        eventsInfoTLPanel.TabIndex = 0;
        // 
        // endDatePicker
        // 
        endDatePicker.CustomFormat = "MMM dd, yyyy hh:MM tt";
        endDatePicker.Dock = DockStyle.Fill;
        endDatePicker.Format = DateTimePickerFormat.Custom;
        endDatePicker.Location = new Point(752, 1);
        endDatePicker.Margin = new Padding(0);
        endDatePicker.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        endDatePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        endDatePicker.Name = "endDatePicker";
        endDatePicker.RightToLeft = RightToLeft.No;
        endDatePicker.ShowUpDown = true;
        endDatePicker.Size = new Size(200, 29);
        endDatePicker.TabIndex = 0;
        endDatePicker.TabStop = false;
        // 
        // startDatePicker
        // 
        startDatePicker.CustomFormat = "MMM dd, yyyy hh:MM tt";
        startDatePicker.Dock = DockStyle.Fill;
        startDatePicker.Format = DateTimePickerFormat.Custom;
        startDatePicker.Location = new Point(551, 1);
        startDatePicker.Margin = new Padding(0);
        startDatePicker.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        startDatePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        startDatePicker.Name = "startDatePicker";
        startDatePicker.RightToLeft = RightToLeft.No;
        startDatePicker.ShowUpDown = true;
        startDatePicker.Size = new Size(200, 29);
        startDatePicker.TabIndex = 0;
        startDatePicker.TabStop = false;
        // 
        // descriptionTBox
        // 
        descriptionTBox.BackColor = Color.White;
        descriptionTBox.BorderStyle = BorderStyle.None;
        descriptionTBox.Dock = DockStyle.Fill;
        descriptionTBox.Location = new Point(226, 5);
        descriptionTBox.Margin = new Padding(5, 4, 3, 3);
        descriptionTBox.Name = "descriptionTBox";
        descriptionTBox.Size = new Size(321, 22);
        descriptionTBox.TabIndex = 0;
        descriptionTBox.TabStop = false;
        // 
        // titleTBox
        // 
        titleTBox.BackColor = Color.White;
        titleTBox.BorderStyle = BorderStyle.None;
        titleTBox.Dock = DockStyle.Fill;
        titleTBox.Location = new Point(6, 5);
        titleTBox.Margin = new Padding(5, 4, 3, 3);
        titleTBox.Name = "titleTBox";
        titleTBox.Size = new Size(211, 22);
        titleTBox.TabIndex = 0;
        titleTBox.TabStop = false;
        // 
        // colorPickerBtn
        // 
        colorPickerBtn.BackColor = Color.Transparent;
        colorPickerBtn.FlatAppearance.BorderSize = 0;
        colorPickerBtn.ForeColor = Color.White;
        colorPickerBtn.Location = new Point(964, 4);
        colorPickerBtn.Margin = new Padding(11, 3, 0, 0);
        colorPickerBtn.Name = "colorPickerBtn";
        colorPickerBtn.Size = new Size(23, 23);
        colorPickerBtn.TabIndex = 0;
        colorPickerBtn.TabStop = false;
        colorPickerBtn.UseVisualStyleBackColor = false;
        colorPickerBtn.Click += colorPickerBtn_Click;
        // 
        // AddEventRow
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White;
        Controls.Add(eventsInfoTLPanel);
        Name = "AddEventRow";
        Size = new Size(1000, 31);
        eventsInfoTLPanel.ResumeLayout(false);
        eventsInfoTLPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel eventsInfoTLPanel;
    private TextBox titleTBox;
    private TextBox descriptionTBox;
    private DateTimePicker startDatePicker;
    private DateTimePicker endDatePicker;
    private ColorDialog colorDialog;
    private Button colorPickerBtn;
}
