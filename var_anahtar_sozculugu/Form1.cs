using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace var_anahtar_sozculugu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string isim = "Metin Oğuzhan";
            object x = "deneme";
            x = 99;

            var degisken = "Gökhan";
            //degisken = 199; HATA
        }
    }
}
