namespace ScheduleMe.Tab;

partial class EditTimelineRow
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
        pnlEventRow = new TableLayoutPanel();
        mnuEventRow = new ContextMenuStrip(components);
        mnuDelete = new ToolStripMenuItem();
        pckEndDate = new DateTimePicker();
        pckStartDate = new DateTimePicker();
        txtDescription = new TextBox();
        txtTitle = new TextBox();
        btnColorPicker = new Button();
        colEventColor = new ColorDialog();
        pnlEventRow.SuspendLayout();
        mnuEventRow.SuspendLayout();
        SuspendLayout();
        // 
        // pnlEventRow
        // 
        pnlEventRow.BackColor = Color.Transparent;
        pnlEventRow.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        pnlEventRow.ColumnCount = 5;
        pnlEventRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        pnlEventRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        pnlEventRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        pnlEventRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        pnlEventRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
        pnlEventRow.ContextMenuStrip = mnuEventRow;
        pnlEventRow.Controls.Add(pckEndDate, 3, 0);
        pnlEventRow.Controls.Add(pckStartDate, 2, 0);
        pnlEventRow.Controls.Add(txtDescription, 1, 0);
        pnlEventRow.Controls.Add(txtTitle, 0, 0);
        pnlEventRow.Controls.Add(btnColorPicker, 4, 0);
        pnlEventRow.Dock = DockStyle.Fill;
        pnlEventRow.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        pnlEventRow.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        pnlEventRow.Location = new Point(0, 0);
        pnlEventRow.Margin = new Padding(0);
        pnlEventRow.Name = "pnlEventRow";
        pnlEventRow.RowCount = 1;
        pnlEventRow.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        pnlEventRow.Size = new Size(1000, 30);
        pnlEventRow.TabIndex = 0;
        // 
        // mnuEventRow
        // 
        mnuEventRow.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        mnuEventRow.Items.AddRange(new ToolStripItem[] { mnuDelete });
        mnuEventRow.Name = "timelineOption";
        mnuEventRow.Size = new Size(116, 30);
        mnuEventRow.Text = "Option";
        mnuEventRow.ItemClicked += mnuEventRow_ItemClicked;
        // 
        // mnuDelete
        // 
        mnuDelete.Name = "mnuDelete";
        mnuDelete.Size = new Size(115, 26);
        mnuDelete.Text = "Delete";
        // 
        // pckEndDate
        // 
        pckEndDate.ContextMenuStrip = mnuEventRow;
        pckEndDate.Cursor = Cursors.Hand;
        pckEndDate.CustomFormat = "MMM dd, yyyy hh:MM tt";
        pckEndDate.Dock = DockStyle.Fill;
        pckEndDate.Format = DateTimePickerFormat.Custom;
        pckEndDate.Location = new Point(792, 1);
        pckEndDate.Margin = new Padding(0);
        pckEndDate.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        pckEndDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        pckEndDate.Name = "pckEndDate";
        pckEndDate.RightToLeft = RightToLeft.No;
        pckEndDate.ShowUpDown = true;
        pckEndDate.Size = new Size(170, 29);
        pckEndDate.TabIndex = 0;
        pckEndDate.TabStop = false;
        pckEndDate.ValueChanged += pckEndDate_ValueChanged;
        // 
        // pckStartDate
        // 
        pckStartDate.ContextMenuStrip = mnuEventRow;
        pckStartDate.Cursor = Cursors.Hand;
        pckStartDate.CustomFormat = "MMM dd, yyyy hh:MM tt";
        pckStartDate.Dock = DockStyle.Fill;
        pckStartDate.Format = DateTimePickerFormat.Custom;
        pckStartDate.Location = new Point(621, 1);
        pckStartDate.Margin = new Padding(0);
        pckStartDate.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
        pckStartDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        pckStartDate.Name = "pckStartDate";
        pckStartDate.RightToLeft = RightToLeft.No;
        pckStartDate.ShowUpDown = true;
        pckStartDate.Size = new Size(170, 29);
        pckStartDate.TabIndex = 0;
        pckStartDate.TabStop = false;
        pckStartDate.ValueChanged += pckStartDate_ValueChanged;
        // 
        // txtDescription
        // 
        txtDescription.BackColor = Color.White;
        txtDescription.BorderStyle = BorderStyle.None;
        txtDescription.ContextMenuStrip = mnuEventRow;
        txtDescription.Cursor = Cursors.IBeam;
        txtDescription.Dock = DockStyle.Fill;
        txtDescription.Location = new Point(223, 4);
        txtDescription.Margin = new Padding(5, 3, 3, 3);
        txtDescription.MaxLength = 128;
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(394, 22);
        txtDescription.TabIndex = 0;
        txtDescription.TabStop = false;
        // 
        // txtTitle
        // 
        txtTitle.BackColor = Color.White;
        txtTitle.BorderStyle = BorderStyle.None;
        txtTitle.ContextMenuStrip = mnuEventRow;
        txtTitle.Cursor = Cursors.IBeam;
        txtTitle.Dock = DockStyle.Fill;
        txtTitle.Location = new Point(6, 4);
        txtTitle.Margin = new Padding(5, 3, 3, 3);
        txtTitle.MaxLength = 64;
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(208, 22);
        txtTitle.TabIndex = 0;
        txtTitle.TabStop = false;
        // 
        // btnColorPicker
        // 
        btnColorPicker.BackColor = Color.FromArgb(15, 76, 129);
        btnColorPicker.ContextMenuStrip = mnuEventRow;
        btnColorPicker.Cursor = Cursors.Hand;
        btnColorPicker.FlatAppearance.BorderSize = 0;
        btnColorPicker.ForeColor = Color.White;
        btnColorPicker.Location = new Point(969, 3);
        btnColorPicker.Margin = new Padding(6, 2, 0, 0);
        btnColorPicker.Name = "btnColorPicker";
        btnColorPicker.Size = new Size(23, 23);
        btnColorPicker.TabIndex = 0;
        btnColorPicker.TabStop = false;
        btnColorPicker.UseVisualStyleBackColor = false;
        btnColorPicker.Click += btnColorPicker_Click;
        // 
        // colEventColor
        // 
        colEventColor.AnyColor = true;
        colEventColor.Color = Color.FromArgb(15, 76, 129);
        colEventColor.SolidColorOnly = true;
        // 
        // EditTimelineRow
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White;
        ContextMenuStrip = mnuEventRow;
        Controls.Add(pnlEventRow);
        Name = "EditTimelineRow";
        Size = new Size(1000, 30);
        pnlEventRow.ResumeLayout(false);
        pnlEventRow.PerformLayout();
        mnuEventRow.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel pnlEventRow;
    private TextBox txtTitle;
    private TextBox txtDescription;
    private DateTimePicker pckStartDate;
    private DateTimePicker pckEndDate;
    private ColorDialog colEventColor;
    private Button btnColorPicker;
    private ContextMenuStrip mnuEventRow;
    private ToolStripMenuItem mnuDelete;
}
