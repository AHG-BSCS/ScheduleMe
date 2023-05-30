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
    public partial class UCMonthYearDisplay : UserControl
    {
        public UCMonthYearDisplay()
        {
            InitializeComponent();
        }

        private void UCMonthYearDisplay_Load(object sender, EventArgs e)
        {

        }

        public void MonthYearDetails(string nameMonth, int year)
        {
            monthYearLbl.Text = nameMonth + " " + year.ToString();
        }
    }
}
