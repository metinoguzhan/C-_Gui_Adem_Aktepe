﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace KaynakKodCekme
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
            WebClient wc = new WebClient();
            Stream oku = wc.OpenRead(textBox1.Text);
            StreamReader sr = new StreamReader(oku,Encoding.GetEncoding("utf-8"));

            richTextBox1.Text = sr.ReadToEnd();
        }
    }
}
