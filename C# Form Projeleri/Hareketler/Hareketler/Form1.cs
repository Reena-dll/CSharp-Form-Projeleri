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

namespace Hareketler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Hareket;Integrated Security=True");

        void Tablolistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute Hareket", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void Urun()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Urunler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "Ad";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = dt;
            comboBox1.SelectedIndex = -1;
        }

        void Personel()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Personeller", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DisplayMember = "Ad";
            comboBox2.ValueMember = "ID";
            comboBox2.DataSource = dt;
            comboBox2.SelectedIndex = -1;
        }
        void Musteri()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Musteriler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox3.DisplayMember = "AdSoyad";
            comboBox3.ValueMember = "ID";
            comboBox3.DataSource = dt;
            comboBox3.SelectedIndex = -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Tablolistele();
            Urun();
            Personel();
            Musteri();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Hareketler (Urun,Personel,Musteri,Fiyat) values(@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
                komut.Parameters.AddWithValue("@p2", comboBox2.SelectedValue);
                komut.Parameters.AddWithValue("@p3", comboBox3.SelectedValue);
                komut.Parameters.AddWithValue("@p4", textBox1.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarıyla Gerçekleşti","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                textBox1.Clear();
                Tablolistele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş Yapıldı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                textBox1.Clear();
                
            }
            finally
            {
                baglanti.Close();
            }
           
        }
    }
}
