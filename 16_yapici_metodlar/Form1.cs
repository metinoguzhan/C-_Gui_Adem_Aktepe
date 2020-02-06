using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_yapici_metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci("Metin","Oğuzhan",21);
            MessageBox.Show(ogr1.adi+" "+ ogr1.soyadi);
            MessageBox.Show(ogr1.yas.ToString());
        }
    }

    class Ogrenci
    {
        public string adi;
        public string soyadi;
        public int yas;

        public Ogrenci()
        {
            this.adi = "";
            this.soyadi = "";
            this.yas = 0;
        }
        public Ogrenci(string adi, string soyadi, int yas)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.yas = yas;
        }
    }
}
