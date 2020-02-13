using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _82_adonet_giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data source =.;Initial Catalog = Kitaplar;UID=sa;password = 4532");
        private SqlCommand cmd;

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection baglanti = new SqlConnection("Data source=.;Initial Catalog = Kitaplar; UID=sa; password=4532");
            //SqlConnection baglanti = new SqlConnection("Data source=.;Initial Catalog = Kitaplar; Integrated Security=True");
            //baglanti.Open();

        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            baglanti.Open();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            baglanti.Close();
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
                MessageBox.Show("Bağlantı Açık");
            }
            else
            {
                MessageBox.Show("Bağlantı Kapalı");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //cmd = new SqlCommand("INSERT INTO Kitaplar(KitapAdi,Yazar,SayfaSayisi) VALUES('"+txtKitapAdi.Text+"','"+txtYazari.Text+"',"+txtSayfaSayisi.Text+")",baglanti);
            cmd = new SqlCommand("INSERT INTO Kitaplar(KitapAdi,Yazar,SayfaSayisi) VALUES(@kitapAdi,@yazar,@sayfaSayisi)", baglanti);
            cmd.Parameters.Add("kitapAdi", txtKitapAdi.Text);
            cmd.Parameters.Add("yazar", txtYazari.Text);
            cmd.Parameters.Add("sayfaSayisi", txtSayfaSayisi.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglanti.Close();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open(); 
            cmd = new SqlCommand("DELETE Kitaplar WHERE KitapId = "+txtKitapId.Text,baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            cmd.Dispose();

        }

        private void btnKayitSec_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd = new SqlCommand("SELECT * FROM Kitaplar",baglanti);
            SqlDataReader kayitlar = cmd.ExecuteReader();

            while (kayitlar.Read())
            {
                MessageBox.Show(kayitlar["KitapAdi"].ToString() + " " + kayitlar["Yazar"].ToString());
            }
        }

        private void btnKayitOku_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd = new SqlCommand("SELECT * FROM Kitaplar",baglanti);
            SqlDataReader kayitlar = cmd.ExecuteReader();

            while (kayitlar.Read())
            {
                listBox1.Items.Add(kayitlar["KitapAdi"].ToString() + " - " + kayitlar["Yazar"].ToString() + " - " + kayitlar["SayfaSayisi"].ToString());
            }
        }

        private void btnKayitGetir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Kitaplar",baglanti);
            
            DataSet ds = new DataSet();
            adapter.Fill(ds,"Veriler1");
            

            adapter = new SqlDataAdapter("SELECT KitapAdi FROM Kitaplar",baglanti);
            adapter.Fill(ds, "Veriler2");


            dataGridView1.DataSource = ds.Tables[0];
            dataGridView2.DataSource = ds.Tables["Veriler2"];

        }

        private void btnSec_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Kitaplar",baglanti);
            DataTable dt = new DataTable("Veriler1");
            sqlDataAdapter.Fill(dt);

            dataGridView3.DataSource = dt;

            sqlDataAdapter = new SqlDataAdapter("SELECT KitapAdi FROM Kitaplar",baglanti);
            dt = new DataTable("Veriler2");
            sqlDataAdapter.Fill(dt);

            dataGridView4.DataSource = dt;


        }

        private void btnDataRow_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kitaplar",baglanti);
            DataTable dt = new DataTable("Kitaplar");
            da.Fill(dt);


            DataRow kayit = dt.Rows[0];
            txtKitapAdi.Text = kayit["KitapAdi"].ToString();
            txtYazari.Text = kayit["Yazar"].ToString();
            txtSayfaSayisi.Text = kayit["SayfaSayisi"].ToString();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                MessageBox.Show(dr["KitapAdi"].ToString());
            }
        }
    }
}
