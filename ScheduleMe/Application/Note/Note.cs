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

            db = new LiteDatabase(DBConnection.databaseConnection_note);
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
            string title = textBox1.Text;
            string note = textBox2.Text;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(note))
            {
                MessageBox.Show("Title and Note cannot be empty.");
                return;
            }

            if (editing)
            {
                notes.Rows[dataGridView1.CurrentCell.RowIndex]["Title"] = title;
                notes.Rows[dataGridView1.CurrentCell.RowIndex]["Note"] = note;

                var columnDataCollection = db.GetCollection<ColumnData>("columnData");
                var data = columnDataCollection.FindById(dataGridView1.CurrentCell.RowIndex + 1);
                if (data != null)
                {
                    data.Title = title;
                    data.Note = note;
                    columnDataCollection.Update(data);
                }
            }
            else
            {
                notes.Rows.Add(title, note);

                var columnDataCollection = db.GetCollection<ColumnData>("columnData");
                var data = new ColumnData
                {
                    Title = title,
                    Note = note
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
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (rowIndex >= 0 && rowIndex < notes.Rows.Count)
            {
                // Delete from the DataTable
                notes.Rows[rowIndex].Delete();

                // Delete from the LiteDB database
                var columnDataCollection = db.GetCollection<ColumnData>("columnData");

                if (rowIndex < columnDataCollection.Count())
                {
                    var data = columnDataCollection.FindById(rowIndex + 1);

                    if (data != null)
                    {
                        columnDataCollection.Delete(data.Id);
                    }
                }

                // Refresh the DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = notes;
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = notes.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
                textBox2.Text = notes.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
                editing = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("You really can't open a blank file can you");
            }
        }

    }
}
