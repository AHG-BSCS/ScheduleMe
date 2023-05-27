namespace ScheduleMe.Tab;

partial class Confirm
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
        btnYes = new Button();
        btnNo = new Button();
        SuspendLayout();
        // 
        // lblMessage
        // 
        lblMessage.AutoSize = true;
        lblMessage.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        lblMessage.ForeColor = Color.White;
        lblMessage.Location = new Point(28, 5);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new Size(89, 22);
        lblMessage.TabIndex = 0;
        lblMessage.Text = "Are You Sure?";
        // 
        // btnYes
        // 
        btnYes.BackColor = Color.FromArgb(255, 128, 128);
        btnYes.FlatAppearance.BorderSize = 0;
        btnYes.FlatStyle = FlatStyle.Flat;
        btnYes.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        btnYes.Location = new Point(12, 40);
        btnYes.Margin = new Padding(0);
        btnYes.Name = "btnYes";
        btnYes.Size = new Size(55, 30);
        btnYes.TabIndex = 0;
        btnYes.TabStop = false;
        btnYes.Text = "Yes";
        btnYes.UseVisualStyleBackColor = false;
        btnYes.Click += btnYes_Click;
        // 
        // btnNo
        // 
        btnNo.BackColor = Color.FromArgb(128, 128, 255);
        btnNo.FlatAppearance.BorderSize = 0;
        btnNo.FlatStyle = FlatStyle.Flat;
        btnNo.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        btnNo.Location = new Point(73, 40);
        btnNo.Margin = new Padding(0);
        btnNo.Name = "btnNo";
        btnNo.Size = new Size(55, 30);
        btnNo.TabIndex = 1;
        btnNo.TabStop = false;
        btnNo.Text = "No";
        btnNo.UseVisualStyleBackColor = false;
        btnNo.Click += btnNo_Click;
        // 
        // Confirm
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(15, 76, 129);
        ClientSize = new Size(140, 81);
        Controls.Add(btnNo);
        Controls.Add(btnYes);
        Controls.Add(lblMessage);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 4, 3, 4);
        Name = "Confirm";
        StartPosition = FormStartPosition.CenterParent;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblMessage;
    private Button btnYes;
    private Button btnNo;
}