using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41_messagebox_penceresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mesaj içerigi\n2.satıra geçtik..", "Mesaj başlığı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2,MessageBoxOptions.RightAlign);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Okey tuşuna basıldı..");
            }
            else
            {
                MessageBox.Show("Cancel tuşuna basıldı...");
            }
        }
    }
}
