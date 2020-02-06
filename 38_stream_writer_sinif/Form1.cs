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

namespace _38_stream_writer_sinif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter yaz = new StreamWriter(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\38_stream_writer_sinif\data\data.txt");
            yaz.Write("Deneme");
            yaz.WriteLine("2. yazı");
            yaz.Write("3. yazı");
            yaz.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter yaz = new StreamWriter(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\38_stream_writer_sinif\data\data.txt", true);
            yaz.WriteLine("Son satirlari eklendi..");
            yaz.WriteLine("2. Son satirlari eklendi..");
            yaz.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter yaz = new StreamWriter(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\38_stream_writer_sinif\data\data.txt", true);
            yaz.AutoFlush = true;
            yaz.WriteLine("Metin Oğuzhan");
            //yaz.Flush();
            yaz.WriteLine("Adem Aktepe");
            //yaz.Close();
        }
    }
}
