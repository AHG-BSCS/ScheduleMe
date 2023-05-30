using LiteDB;
using System.Data;
using System.Windows.Forms;

namespace ScheduleMe.Tab
{
    public partial class Note : Form
    {
        private DataTable notes = new DataTable();
        private bool editing = false;

        // Step 1: Establish a connection to the LiteDB database
        private LiteDatabase db;

        public Note()
        {
            InitializeComponent();
        }

        private void Note_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");
            dataGridView1.DataSource = notes;

            db = new LiteDatabase("myDatabase.db");
            var columnDataCollection = db.GetCollection<ColumnData>("columnData");
            var columnData = columnDataCollection.FindAll().ToList();

            foreach (var data in columnData)
            {
                notes.Rows.Add(data.Title, data.Note);
            }
        }

        public class ColumnData
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Note { get; set; }
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

                var columnDataCollection = db.GetCollection<ColumnData>("columnData");
                var data = columnDataCollection.FindById(dataGridView1.CurrentCell.RowIndex + 1);
                if (data != null)
                {
                    data.Title = textBox1.Text;
                    data.Note = textBox2.Text;
                    columnDataCollection.Update(data);
                }
            }
            else
            {
                notes.Rows.Add(textBox1.Text, textBox2.Text);

                var columnDataCollection = db.GetCollection<ColumnData>("columnData");
                var data = new ColumnData
                {
                    Title = textBox1.Text,
                    Note = textBox2.Text
                };
                columnDataCollection.Insert(data);
            }

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
            try
            {
                notes.Rows[dataGridView1.CurrentCell.RowIndex].Delete();

                var columnDataCollection = db.GetCollection<ColumnData>("columnData");
                columnDataCollection.Delete(dataGridView1.CurrentCell.RowIndex + 1);
            }
            catch (Exception exception)
            {
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
}
