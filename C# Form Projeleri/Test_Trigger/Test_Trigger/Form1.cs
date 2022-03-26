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

namespace Test_Trigger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=localhost;Database=Test;trusted_connection=true");

        void KitapListe()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Kitaplar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Sayac()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From tbl_sayac", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblKitap.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        void Temizle()
        {
            txtId.Clear();
            txtAd.Clear();
            txtYazar.Clear();
            txtYayinEvi.Clear();
            txtTur.Clear();
            txtSayfa.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KitapListe();
            Sayac();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Kitaplar (Ad,Yazar,Sayfa,YayinEvi,Tur) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", txtSayfa.Text);
            komut.Parameters.AddWithValue("@p4", txtYayinEvi.Text);
            komut.Parameters.AddWithValue("@p5", txtTur.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Eklendi.","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            KitapListe();
            Sayac();
            Temizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete  from Tbl_Kitaplar where ID=" + txtId.Text,baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            KitapListe();
            Sayac();
            Temizle();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtYayinEvi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTur.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
