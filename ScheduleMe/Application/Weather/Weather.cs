using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Policy;
using static System.Net.WebRequestMethods;

namespace ScheduleMe.Tab;

public partial class Weather : Form
{
    public Weather()
    {
        InitializeComponent();
    }

    private bool IsInternetConnected()
    {
        try
        {
            using (Ping ping = new Ping())
            {
                PingReply reply = ping.Send("api.weatherapi.com", 1000); // Replace with a reliable host address
                return (reply != null && reply.Status == IPStatus.Success);
            }
        }
        catch (Exception)
        {
            return false;
        }
    }

    private async void Weather_Load(object sender, EventArgs e)
    {
        HttpClient client = new HttpClient();
        var url_calix = "https://api.weatherapi.com/v1/forecast.json?key=168c66e6792c4e7dbe5122918232305&q=" + textBox1.Text + "&days=1&aqi=no";
        client.BaseAddress = new Uri(url_calix);
        if (IsInternetConnected() == true)
        {
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            string result = await response.Content.ReadAsStringAsync();
            dynamic post = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

            pictureBox1.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.current.condition.icon)));
            label2.Text = post.current.condition.text;
            label3.Text = post.location.name + ", " + post.location.region;

            //forecast

            pictureBox2.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.forecast.forecastday[0].day.condition.icon)));
            label5.Text = "Expect " + post.forecast.forecastday[0].day.condition.text + " with a " + post.forecast.forecastday[0].day.daily_chance_of_rain + "%" + " chance of rain";
        }
        else
        {
            MessageBox.Show("Cannot reach Weather API, please check your network connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        try
        {
        HttpClient client = new HttpClient();
        var url_calix = "https://api.weatherapi.com/v1/forecast.json?key=168c66e6792c4e7dbe5122918232305&q=" + textBox1.Text + "&aqi=no";
        client.BaseAddress = new Uri(url_calix);
        HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
        string result = await response.Content.ReadAsStringAsync();
        dynamic post = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

        pictureBox1.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.current.condition.icon)));
        label2.Text = post.current.condition.text;
        label3.Text = post.location.name + ", " + post.location.region;

        //forecast

        pictureBox2.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.forecast.forecastday[0].day.condition.icon)));
        label5.Text = "Expect " + post.forecast.forecastday[0].day.condition.text + " with a " + post.forecast.forecastday[0].day.daily_chance_of_rain + "%" + " chance of rain";
        }
        catch (Exception )
        {
            MessageBox.Show("There is no such place named " + textBox1.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        }
    
    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        this.AcceptButton = button1;
    }

    private void label3_TextChanged(object sender, EventArgs e)
    {
        this.CenterToParent();
    }
}
