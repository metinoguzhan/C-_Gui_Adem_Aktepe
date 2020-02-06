using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_if_else_yapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gelen_deger = Convert.ToInt32(textBox1.Text);
            /*
            if ( gelen_deger > 10)
            {
                MessageBox.Show("Değer 10 dan büyük");
            }
            else
            {
                MessageBox.Show("Değer 10 dan küçük veya eşittir");
            }
            */

            if (gelen_deger > 10)
                MessageBox.Show("Değer 10 dan büyük");
            else if (gelen_deger < 10)
                MessageBox.Show("Değer 10 dan küçük");
            else
                MessageBox.Show("Değer 10 a eşit");
        }
    }
}
