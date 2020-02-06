using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_degisken_sayida_parametre_alan_metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atama("adem","mehmet","hasan","hüseyin","kemal");
        }

        void atama(params string[] isimler)
        {
            foreach (var isim in isimler)
            {
                listBox1.Items.Add(isim);
            }
        }
    }
}
