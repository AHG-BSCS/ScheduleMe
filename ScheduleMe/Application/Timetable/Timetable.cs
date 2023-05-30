using System;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using LiteDB;

namespace ScheduleMe.Tab
{
    public partial class Timetable : Form
    {
        private LiteDatabase db;

        public Timetable()
        {
            InitializeComponent();
        }

        string sector = "";

        private bool IsInternetConnected()
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send("api.vldz.tk", 1000); // Replace with a reliable host address
                    return (reply != null && reply.Status == IPStatus.Success);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async void Timetable_Load(object sender, EventArgs e)
        {
            db = new LiteDatabase(DBConnection.databaseConnection);

            var collection = db.GetCollection<TimetableData>("timetable");

            var savedData = collection.FindById(1);

            if (savedData != null)
            {
                label10.Text = savedData.Monday;
                label11.Text = savedData.Tuesday;
                label12.Text = savedData.Wednesday;
                label13.Text = savedData.Thursday;
                label14.Text = savedData.Friday;
                label15.Text = savedData.Saturday;
                label16.Text = savedData.Sunday;
            }

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.vldz.tk/1a/sched/all");

            if (IsInternetConnected())
            {
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                string result = await response.Content.ReadAsStringAsync();
                dynamic post = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

                label10.Text = post.data.monday;
                label11.Text = post.data.tuesday;
                label12.Text = post.data.wednesday;
                label13.Text = post.data.thursday;
                label14.Text = post.data.friday;
                label15.Text = post.data.saturday;
                label16.Text = post.data.sunday;

                // Save the data to the database
                var timetableData = new TimetableData
                {
                    Id = 1,
                    Monday = label10.Text,
                    Tuesday = label11.Text,
                    Wednesday = label12.Text,
                    Thursday = label13.Text,
                    Friday = label14.Text,
                    Saturday = label15.Text,
                    Sunday = label16.Text
                };

                collection.Upsert(timetableData);
            }
            else if (savedData == null)
            {
                MessageBox.Show("Cannot reach VLDZ API, and no saved data found in the database. Please check your network connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //combobox choices
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("BSCS1A");
                comboBox2.Items.Add("BSCS1B");

                comboBox2.SelectedIndex = 0;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                sector = "1a";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                sector = "1b";
            }

            HttpClient client = new HttpClient();
            string url_calix = "https://api.vldz.tk/" + sector + "/sched/all";
            client.BaseAddress = new Uri(url_calix);

            if (IsInternetConnected())
            {
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                string result = await response.Content.ReadAsStringAsync();
                dynamic post = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

                label10.Text = post.data.monday;
                label11.Text = post.data.tuesday;
                label12.Text = post.data.wednesday;
                label13.Text = post.data.thursday;
                label14.Text = post.data.friday;
                label15.Text = post.data.saturday;
                label16.Text = post.data.sunday;

                // Save the data to the database
                var timetableData = new TimetableData
                {
                    Id = comboBox2.SelectedIndex + 1,
                    Monday = label10.Text,
                    Tuesday = label11.Text,
                    Wednesday = label12.Text,
                    Thursday = label13.Text,
                    Friday = label14.Text,
                    Saturday = label15.Text,
                    Sunday = label16.Text
                };

                var collection = db.GetCollection<TimetableData>("timetable");
                collection.Upsert(timetableData);
            }
            else
            {
                // Check if there is saved data in the database for the selected section
                var collection = db.GetCollection<TimetableData>("timetable");
                var savedData = collection.FindById(comboBox2.SelectedIndex + 1);

                if (savedData != null)
                {
                    label10.Text = savedData.Monday;
                    label11.Text = savedData.Tuesday;
                    label12.Text = savedData.Wednesday;
                    label13.Text = savedData.Thursday;
                    label14.Text = savedData.Friday;
                    label15.Text = savedData.Saturday;
                    label16.Text = savedData.Sunday;
                }
                else
                {
                    MessageBox.Show("Cannot reach VLDZ API, and no saved data found in the database. Please check your network connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
    public class TimetableData
    {
        public int Id { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
    }
}