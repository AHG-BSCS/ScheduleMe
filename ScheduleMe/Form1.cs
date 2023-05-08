using ScheduleMe.panel;

namespace ScheduleMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form about = new form_about();
            about.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}