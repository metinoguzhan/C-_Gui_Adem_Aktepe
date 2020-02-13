using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48_throw_kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte sayi1 = Convert.ToByte(textBox1.Text);
            byte sayi2 = Convert.ToByte(textBox2.Text);


            if (sayi2>100)
            {
                try
                {
                    throw  new OverflowException("100' den büyük sayı girme");
                }
                catch (OverflowException exception)
                {
                    MessageBox.Show(exception.ToString());
                }
                finally
                {
                    MessageBox.Show("İşlem Başarılı");
                }
            }
        }
    }
}
