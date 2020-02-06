using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUzunluk_Click(object sender, EventArgs e)
        {
            //string deger = String.Format("Textbox içerisine girdiğiniz değer uzunluğu : {0}", tbxBilgi.Text.Length);
            //MessageBox.Show(deger);

            MessageBox.Show(tbxBilgi.Text.Length.ToString());
        }

        private void btnBuyuk_Click(object sender, EventArgs e)
        {
            tbxBilgi.Text = tbxBilgi.Text.ToUpper();
        }

        private void btnKucuk_Click(object sender, EventArgs e)
        {
            tbxBilgi.Text = tbxBilgi.Text.ToLower();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxBilgi.Text.StartsWith("http://"))
            {
                MessageBox.Show("Adres Doğru");
            }
            else
            {
                MessageBox.Show("Adres Yanlış");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbxBilgi.Text.EndsWith(".com"))
            {
                MessageBox.Show("Adres Doğru");
            }
            else
            {
                MessageBox.Show("Adres Yanlış");
            }
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbxBilgi.Text.Substring(0, 3));
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            tbxBilgi.Text = tbxBilgi.Text.Replace('a', 'A');
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            tbxBilgi.Text = tbxBilgi.Text.Insert(tbxBilgi.Text.Length, " Bey");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            tbxBilgi.Text = tbxBilgi.Text.Remove(0, tbxBilgi.Text.Length);
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbxBilgi.Text.IndexOf(' ').ToString());
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbxBilgi.Text.LastIndexOf(' ').ToString());
        }

        private void btnConcate_Click(object sender, EventArgs e)
        {
            string metin = " Bey";
            tbxBilgi.Text = String.Concat(tbxBilgi.Text, metin);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string[] kelimeler = tbxBilgi.Text.Split(' ');
            foreach (var kelime in kelimeler)
            {
                MessageBox.Show(kelime);
            }
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            if (tbxBilgi.Text.Contains("https://") || tbxBilgi.Text.Contains(".com"))
            {
                MessageBox.Show("Internet adresi");
            }
            else
            {
                MessageBox.Show("Maalesef, eksik bilgi");
            }
        }

        private void btnPadRight_Click(object sender, EventArgs e)
        {
            tbxBilgi.Text = tbxBilgi.Text.PadRight(10, '-');
        }

        private void btnPadLeft_Click(object sender, EventArgs e)
        {
            tbxBilgi.Text = tbxBilgi.Text.PadLeft(10, '-');
        }
    }
}
