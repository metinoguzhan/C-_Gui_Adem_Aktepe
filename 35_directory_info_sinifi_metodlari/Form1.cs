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

namespace _35_directory_info_sinifi_metodlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo klasor = new DirectoryInfo(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme");
            FileInfo[] dosyalar = klasor.GetFiles();
            foreach (FileInfo dosya in dosyalar)
            {
                listBox1.Items.Add(dosya.Name + " - " + dosya.CreationTime);
            }

            DirectoryInfo[] klasorler = klasor.GetDirectories();
            foreach (DirectoryInfo klasors in klasorler)
            {
                listBox2.Items.Add(klasors.Name + " - " + klasors.CreationTime);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo klasor = new DirectoryInfo(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme");
            klasor.CreateSubdirectory("alt klasor");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo klasor = new DirectoryInfo(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme");
            MessageBox.Show(klasor.Parent.Name);
        }
    }
}
