using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _71_textbox_kontrolu
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Cut();
            textBox3.Paste();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            count += 1;
            label1.Text = textBox4.Text;
            label2.Text = count.ToString();
        }
    }
}
