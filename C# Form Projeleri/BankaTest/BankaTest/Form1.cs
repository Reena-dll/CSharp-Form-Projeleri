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

namespace BankaTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void lnkKayıtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Kisiler where HesapNo=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.hesap = mskHesapNo.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi!!!");
                mskHesapNo.Clear();
                txtSifre.Clear();
            }
            baglanti.Close();

        }
    }
}
