using System.Net;
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

    private async void Weather_Load(object sender, EventArgs e)
    {

    }

    private async void button1_Click(object sender, EventArgs e)
    {
        HttpClient client = new HttpClient();
        var url_calix = "https://api.weatherapi.com/v1/current.json?key=168c66e6792c4e7dbe5122918232305&q=" + textBox1.Text + "&aqi=no";
        client.BaseAddress = new Uri(url_calix);
        HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
        string result = await response.Content.ReadAsStringAsync();
        dynamic post = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

        pictureBox1.Image = new Bitmap(new MemoryStream(new WebClient().DownloadData("https:" + post.current.condition.icon)));
        label2.Text = post.current.condition.text;
        label3.Text = post.location.name + ", " + post.location.region;
    }
}
