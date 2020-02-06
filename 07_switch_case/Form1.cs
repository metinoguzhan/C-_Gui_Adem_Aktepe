using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);

            switch (sayi)
            {
                case 5:
                    MessageBox.Show("Sayı 5");
                    break;
                case 10:
                    MessageBox.Show("Sayı 10");
                    break;
                default:
                    MessageBox.Show(textBox1.Text);
                    break;
            }
        }
    }
}
