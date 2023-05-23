namespace ScheduleMe.Tab;

public partial class Timetable : Form
{
    public Timetable()
    {
        InitializeComponent();
    }

    private async void Timetable_Load(object sender, EventArgs e)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://api.vldz.tk/1a/sched/all");
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

    private void label10_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }
}
