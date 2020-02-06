using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_property_kavramlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.adi = "Metin";
            ogr.soyadi = "Oğuzhan";
            ogr.yas = 10;

            MessageBox.Show(ogr.adi + " " + ogr.soyadi + " " + ogr.yas.ToString());
        }
    }


    class Ogrenci
    {
        private string _adi;
        private string _soyadi;
        private int _yas;

        public string adi { get; set; }
        public string soyadi { get; set; }
        public int yas
        {
            get { return _yas; }
            set
            {
                if (value < 18)
                {
                    _yas = 99;
                }
                else
                {
                    _yas = value;
                }
            }
        }
    }
}
