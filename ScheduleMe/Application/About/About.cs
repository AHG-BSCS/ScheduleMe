using System.Diagnostics;

namespace ScheduleMe.Tab
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        public event EventHandler<FormClosedEventArgs> FormClosedEvent;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/AHG-BSCS1A/ScheduleMe";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, e);
        }

        private void About_Load(object sender, EventArgs e)
        {
        }
    }
}
