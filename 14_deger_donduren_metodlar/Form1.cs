using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_deger_donduren_metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = topla().ToString();
            //textBox1.Text = topla2(10, 30).ToString();
            textBox1.Text = birlestir("Adem", "Aktepe");
        }

        int topla()
        {
            return 5;
        }

        int topla2(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        string birlestir(string isim, string soyisim)
        {
            return isim + " " + soyisim;
        }
    }
}
