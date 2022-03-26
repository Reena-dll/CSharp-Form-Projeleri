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
using System.IO;

namespace Öğrenci_Etüt_ve_Ders_Kayıt_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=EtutTest;Integrated Security=True");

        void DersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.ValueMember = "DersID";
            cmbDers.DisplayMember = "DersAd";
            cmbDers.DataSource = dt;
            
        }

        void EtutListe()
        {
            SqlDataAdapter da = new SqlDataAdapter("Exec examp", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DersListesi();
            EtutListe();
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *,(Ad+' '+Soyad) as AdSoyad from Ogretmen where BransID=" + cmbDers.SelectedValue, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOgretmen.ValueMember = "OgrtID";
            cmbOgretmen.DisplayMember = "Ad";
            cmbOgretmen.DataSource = dt;
        }

        private void btnEtutOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Etut (DersID,OgretmenID,Tarih,Saat) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Oluşturuldu","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            EtutListe();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEtutId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        private void btnEtutver_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Etut set OgrenciID=@p1, durum=@p2 where ID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtOgrenci.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", txtEtutId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            EtutListe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Ogrenci (Ad,Soyad,Fotoğraf,Sınıf,Telefon,Mail) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", txtSinif.Text);
            komut.Parameters.AddWithValue("@p5", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Kayıt Edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EtutListe();
        }
    }
}

