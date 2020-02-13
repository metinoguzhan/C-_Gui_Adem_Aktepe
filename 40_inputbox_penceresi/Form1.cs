using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _40_inputbox_penceresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string girilenDeger = Interaction.InputBox("Adınızı giriniz","Veri Girişi","İsim");
            MessageBox.Show("Girilen Değer : " + girilenDeger);
        }
    }
}
