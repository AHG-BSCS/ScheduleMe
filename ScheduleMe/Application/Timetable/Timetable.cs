using System.Net;
using System.Net.NetworkInformation;

namespace ScheduleMe.Tab;

public partial class Timetable : Form
{
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


        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://cdngate.api.vldz.tk/1a/sched/all");
        if (IsInternetConnected() == true)
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
        }

        else
        {
            MessageBox.Show("Cannot reach VLDZ API, please check your network connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            HttpClient client = new HttpClient();
            string url_calix = "https://api.vldz.tk/" + sector + "/sched/all";
            client.BaseAddress = new Uri(url_calix);
            if (IsInternetConnected() == true)
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
            }
        }
        else if (comboBox2.SelectedIndex == 1)
        {
            sector = "1b";
            HttpClient client = new HttpClient();
            string url_calix = "https://api.vldz.tk/" + sector + "/sched/all";
            client.BaseAddress = new Uri(url_calix);
            if (IsInternetConnected() == true)
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
            }
        }
    }
}