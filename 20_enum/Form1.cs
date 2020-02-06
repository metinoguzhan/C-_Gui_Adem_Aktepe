using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(gunler.Perşembe.ToString());
            MessageBox.Show(((gunler)6).ToString());
        }

        enum gunler
        {
            Pazartesi = 1,Salı = 2 ,Çarşamba = 3,Perşembe = 4,Cuma = 5,Cumartesi = 7,Pazar = 6
        }
    }
}
