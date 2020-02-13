using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _53_klavye_eventleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 27)
            //{
            //    MessageBox.Show("Esc tuşuna bastınız..");
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.KeyCode == Keys.F7)
            //{
            //    MessageBox.Show("ctrl + f7' ye bastınız");
            //}
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F7)
            {
                MessageBox.Show("ctrl + f7' ye basıp elinizi çektiniz.");
            }
        }
    }
}
