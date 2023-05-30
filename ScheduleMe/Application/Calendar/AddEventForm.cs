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
    public partial class AddEventForm : Form
    {
        public AddEventForm()
        {
            InitializeComponent();
        }

        private void saveEventButton_Click(object sender, EventArgs e)
        {

        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            eventDateTxtBx.Text = Calendar.staticMonth + " / " + UserControlDays.staticDays.ToString() + " / " + Calendar.staticYear;
        }
    }
}
