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

namespace _39_encoding_encoding_info_sinifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EncodingInfo[] kodlamalar = Encoding.GetEncodings();
            foreach (EncodingInfo kodlama in kodlamalar)
            {
                listBox1.Items.Add(kodlama.CodePage + " - " + kodlama.DisplayName + " - " + kodlama.Name);
            }

            Encoding tr = Encoding.GetEncoding("utf-8");
            StreamReader sr = new StreamReader(@"F:\Egitim\.Net Dersleri\AdemAktepe\CSharpGui\39_encoding_encoding_info_sinifi\data\data.txt",tr);
            string veriler = sr.ReadToEnd();
            textBox1.Text = veriler;
            sr.Close();

        }
    }
}
