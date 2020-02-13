using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54_button_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 1 tıklandı");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
    }
}
