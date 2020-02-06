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


namespace _36_driver_info_sinifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] suruculer = DriveInfo.GetDrives();

            foreach (DriveInfo driveInfo in suruculer)
            {
                listBox1.Items.Add(driveInfo.Name + " - " + driveInfo.TotalSize / 1024 / 1024 / 1024 + " - " + driveInfo.TotalFreeSpace + " - " + driveInfo.AvailableFreeSpace + " - " + driveInfo.DriveFormat + " - " + driveInfo.VolumeLabel);
            }
        }
    }
}
