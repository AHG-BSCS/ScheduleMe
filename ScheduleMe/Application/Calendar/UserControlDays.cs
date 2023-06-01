using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleMe.Tab
{
    public partial class UserControlDays : UserControl
    {
        public DateTime OwnDate { get; set; }
        public static string staticDays;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void Days(int numDay)
        {
            numDayLbl.Text = numDay.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            staticDays = numDayLbl.Text;
            AddEventForm eventForm = new AddEventForm();
            eventForm.EventDate = OwnDate;
            eventForm.ShowDialog();

        }
    }
}
