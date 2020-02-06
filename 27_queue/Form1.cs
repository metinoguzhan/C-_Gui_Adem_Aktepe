using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Queue liste = new Queue();
            
            liste.Enqueue("adem");
            liste.Enqueue("ahmet");
            liste.Enqueue("kadir");

            
            //MessageBox.Show(liste.Dequeue().ToString());
            //MessageBox.Show(liste.Dequeue().ToString());

            MessageBox.Show(liste.Peek().ToString());
            MessageBox.Show(liste.Peek().ToString());


            liste.Clear();
        }
    }
}
