using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _73_treeview_kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string [] altKlasorler = Directory.GetDirectories(@"E:\");
            
            treeView2.Nodes.Add("E:\\");
            
            TreeNode ana = treeView2.Nodes[0];

            foreach (var klasor in altKlasorler)
            {
                TreeNode alt = new TreeNode(klasor);
                ana.Nodes.Add(alt);
            }


            string[] klasorler = Directory.GetDirectories(@"F:\");
            treeView2.Nodes.Add("F:\\");
            TreeNode anaF = treeView2.Nodes[1];

            foreach (var klasorisimleri in klasorler)
            {
                TreeNode altF = new TreeNode(klasorisimleri);
                anaF.Nodes.Add(altF);
            }


        }
    }
}
