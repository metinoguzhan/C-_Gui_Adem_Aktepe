using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _64_monthcalendar_kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar4_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("Seçili Tarih : " + monthCalendar4.SelectionRange.Start.ToString("dd-MM-yyyy"));
        }
    }
}
