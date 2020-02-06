using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using digersiniflar;



namespace _19_namespace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sinif1 s1 = new Sinif1();
            digersiniflar.Sinif2 s2 = new digersiniflar.Sinif2();
        }
    }

    interface IYapilacaklar
    {
        string donder(string adi, string soyadi);

        void donderme();
    }

    class Kisi : IYapilacaklar
    {
        public string donder(string adi, string soyadi)
        {
            return adi + soyadi;
        }

        public void donderme()
        {
        
        }

        void deneme()
        {

        }
    }
}


namespace digersiniflar
{
    class Sinif1
    {

    }

    class Sinif2
    {

    }

}