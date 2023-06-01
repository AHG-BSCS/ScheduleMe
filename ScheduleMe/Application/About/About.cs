using System.Diagnostics;

namespace ScheduleMe.Tab
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/AHG-BSCS1A/ScheduleMe";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
