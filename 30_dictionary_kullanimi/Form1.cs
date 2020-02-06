using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_dictionary_kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string,string> liste = new Dictionary<string, string>();
            liste.Add("adi","adem");
            liste.Add("soyadi","aktepe");


            MessageBox.Show(liste["adi"].ToString());
            //MessageBox.Show(liste["yasi"].ToString());

            string sonuc = "";

            if (liste.TryGetValue("yasi",out sonuc) == true)
            {
                MessageBox.Show(liste["yasi"].ToString());
            }
            else
            {
                MessageBox.Show("Girilen key bilgisi bulunmamaktadır.");
            }
        }
    }
}
