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
        var url_calix = "https://api.weatherapi.com/v1/forecast.json?key=168c66e6792c4e7dbe5122918232305&q=" + textBox1.Text + "&days=5&aqi=no";
        client.BaseAddress = new Uri(url_calix);
        if (IsInternetConnected() == true)
        {
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            string result = await response.Content.ReadAsStringAsync();
            dynamic post = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

            pictureBox1.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.current.condition.icon)));
            label2.Text = post.current.condition.text;
            label3.Text = post.location.name + ", " + post.location.region;
            label3.Location = new Point((this.Width - label3.Width) / 2, label3.Location.Y);

            //forecast

            pictureBox2.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.forecast.forecastday[0].day.condition.icon)));
            label5.Text = "Expect " + post.forecast.forecastday[0].day.condition.text + " with a " + post.forecast.forecastday[0].day.daily_chance_of_rain + "%" + " chance of rain";

            label6.Text = post.current.temp_c + "°C";
            label6.Location = new Point((this.Width - label6.Width) / 2, label6.Location.Y);

            label7.Text = "Feels like " + post.current.feelslike_c + "°C";
            label7.Location = new Point((this.Width - label7.Width) / 2, label7.Location.Y);

            //5day forecast
            try
            {
                pictureBox3.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.current.condition.icon)));
                label8.Text = post.forecast.forecastday[0].day.condition.text + "\n" + "TODAY";

                pictureBox4.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.forecast.forecastday[1].day.condition.icon)));
                label9.Text = post.forecast.forecastday[1].day.condition.text + "\n" + post.forecast.forecastday[1].date;

                pictureBox5.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.forecast.forecastday[2].day.condition.icon)));
                label10.Text = post.forecast.forecastday[2].day.condition.text + "\n" + post.forecast.forecastday[2].date;

                pictureBox6.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.forecast.forecastday[3].day.condition.icon)));
                label11.Text = post.forecast.forecastday[3].day.condition.text + "\n" + post.forecast.forecastday[3].date;

                pictureBox7.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.forecast.forecastday[4].day.condition.icon)));
                label12.Text = post.forecast.forecastday[4].day.condition.text + "\n" + post.forecast.forecastday[4].date;
            }
            catch
            {

            }
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
            var url_calix = "https://api.weatherapi.com/v1/forecast.json?key=168c66e6792c4e7dbe5122918232305&q=" + textBox1.Text + "&days=5&aqi=no";
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

            //5day forecast
            pictureBox3.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.current.condition.icon)));
            label8.Text = post.forecast.forecastday[0].day.condition.text + "\n" + "TODAY";

            pictureBox4.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.forecast.forecastday[1].day.condition.icon)));
            label9.Text = post.forecast.forecastday[1].day.condition.text + "\n" + post.forecast.forecastday[1].date;

            pictureBox5.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.forecast.forecastday[2].day.condition.icon)));
            label10.Text = post.forecast.forecastday[2].day.condition.text + "\n" + post.forecast.forecastday[2].date;

            pictureBox6.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.forecast.forecastday[3].day.condition.icon)));
            label11.Text = post.forecast.forecastday[3].day.condition.text + "\n" + post.forecast.forecastday[3].date;

            pictureBox7.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.forecast.forecastday[4].day.condition.icon)));
            label12.Text = post.forecast.forecastday[4].day.condition.text + "\n" + post.forecast.forecastday[4].date;
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.ToString());
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

    private void label6_Click(object sender, EventArgs e)
    {

    }
}
