using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;


namespace _29_list_kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> liste = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            liste.Add("kemal");
            liste.Add("ahmet");
            liste.Add("mahmut");
            liste.Add("ahmet");
            liste.Add("Oguzhan");


            
            //
            //liste.RemoveAll(new Predicate<string>(silmeKontrol));
            //MessageBox.Show(liste.Count.ToString());

            
            //liste.RemoveAll(new Predicate<string>(silmeKontrolByLenght));
            //MessageBox.Show(liste.Count.ToString());

            
            //
            //liste.ForEach(new Action<string>(ListeyeEkle));

            
            //
            //bool sonuc = liste.Exists(new Predicate<string>(isimBul));
            //MessageBox.Show(sonuc.ToString());

            
            //
            //MessageBox.Show(liste.Find(new Predicate<string>(isimBul)));

            
            //
            //MessageBox.Show(liste.FindIndex(new Predicate<string>(isimBul)).ToString());

            
            //
            //liste.FindAll(new Predicate<string>(isimBul)).ForEach(new Action<string>(listeyeEkle));


            //Bütün sartların sağlanması lzm
            MessageBox.Show(liste.TrueForAll(new Predicate<string>(sart)).ToString());

        }

        bool silmeKontrol(string isim)
        {
            if (isim == "ahmet")
                return true;
            return false;
        }


        bool silmeKontrolByLenght(string isim)
        {
            if (isim.Length == 5)
                return true;
            return false;
        }


        void ListeyeEkle(string isim)
        {
            listBox1.Items.Add(isim);
        }


        bool isimBul(string isim)
        {
            if (isim.Length > 5)
                return true;
            return false;
        }

        
        void listeyeEkle(string isim)
        {
            listBox1.Items.Add(isim);
        }


        bool sart(string isim)
        {
            if (isim.Length > 5)
                return true;
            return false;
        }

    }
}
