using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_deger_dondurmeyen_metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mesajGoster();
            mesajCikar("Metin","Oğuzhan");
        }

        void mesajGoster()
        {
            MessageBox.Show(textBox1.Text);
        }

        void mesajCikar(string adi, string soyadi)
        {
            textBox1.Text = adi + " " + soyadi;
        }
    }
}
