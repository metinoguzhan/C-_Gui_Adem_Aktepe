using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_tur_donusumleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //short sayi1 = 12;
            //int sayi2 = 88888;

            //sayi2 = sayi1;

            int sayi = Convert.ToInt32(textBox1.Text);
            MessageBox.Show(sayi.ToString());

            int x = 5;
            string isim = Convert.ToString(x);
        }
    }
}
