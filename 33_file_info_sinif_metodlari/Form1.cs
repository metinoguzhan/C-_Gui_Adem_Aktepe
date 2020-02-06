using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _33_file_info_sinif_metodlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo dosya = new FileInfo(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme\ilkdosya.txt");
            listBox1.Items.Add("Dosyanın Klasörü : " + dosya.DirectoryName);
            listBox1.Items.Add("Dosyanın uzantısı : " + dosya.Extension);
            listBox1.Items.Add("Dosya boyutu : " + (double) dosya.Length / 1024);
            listBox1.Items.Add("Dosya var mı : " + dosya.Exists);
            listBox1.Items.Add("Dosyanın Tam Yolu :" + dosya.FullName);
            listBox1.Items.Add("Dosyanın Adı : " + dosya.Name);
        }
    }
}
