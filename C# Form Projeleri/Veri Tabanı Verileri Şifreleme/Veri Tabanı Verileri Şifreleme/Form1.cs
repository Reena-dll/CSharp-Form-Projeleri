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

namespace Veri_Tabanı_Verileri_Şifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Test;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Veriler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string ad = txtAd.Text;
            byte[] adDizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adsifre = Convert.ToBase64String(adDizi);

            string soyad = txtSoyad.Text;
            byte[] soyadDizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyadDizi);

            string mail = txtMail.Text;
            byte[] mailDizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(mailDizi);

            string sifre = txtSifre.Text;
            byte[] sifreDizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifreSifre = Convert.ToBase64String(sifreDizi);

            string hesapNo = txtHesapNo.Text;
            byte[] hesapNoDizi = ASCIIEncoding.ASCII.GetBytes(hesapNo);
            string hesapsifre = Convert.ToBase64String(hesapNoDizi);

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into tbl_Veriler (Ad,Soyad,Mail,Sifre,HesapNo) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", adsifre);
            komut.Parameters.AddWithValue("@p2", soyadsifre);
            komut.Parameters.AddWithValue("@p3", mailsifre);
            komut.Parameters.AddWithValue("@p4", sifreSifre);
            komut.Parameters.AddWithValue("@p5", hesapsifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şifreli Veriler Yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adcozum = txtAd.Text;
            byte[] adcozumDizi = Convert.FromBase64String(adcozum);
            string adverisi = ASCIIEncoding.ASCII.GetString(adcozumDizi);
            label6.Text = adverisi;
        }
    }
}
