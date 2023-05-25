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
        components = new System.ComponentModel.Container();
        eventsInfoTLPanel = new TableLayoutPanel();
        rowMenu = new ContextMenuStrip(components);
        deleteOption = new ToolStripMenuItem();
        endDatePicker = new DateTimePicker();
        startDatePicker = new DateTimePicker();
        descriptionTBox = new TextBox();
        titleTBox = new TextBox();
        colorPickerBtn = new Button();
        colorDialog = new ColorDialog();
        eventsInfoTLPanel.SuspendLayout();
        rowMenu.SuspendLayout();
        SuspendLayout();
        // 
        // eventsInfoTLPanel
        // 
        eventsInfoTLPanel.BackColor = Color.Transparent;
        eventsInfoTLPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        eventsInfoTLPanel.ColumnCount = 5;
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        eventsInfoTLPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
        eventsInfoTLPanel.ContextMenuStrip = rowMenu;
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
        eventsInfoTLPanel.Size = new Size(1000, 30);
        eventsInfoTLPanel.TabIndex = 0;
        // 
        // rowMenu
        // 
        rowMenu.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        rowMenu.Items.AddRange(new ToolStripItem[] { deleteOption });
        rowMenu.Name = "timelineOption";
        rowMenu.Size = new Size(116, 30);
        rowMenu.Text = "Option";
        rowMenu.ItemClicked += rowMenu_ItemClicked;
        // 
        // deleteOption
        // 
        deleteOption.Name = "deleteOption";
        deleteOption.Size = new Size(115, 26);
        deleteOption.Text = "Delete";
        // 
        // endDatePicker
        // 
        endDatePicker.ContextMenuStrip = rowMenu;
        endDatePicker.CustomFormat = "MMM dd, yyyy hh:MM tt";
        endDatePicker.Dock = DockStyle.Fill;
        endDatePicker.Format = DateTimePickerFormat.Custom;
        endDatePicker.Location = new Point(792, 1);
        endDatePicker.Margin = new Padding(0);
        endDatePicker.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        endDatePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        endDatePicker.Name = "endDatePicker";
        endDatePicker.RightToLeft = RightToLeft.No;
        endDatePicker.ShowUpDown = true;
        endDatePicker.Size = new Size(170, 29);
        endDatePicker.TabIndex = 0;
        endDatePicker.TabStop = false;
        endDatePicker.ValueChanged += endDatePicker_ValueChanged;
        // 
        // startDatePicker
        // 
        startDatePicker.ContextMenuStrip = rowMenu;
        startDatePicker.CustomFormat = "MMM dd, yyyy hh:MM tt";
        startDatePicker.Dock = DockStyle.Fill;
        startDatePicker.Format = DateTimePickerFormat.Custom;
        startDatePicker.Location = new Point(621, 1);
        startDatePicker.Margin = new Padding(0);
        startDatePicker.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        startDatePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        startDatePicker.Name = "startDatePicker";
        startDatePicker.RightToLeft = RightToLeft.No;
        startDatePicker.ShowUpDown = true;
        startDatePicker.Size = new Size(170, 29);
        startDatePicker.TabIndex = 0;
        startDatePicker.TabStop = false;
        startDatePicker.ValueChanged += startDatePicker_ValueChanged;
        // 
        // descriptionTBox
        // 
        descriptionTBox.BackColor = Color.White;
        descriptionTBox.BorderStyle = BorderStyle.None;
        descriptionTBox.ContextMenuStrip = rowMenu;
        descriptionTBox.Dock = DockStyle.Fill;
        descriptionTBox.Location = new Point(223, 4);
        descriptionTBox.Margin = new Padding(5, 3, 3, 3);
        descriptionTBox.Name = "descriptionTBox";
        descriptionTBox.Size = new Size(394, 22);
        descriptionTBox.TabIndex = 0;
        descriptionTBox.TabStop = false;
        // 
        // titleTBox
        // 
        titleTBox.BackColor = Color.White;
        titleTBox.BorderStyle = BorderStyle.None;
        titleTBox.ContextMenuStrip = rowMenu;
        titleTBox.Dock = DockStyle.Fill;
        titleTBox.Location = new Point(6, 4);
        titleTBox.Margin = new Padding(5, 3, 3, 3);
        titleTBox.Name = "titleTBox";
        titleTBox.Size = new Size(208, 22);
        titleTBox.TabIndex = 0;
        titleTBox.TabStop = false;
        // 
        // colorPickerBtn
        // 
        colorPickerBtn.BackColor = Color.FromArgb(15, 76, 129);
        colorPickerBtn.ContextMenuStrip = rowMenu;
        colorPickerBtn.FlatAppearance.BorderSize = 0;
        colorPickerBtn.ForeColor = Color.White;
        colorPickerBtn.Location = new Point(969, 3);
        colorPickerBtn.Margin = new Padding(6, 2, 0, 0);
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
        ContextMenuStrip = rowMenu;
        Controls.Add(eventsInfoTLPanel);
        Name = "AddEventRow";
        Size = new Size(1000, 30);
        eventsInfoTLPanel.ResumeLayout(false);
        eventsInfoTLPanel.PerformLayout();
        rowMenu.ResumeLayout(false);
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
    private ContextMenuStrip rowMenu;
    private ToolStripMenuItem deleteOption;
}
