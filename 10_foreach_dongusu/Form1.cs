using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_foreach_dongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] isimler = {"Metin", "Emre", "Gökhan", "Ersin"};
            /*
            for (int i = 0; i < isimler.Length; i++)
            {
                MessageBox.Show(isimler[i]);
            }
            */

            foreach (var isim in isimler)
            {
                MessageBox.Show(isim);
            }
        }
    }
}
