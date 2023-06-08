namespace ScheduleMe.Tab;

partial class Note
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
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        dataGridView1 = new DataGridView();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        label3 = new Label();
        label2 = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new Point(509, 40);
        textBox1.Margin = new Padding(3, 2, 3, 2);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(303, 29);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(509, 107);
        textBox2.Margin = new Padding(3, 2, 3, 2);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(303, 297);
        textBox2.TabIndex = 3;
        // 
        // dataGridView1
        // 
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 11);
        dataGridView1.Margin = new Padding(3, 2, 3, 2);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.Height = 29;
        dataGridView1.Size = new Size(473, 320);
        dataGridView1.TabIndex = 6;
        dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        // 
        // button1
        // 
        button1.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        button1.Location = new Point(14, 347);
        button1.Margin = new Padding(3, 2, 3, 2);
        button1.Name = "button1";
        button1.Size = new Size(82, 27);
        button1.TabIndex = 7;
        button1.Text = "LOAD";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        button2.Location = new Point(277, 347);
        button2.Margin = new Padding(3, 2, 3, 2);
        button2.Name = "button2";
        button2.Size = new Size(82, 27);
        button2.TabIndex = 8;
        button2.Text = "DELETE";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        button3.Location = new Point(102, 347);
        button3.Margin = new Padding(3, 2, 3, 2);
        button3.Name = "button3";
        button3.Size = new Size(82, 27);
        button3.TabIndex = 9;
        button3.Text = "SAVE";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        button4.Location = new Point(189, 347);
        button4.Margin = new Padding(3, 2, 3, 2);
        button4.Name = "button4";
        button4.Size = new Size(82, 27);
        button4.TabIndex = 10;
        button4.Text = "NEW NOTE";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // label3
        // 
        label3.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        label3.Location = new Point(509, 86);
        label3.Name = "label3";
        label3.Size = new Size(330, 19);
        label3.TabIndex = 5;
        label3.Text = "Content:";
        label3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Font = new Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(509, 11);
        label2.Name = "label2";
        label2.Size = new Size(303, 19);
        label2.TabIndex = 4;
        label2.Text = "Title:";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Note
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(1000, 550);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(dataGridView1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Note";
        Text = "Note";
        Load += Note_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox textBox1;
    private TextBox textBox2;
    private DataGridView dataGridView1;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Label label3;
    private Label label2;
}