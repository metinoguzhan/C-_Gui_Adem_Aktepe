using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] names = {"adem", "aykut", "yüksel"};
            int[] sayilar = {4, 5, 8, 6};
            
            string[] okullar = new string[4];
            okullar[0] = "Vali Cahit Bayar İO";
            okullar[1] = "Barbaros Anadolu Lisesi";
            okullar[2] = "İstiklal";
            okullar[3] = "M. Kemal";

            MessageBox.Show(okullar[2]);

            cmbOkullar.Items.AddRange(okullar);
        }
    }
}
