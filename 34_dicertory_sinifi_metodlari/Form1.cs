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

namespace _34_dicertory_sinifi_metodlari
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
            Directory.CreateDirectory(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme\yeniklasor");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string [] liste = Directory.GetDirectories(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme","v*");
            listBox1.Items.AddRange(liste);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string [] files = Directory.GetFiles(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme","*.txt");

            foreach (var file in files)
            {
                listBox2.Items.Add(file);
            }
          
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetDirectoryRoot(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetParent(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\32_file_sinifi_metodlari\deneme\klasor").ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] logicalDrivers = Directory.GetLogicalDrives();
            string drivers = "";
            foreach (var logicalDriver in logicalDrivers)
            {
                drivers += logicalDriver + "\n";
            }
            MessageBox.Show(drivers);
        }
    }
}
