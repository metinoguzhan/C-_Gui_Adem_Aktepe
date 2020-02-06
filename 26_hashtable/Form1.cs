using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_hashtable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hashtable liste = new Hashtable();
            liste.Add("isim","adem");
            liste.Add("soyisim","aktepe");
            liste.Add("yas",29);

            liste["adres"] = "İstanbul";
            bool result = liste.ContainsKey("soyisim");
            MessageBox.Show(result.ToString());

            bool result2 = liste.ContainsValue("aktepe");
            MessageBox.Show(result2.ToString());

            MessageBox.Show(liste["adres"].ToString());

            foreach (DictionaryEntry list in liste)
            {
                MessageBox.Show(list.Key.ToString()+" - "+list.Value.ToString());
            }

            liste.Remove("adres");

            foreach (DictionaryEntry list in liste)
            {
                listBox1.Items.Add(list.Key + " : " + list.Value);
            }

        }
    }
}
