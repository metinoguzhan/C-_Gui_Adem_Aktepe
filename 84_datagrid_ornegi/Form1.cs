using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _84_datagrid_ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitaplarDataSet.Kitaplar' table. You can move, or remove it, as needed.
            this.kitaplarTableAdapter.Fill(this.kitaplarDataSet.Kitaplar);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.kitaplarTableAdapter.Adapter.Update(this.kitaplarDataSet.Tables[0]);
        }
    }
}
