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

        private void button2_Click(object sender, EventArgs e)
        {
            Form calendar = new Calendar();
            calendar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form note = new Note();
            note.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form timeline = new Timeline();
            timeline.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form timetable = new Timetable();
            timetable.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form weather = new Weather();
            weather.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}