using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaTest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=DbBankaTest;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {


            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kisiler (Ad,Soyad,Tc,Telefon,HesapNo,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTc.Text);
            komut.Parameters.AddWithValue("@p4", mskTel.Text);
            komut.Parameters.AddWithValue("@p5", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p6", txtSifre.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt İşlemi Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
            this.Close();

        }
        string sorgu;
        private void btnHesapNo_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100000, 1000000);
            mskHesapNo.Text = sayi.ToString();

            sorgu = mskHesapNo.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select HesapNo from Kisiler", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (sorgu == dr[0].ToString())
                {
                    MessageBox.Show("Hesap No Mevcut Tekrar Deneyiniz");
                }
            }

            baglanti.Close();

        }
    }
}
