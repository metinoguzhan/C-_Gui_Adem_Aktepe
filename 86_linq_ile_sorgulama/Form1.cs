using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _86_linq_ile_sorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] sayilar = {7, 1, 8, 2, 9, 3};

            //var sonuclar = from sayi in sayilar orderby sayi ascending select sayi;
            var sonuclar = from sayi in sayilar where sayi>4 orderby sayi ascending select sayi;

            foreach (var x in sonuclar)
            {
                listBox1.Items.Add(x.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 7, 1, 8, 2, 9, 3, 3, 9, 5, 4, 8, 3 };
            var sonuclar = (from sayi in sayilar select sayi).Distinct();

            foreach (var i in sonuclar)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int [] sayilar = { 7, 1, 8, 2, 9, 3, 3, 9, 5, 4, 8, 3, 7 };
            var sonuclar = (from sayi in sayilar where sayi.ToString().Contains("7") select sayi);

            foreach (var s in sonuclar)
            {
                listBox3.Items.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 7, 1, 8, 2, 9, 3, 3, 9, 5, 4, 8, 3, 7, 77 };
            var sonuc = (from sayi in sayilar where sayi.ToString().Contains("7") select sayi).Count();

            MessageBox.Show(sonuc.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 7, 1, 8, 2, 9, 3, 3, 9, 5, 4, 8, 3, 7, 77 };
            var sonuc = (from sayi in sayilar where sayi.ToString().Contains("7") select sayi).Max();

            MessageBox.Show(sonuc.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 7, 1, 8, 2, 9, 3, 3, 9, 5, 4, 8, 3, 7, 77 };
            var sonuc = (from sayi in sayilar where sayi.ToString().Contains("7") select sayi).Min();

            MessageBox.Show(sonuc.ToString());
        }
    }
}
