using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_sinif_tanimlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.adi = "Metin";
            ogr1.soyadi = "Oğuzhan";
            ogr1.yas = 34;
            ogr1.bolumu = "Bilgisayar Mühendisliği";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.adi = "Yüksel";
            ogr2.soyadi = "Yaşar";
            ogr2.yas = 33;
            ogr2.bolumu = "Yazılım";

            //Değer değiştirme
            ogr1.adi = ogr2.adi;
            ogr1.soyadi = ogr2.soyadi;

            //referans adresleri değiştirme
            ogr1 = ogr2;
            ogr2.bolumu = "Yazılım Mühendisliği";
            textBox1.Text = ogr1.adi + " " + ogr1.soyadi;
            textBox2.Text = ogr1.yas.ToString();
            textBox3.Text = ogr1.bolumu;
        }
    }

    public class Ogrenci
    {
        public string adi;
        public string soyadi;
        public int yas;
        public string bolumu;
    }
}
