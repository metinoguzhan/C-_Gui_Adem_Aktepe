using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47_try_catch_finally
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int sonuc = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                MessageBox.Show("Sonuc : " + sonuc);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lütfen Sayı Giriniz : " + ex.ToString());
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Sıfıra bölemezsiniz : " + ex.ToString());
            }
            finally
            {
                MessageBox.Show("işlem başarılı");
            }
            
            
        }
    }
}
