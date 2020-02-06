using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stack liste = new Stack();
            liste.Push("kemal");
            liste.Push("ali");
            liste.Push("ayşe");

            MessageBox.Show(liste.Pop().ToString());
            MessageBox.Show(liste.Pop().ToString());
        }
    }
}
