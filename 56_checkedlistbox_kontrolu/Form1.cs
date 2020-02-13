using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _56_checkedlistbox_kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Python");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var checkedItemCollection = checkedListBox1.CheckedItems;
            string seciliDiller = "";
            foreach (var items in checkedItemCollection)
            {
                seciliDiller += items + "\n";
            }

            MessageBox.Show(seciliDiller);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
        }
    }
}
