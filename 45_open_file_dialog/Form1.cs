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

namespace _45_open_file_dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Resim Seç";
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Sadece jpeg dosyalar |*.jpg";
            openFileDialog1.InitialDirectory = "E:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string resimYolu = Path.GetFullPath(openFileDialog1.FileName);
                FileStream fs = new FileStream(resimYolu,FileMode.Open,FileAccess.Read);

                Bitmap resim = new Bitmap(fs);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = resim;
            }
        }
    }
}
