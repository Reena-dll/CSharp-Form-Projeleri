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

namespace MaaliyetTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=TestMaaliyet;Integrated Security=True");

        void MalzemeListe()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Malzemeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void UrunListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Urunler", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        void Kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from Kasa", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        void Urunler()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from Urunler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrun.ValueMember = "UrunID";
            cmbUrun.DisplayMember = "Ad";
            cmbUrun.DataSource = dt;

        }

        void Malzemeler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Malzemeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMalzeme.ValueMember = "MalzemeID";
            cmbMalzeme.DisplayMember = "Ad";
            cmbMalzeme.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListe();
            Urunler();
            Malzemeler();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void btnMalzemeListesi_Click(object sender, EventArgs e)
        {
            MalzemeListe();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            Kasa();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Malzemeler (Ad,Stok,Fiyat,Notlar) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMalzemeFiyat.Text));
            komut.Parameters.AddWithValue("@p4", txtMalzemeNot.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MalzemeListe();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Urunler (Ad) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Kayıt Edildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            UrunListesi();
        }

        private void BtnUrunOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Fırın(urunıd,MalzemeID,miktar,maaliyet) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtMaaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            listBox1.Items.Add(cmbMalzeme.Text + " - " + txtMaaliyet.Text);
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if (txtMiktar.Text=="")
            {
                txtMiktar.Text = "0";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from malzemeler where MalzemeID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
              txtMaaliyet.Text = dr[3].ToString();
            }

            baglanti.Close();

            maliyet = Convert.ToDouble(txtMaaliyet.Text) / 1000 * Convert.ToDouble(txtMiktar.Text);
            txtMaaliyet.Text = maliyet.ToString();

        }

        private void cmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUrunAd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Maaliyet) from Fırın where urunıd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtMaliyetFiyat.Text = dr[0].ToString();
            }
            baglanti.Close();
            
        }
    }
}
