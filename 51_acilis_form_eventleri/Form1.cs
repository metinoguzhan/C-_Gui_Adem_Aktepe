using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _51_acilis_form_eventleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Load Event");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Form Shown Event");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("Form Paint Event");
        }

        private void Form1_BindingContextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Form Binding Context Event");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Form Actived Event");
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Form VisibleChanged Event");
        }
    }
}
