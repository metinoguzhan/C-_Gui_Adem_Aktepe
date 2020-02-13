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

namespace _43_folder_browser_dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] dosyalar = directoryInfo.GetFiles();

                DirectoryInfo[] klasorler = directoryInfo.GetDirectories();

                //Klasorleri Listeleme
                foreach (DirectoryInfo info in klasorler)
                {
                    listBox1.Items.Add(info.Name);
                }

                //Dosyaları listeleme
                foreach (FileInfo dosya in dosyalar)
                {
                    listBox1.Items.Add(dosya.Name);
                }
            }
        }
    }
}
