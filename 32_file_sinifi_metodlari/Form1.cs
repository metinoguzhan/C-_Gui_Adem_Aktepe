using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_file_sinifi_metodlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = File.Create(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme\ilkdosya.txt");
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme\ilkdosya.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Move(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme\ilkdosya.txt", @"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme\klasor\ilkdosya.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.Copy(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme\ilkdosya.txt", @"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme\klasor\ilkdosya_copy.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool result = File.Exists(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme\ilkdosya.txt");
            if (result)
            {
                MessageBox.Show("Dosya mevcut");
            }
            else
            {
                MessageBox.Show("Dosya mevcut değil");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
           string yazilar = File.ReadAllText(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme\ilkdosya.txt");
           richTextBox1.Text = yazilar;

        }
    }
}
