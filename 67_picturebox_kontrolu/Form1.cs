﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _67_picturebox_kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = new Bitmap(@"F:\Egitim\.Net Dersleri\AdemAktepe\resimler\manzara.jpg");
            pictureBox1.Load(@"F:\Egitim\.Net Dersleri\AdemAktepe\resimler\manzara.jpg");
        }
    }
}
