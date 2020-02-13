using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _87_thread_kullanimi
{
    public partial class Form1 : Form
    {
        private Thread kanal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kanal = new Thread(islemler);
            CheckForIllegalCrossThreadCalls = false;
            kanal.Start();
        }


        void islemler()
        {
            //label1.Text = "Thread aracılığıyla çalıştı..";
            for (int i = 0; i < 50; i++)
            {
                label1.Text = i.ToString();
                Thread.Sleep(1000);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kanal.Suspend();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kanal.Resume();
        }
    }
}
