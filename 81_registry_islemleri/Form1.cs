using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace _81_registry_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey klasor = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Internet Explorer",false);
            string version = klasor.GetValue("Version").ToString();
            MessageBox.Show("IE Versiyonu : " + version.ToString());
            MessageBox.Show("IE Versiyonu : " + version.Substring(0,1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey klasor = Registry.CurrentUser.OpenSubKey("Software", true);

            RegistryKey yeni = klasor.CreateSubKey("Denemex");
            yeni.SetValue("DegerAdi","55");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //RegistryKey klasor = Registry.CurrentUser.OpenSubKey("Software", true);
            //klasor.DeleteValue("DegerAdi");
            //klasor.DeleteSubKey("Denemex");
            //klasor.DeleteSubKeyTree("Denemex");


            RegistryKey klasor = Registry.CurrentUser.OpenSubKey("Software", true);
            if (klasor.OpenSubKey("Denemex") == null)
            {
                MessageBox.Show("Değer bulunmuyor.");
            }
            else
            {
                MessageBox.Show("Değer siliniyor..");
                klasor.DeleteSubKeyTree("Denemex");
            }
        }
    }
}
