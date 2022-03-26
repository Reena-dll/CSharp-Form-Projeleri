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

namespace Mail_ve_Telefon_Rehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=Rehber;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Kisiler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Temizle()
        {
            txtid.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            mskTel.Clear();
            txtMail.Clear();
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Ekleme İşlemi
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Kisiler (Ad,Soyad,Telefon,Mail) values(@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", mskTel.Text);
                komut.Parameters.AddWithValue("@p4", txtMail.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ekleme İşlemi Başarıyla Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme İşlemi Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                baglanti.Close();
                Temizle();
                listele();
            }
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult secenek = MessageBox.Show("Kayıt Güncellenecek Emin Misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update Kisiler set Ad=@p1,Soyad=@p2,Telefon=@p3,Mail=@p4 where ID=@p5", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", mskTel.Text);
                    komut.Parameters.AddWithValue("@p4", txtMail.Text);
                    komut.Parameters.AddWithValue("@p5", txtid.Text);
                    komut.ExecuteNonQuery();
                }
                else if (secenek == DialogResult.No)
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Gerçekleştirimeledi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            finally
            {
                baglanti.Close();
                Temizle();
                listele();
            }
           

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult secenek = MessageBox.Show("Kayıt Silinecek Emin Misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek==DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Delete from Kisiler where ID=@p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtid.Text);
                    komut.ExecuteNonQuery();
                }
                else if (secenek==DialogResult.No)
                {
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                baglanti.Close();
                listele();
                Temizle();

            }

        }
    }
}
