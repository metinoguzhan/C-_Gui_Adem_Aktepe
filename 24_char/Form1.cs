using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_char
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Char.GetNumericValue('A').ToString();
            label1.Text = Char.GetNumericValue('8').ToString();
            label1.Text = Char.ToUpper('u').ToString();
            label1.Text = Char.ToLower('U').ToString();

            label1.Text = Char.IsNumber('1').ToString();
            label1.Text = Char.IsWhiteSpace(' ').ToString();

            label1.Text = Char.IsUpper('a').ToString();
            label1.Text = Char.IsLower('a').ToString();


            char degisken = Char.Parse("a");
            label1.Text = degisken.ToString();
        }
    }
}
