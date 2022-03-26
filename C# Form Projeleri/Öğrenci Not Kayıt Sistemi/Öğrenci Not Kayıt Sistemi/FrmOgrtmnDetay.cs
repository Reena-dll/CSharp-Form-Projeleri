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
using System.Configuration;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmOgrtmnDetay : Form
    {
        public FrmOgrtmnDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=DbNotKayit;Integrated Security=True");
        DbNotKayitEntities db = new DbNotKayitEntities();
        void listele()
        {
            this.tbl_DersTableAdapter.Fill(this.dbNotKayitDataSet.Tbl_Ders);
        }

        private void FrmOgrtmnDetay_Load(object sender, EventArgs e)
        {

            listele();

            lblOrtalama.Text = db.Tbl_Ders.Average(x => x.Ortalama).ToString();
            lblGecenSayi.Text = db.Tbl_Ders.Count(x => x.Durum == true).ToString();
            lblKalanSayi.Text = db.Tbl_Ders.Count(x => x.Durum==false).ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Ders  (OgrNumara,OgrAd,OgrSoyad) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", mskNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            mskNumara.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1,s2,s3;
            string durum;
            s1 = Convert.ToInt16(txtSinav1.Text);
            s2 = Convert.ToInt16(txtSinav2.Text);
            s3 = Convert.ToInt16(txtSinav3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text = ortalama.ToString("0.00");

            if (ortalama>=50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Tbl_Ders set OgrS1=@p1,OgrS2=@p2,OgrS3=@p3,Ortalama=@p4,Durum=@p5 where OgrNumara=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtSinav1.Text);
            komut.Parameters.AddWithValue("@p2", txtSinav2.Text);
            komut.Parameters.AddWithValue("@p3", txtSinav3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lblOrtalama.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", mskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi.");
            listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mskNumara.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
