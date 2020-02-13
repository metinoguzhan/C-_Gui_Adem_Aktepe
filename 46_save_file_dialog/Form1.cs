using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _46_save_file_dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.FileName = "Resimler";
            openFileDialog1.Filter = "Sadece jpeg dosyaları |*.jpg";
            openFileDialog1.InitialDirectory = "F:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string resimYolu = Path.GetFullPath(openFileDialog1.FileName);
                
                FileStream fs = new FileStream(resimYolu,FileMode.Open,FileAccess.Read);
                
                Bitmap resim = new Bitmap(fs);

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = resim;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Resmi Kaydet";
            saveFileDialog1.FileName = "Kaydet";
            saveFileDialog1.Filter = "Sadece jpeg dosyalar |*.jpg";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName,ImageFormat.Jpeg);
            }
        }
    }
}
