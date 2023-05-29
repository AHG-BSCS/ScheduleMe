namespace ScheduleMe.Tab;

partial class Message
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
        lblMessage = new Label();
        btnOk = new Button();
        pnlSpace = new Panel();
        pnlSpace.SuspendLayout();
        SuspendLayout();
        // 
        // lblMessage
        // 
        lblMessage.Dock = DockStyle.Top;
        lblMessage.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblMessage.ForeColor = Color.White;
        lblMessage.Location = new Point(0, 5);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new Size(145, 22);
        lblMessage.TabIndex = 1;
        lblMessage.Text = "Message";
        lblMessage.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnOk
        // 
        btnOk.BackColor = Color.White;
        btnOk.Cursor = Cursors.Hand;
        btnOk.Dock = DockStyle.Fill;
        btnOk.FlatAppearance.BorderSize = 0;
        btnOk.FlatStyle = FlatStyle.Flat;
        btnOk.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        btnOk.Location = new Point(40, 0);
        btnOk.Margin = new Padding(0);
        btnOk.Name = "btnOk";
        btnOk.Size = new Size(65, 30);
        btnOk.TabIndex = 0;
        btnOk.TabStop = false;
        btnOk.Text = "Ok";
        btnOk.UseVisualStyleBackColor = false;
        btnOk.Click += btnOk_Click;
        // 
        // pnlSpace
        // 
        pnlSpace.BackColor = Color.Transparent;
        pnlSpace.Controls.Add(btnOk);
        pnlSpace.Dock = DockStyle.Bottom;
        pnlSpace.Location = new Point(0, 41);
        pnlSpace.Name = "pnlSpace";
        pnlSpace.Padding = new Padding(40, 0, 40, 0);
        pnlSpace.Size = new Size(145, 30);
        pnlSpace.TabIndex = 0;
        // 
        // Message
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        BackColor = SystemColors.ControlDarkDark;
        ClientSize = new Size(145, 79);
        Controls.Add(pnlSpace);
        Controls.Add(lblMessage);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Message";
        Padding = new Padding(0, 5, 0, 8);
        StartPosition = FormStartPosition.CenterParent;
        pnlSpace.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Label lblMessage;
    private Button btnOk;
    private Panel pnlSpace;
}