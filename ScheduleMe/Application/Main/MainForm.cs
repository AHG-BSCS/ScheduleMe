using ScheduleMe.Tab;

namespace ScheduleMe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}