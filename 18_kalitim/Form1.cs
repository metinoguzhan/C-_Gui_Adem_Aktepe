using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Okul okl = new Okul();
            okl.OkulAdi = "İstiklal";
            okl.OgrenciSayisi = 600;

            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Metin";
            ogr.Yas = 21;
            ogr.OgrenciSayisi = 400;
            ogr.OkulAdi = "Vali Cahit Bayar";

            MessageBox.Show(ogr.OkulAdi);
        }
    }

    class Okul
    {
        public string OkulAdi;
        public int OgrenciSayisi;
    }

    class Ogrenci:Okul
    {
        public string Adi;
        public int Yas;
    }

}
