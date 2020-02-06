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


namespace _37_streamreader_sinifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\37_streamreader_sinifi\data\ilkdosya.txt");
            //string veriler = sr.ReadToEnd();
            //textBox1.Text = veriler;
            //sr.Close();

            textBox1.Text = sr.ReadLine() +"\r\n";
            textBox1.Text += sr.ReadLine();


            while (!sr.EndOfStream)
                textBox2.Text += sr.ReadLine() + "\r\n";

            sr.Close();
        }
    }
}
