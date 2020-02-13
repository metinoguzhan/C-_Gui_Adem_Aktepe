using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _70_richtextbox_kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //richTextBox1.SaveFile(@"F:\Egitim\.Net Dersleri\AdemAktepe\data\deneme.rtf");
            richTextBox1.SaveFile(@"F:\Egitim\.Net Dersleri\AdemAktepe\data\deneme.txt",RichTextBoxStreamType.PlainText);
        }
    }
}
