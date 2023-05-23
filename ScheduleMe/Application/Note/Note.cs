using System.Data;

namespace ScheduleMe.Tab;

public partial class Note : Form
{

    private DataTable notes = new DataTable();
    private bool editing = false;
    
    public Note()
    {
        InitializeComponent();
    }

    private void Note_Load(object sender, EventArgs e)
    {
        notes.Columns.Add("Title");
        notes.Columns.Add("Note");
        dataGridView1.DataSource = notes;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text = notes.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
        textBox2.Text = notes.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
        editing = true;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (editing)
        {
            notes.Rows[dataGridView1.CurrentCell.RowIndex]["Title"] = textBox1.Text;
            notes.Rows[dataGridView1.CurrentCell.RowIndex]["Note"] = textBox2.Text;
        }
        else
            notes.Rows.Add(textBox1.Text, textBox2.Text);

        textBox1.Text = null;
        textBox2.Text = null;
        editing = false;
    }

    private void button4_Click(object sender, EventArgs e)
    {
        textBox1.Text = null;
        textBox2.Text = null;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        try {
            notes.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
        }
        catch (Exception exception) {
            MessageBox.Show(exception.Message);
        }
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        textBox1.Text = notes.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
        textBox2.Text = notes.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
        editing = true;
    }
}
