using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57_combobox_kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                comboBox1.Items.Add(i);
            }

            comboBox1.Items.Insert(50,"------------------------------------");
            
            //eleman sayısına ulaşma
            MessageBox.Show(comboBox1.Items.Count.ToString());

            //insert edilen değeri silme
            comboBox1.Items.RemoveAt(50);


            //combobox temizleme
            //comboBox1.Items.Clear();
        }
    }
}
