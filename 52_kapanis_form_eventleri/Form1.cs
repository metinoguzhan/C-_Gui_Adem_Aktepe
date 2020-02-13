using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52_kapanis_form_eventleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (DialogResult.Cancel == MessageBox.Show("Kapatmak istediğinize emin misiniz ?","Emin misiniz ?",MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
            //{
            //    e.Cancel = true;
            //}

            if (e.CloseReason == CloseReason.UserClosing)
            {
                MessageBox.Show("Kendiniz kapatamazsınız..");
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form Closed eventi");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            MessageBox.Show("Form Deactivate eventi");
        }
    }
}
