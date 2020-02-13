using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShellExecute
{
    public partial class Form1 : Form
    {
        [DllImport("shell32.dll")]
        public static extern int ShellExecute(int hWind, string lpOperation, string lpFile, string lpParameters,
            string lpDirectory, int snShowCmd);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ShellExecute(0, "Open", "F:\\Egitim\\.Net Dersleri\\AdemAktepe\\data\\deneme.txt", "", "", 1);
            ShellExecute(0, "Open", "http://www.google.com", "", "", 1);
        }
    }
}
