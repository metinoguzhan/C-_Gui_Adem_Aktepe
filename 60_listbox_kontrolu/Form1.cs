using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _60_listbox_kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;

            bool sonuc = listBox1.Items.Contains(aranan);
            int yeri = listBox1.Items.IndexOf(aranan);

            if (sonuc)
            {
                MessageBox.Show("aranan değer mevcuttur..Index : " + yeri.ToString());
            }
            else
            {
                MessageBox.Show("aranan değer mevcut değildir. Index : " + yeri.ToString());
            }
        }
    }
}
