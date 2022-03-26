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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=DbBankaTest;Integrated Security=True");

        public string hesap;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblHesapNo.Text = hesap;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Kisiler where HesapNo=" + hesap, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblTcKimlik.Text = dr[3].ToString();
                lblTelefon.Text = dr[4].ToString();
                lblHesapNo.Text = dr[5].ToString();
            }
            baglanti.Close();
            
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Hesap set bakiye=bakiye+@p1 where HesapNo=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@p2", mskHesapNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Havale işlemi gerçekleşti.");
        }
    }
}
