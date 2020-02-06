using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string adi;
        private const string author = "Metin Oguzhan";

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            string adi;
            adi = "Metin";
            string soyad = "Oğuzhan";

            int yas = 21;
            byte Yasi = 34;
            sbyte YAsi = -15;
            uint YASI = 566; 

            double ondalikli_sayi = 10.5;
            
            
            bool medeni = true;
            */

            string name = "adem";
            string surname = "aktepe";
            string fullname = name +" "+ surname;
            lblFullName.Text = fullname;

            int sayi1 = 20;
            int sayi2 = 30;
            int sonuc = sayi1 + sayi2;
            lblResult.Text = sonuc.ToString();
            adi = "mehmet";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adi = "ahmet";
            lblButton.Text = author;

        }
    }
}
