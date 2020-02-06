using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Math.PI.ToString();
            label1.Text = Math.Abs(-5).ToString();
            label1.Text = Math.Ceiling(4.9).ToString();
            label1.Text = Math.Ceiling(4.4).ToString();

            label1.Text = Math.Floor(4.9).ToString();
            label1.Text = Math.Pow(5, 3).ToString();

            label1.Text = Math.Sqrt(16).ToString();

            label1.Text = Math.Max(10, 20).ToString();
            label1.Text = Math.Min(10, 20).ToString();

        }
    }
}
