using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace _25_array_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList liste = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
           
            liste.Add("Metin");
            liste.Add(34);
            
            liste.AddRange(new string [] {"Oğuzhan","Ersin"});

            string[] isimler = {"adem", "aykut", "yüksel"};
            liste.AddRange(isimler);

            liste.Add("mehmet");
            liste.Insert(0,"BAŞLANGIÇ");
            liste.Remove("Oğuzhan");
            liste.RemoveAt(0);


            liste.InsertRange(0,new string [] {"Ziya","Vural"});
            liste.RemoveRange(3,2);

            listBox1.Items.AddRange(liste.ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = liste.IndexOf(textBox1.Text);
            if (sonuc!=-1)
            {
                MessageBox.Show(textBox1.Text + " listemizde bulunmaktadır..");
            }
            else
            {
                MessageBox.Show(sonuc.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(liste.Contains(textBox1.Text).ToString());
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int result = liste.Count;
            MessageBox.Show(result.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            liste.Clear();
            listBox1.Items.Clear();
        }
    }
}
