using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost;Initial Catalog=Test;Integrated Security=True");

        void UrunListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_urunler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute Hareket", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void temizle()
        {
            cmbUrun.SelectedIndex = -1;
            cmbMusteri.SelectedIndex = -1;
            cmbPersonel.SelectedIndex = -1;
            textBox1.Clear();

        }

        void Urun()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Urunler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrun.DisplayMember = "UrunAd";
            cmbUrun.ValueMember = "UrunId";
            cmbUrun.DataSource = dt;
            cmbUrun.SelectedIndex = -1;

        }

        void Musteri()
        {
            SqlDataAdapter da = new SqlDataAdapter("select ID,(Ad+' '+Soyad) as AdSoyad from Tbl_Musteriler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbMusteri.DisplayMember = "AdSoyad";
            cmbMusteri.ValueMember = "ID";
            cmbMusteri.DataSource = dt;
            cmbMusteri.SelectedIndex = -1;
        }
        void Personel()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Personel", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPersonel.DisplayMember = "AdSoyad";
            cmbPersonel.ValueMember = "ID";
            cmbPersonel.DataSource = dt;
            cmbPersonel.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListele();
            listele();
            Urun();
            Musteri();
            Personel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                
              

                
                DialogResult test = MessageBox.Show("Ekleme İşlemini Onaylıyor Musunuz? ", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (test==DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into Tbl_Hareket (Urun,Musteri,Personel,Fiyat) values(@p1,@p2,@p3,@p4)", baglanti);
                    komut.Parameters.AddWithValue("@p1", cmbUrun.SelectedValue);
                    komut.Parameters.AddWithValue("@p2", cmbMusteri.SelectedValue);
                    komut.Parameters.AddWithValue("@p3", cmbPersonel.SelectedValue);
                    komut.Parameters.AddWithValue("@p4", textBox1.Text);
                    komut.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme İşlemi Başarısız !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                baglanti.Close();
                temizle();
                listele();
            }


        }
    }
}
