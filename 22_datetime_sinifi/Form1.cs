using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_datetime_sinifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString();
            //label1.Text = DateTime.Now.Add(TimeSpan.FromDays(3)).ToString();
            //label1.Text = DateTime.Now.AddDays(3).ToString();
            //label1.Text = DateTime.Now.AddMonths(3).ToString();
            //label1.Text = DateTime.Now.AddHours(-3).ToString();

            //TimeSpan trh = new TimeSpan(16,30,50);
            //label1.Text = DateTime.Now.Add(trh).ToString();


            //label1.Text = DateTime.Now.Day.ToString();
            //label1.Text = DateTime.Now.Month.ToString();
            //label1.Text = DateTime.Now.Year.ToString();

            //label1.Text = DateTime.Now.DayOfYear.ToString();
            //label1.Text = DateTime.Now.DayOfWeek.ToString();

            //label1.Text = DateTime.Now.ToShortDateString();
            //label1.Text = DateTime.Now.ToShortTimeString();

            label1.Text = DateTime.Now.ToLongDateString();
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
