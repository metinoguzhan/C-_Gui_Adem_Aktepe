using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69_radiobutton_kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (radioButton1.Checked)
            //{
            //    MessageBox.Show(radioButton1.Text);
            //}
            //else
            //{
            //    MessageBox.Show(radioButton2.Text);
            //}


            foreach (Control ctrl in panel1.Controls)
            {
                RadioButton radioButton = (RadioButton) (ctrl);
                if (radioButton.Checked)
                {
                    MessageBox.Show(radioButton.Text);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control panel2Control in panel2.Controls)
            {
                RadioButton radioButton = (RadioButton) panel2Control;
                if (radioButton.Checked)
                {
                    MessageBox.Show(radioButton.Text);
                }
            }
        }
    }
}
