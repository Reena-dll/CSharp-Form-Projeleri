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

namespace Petrol_Akaryakıt_Stok_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=TestBenzin;Integrated Security=True");


      void Listele()
        {

            // Kurşunsuz 95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Benzin where PetrolTur='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblKursunsuz95.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                lblKursunsuz95Litre.Text = dr[4].ToString();

            }
            baglanti.Close();

            // Kurşunsuz97
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from Benzin where PetrolTur='Kurşunsuz97'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblKursunsuz97.Text = dr2[3].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                lblKursunsuz97Litre.Text = dr2[4].ToString();

            }
            baglanti.Close();
            // EuroDizel10
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from Benzin where PetrolTur='EuroDizel10'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblEuroDizel.Text = dr3[3].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                lblEuroDizelLitre.Text = dr3[4].ToString();

            }
            baglanti.Close();
            // YeniProDizel
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * from Benzin where PetrolTur='YeniProDizel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblYeniProDize.Text = dr4[3].ToString();
                progressBar4.Value = int.Parse(dr4[4].ToString());
                lblYeniProDizelLitre.Text = dr4[4].ToString();

            }
            baglanti.Close();
            // Gaz
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from Benzin where PetrolTur='Gaz'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblGaz.Text = dr5[3].ToString();
                progressBar5.Value = int.Parse(dr5[4].ToString());
                lblGazLitre.Text = dr5[4].ToString();

            }
            baglanti.Close();

            // Kasa Listele

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * from kasa", baglanti);
            SqlDataReader dt = komut6.ExecuteReader();
            while (dt.Read())
            {
                kasaFiyat.Text = dt[0].ToString();
            }
            baglanti.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = double.Parse(lblKursunsuz95.Text);
            litre = double.Parse(numericUpDown1.Value.ToString());
            tutar = kursunsuz95 * litre;
            txtKursunsuz95Fiyat.Text = tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = double.Parse(lblKursunsuz97.Text);
            litre = double.Parse(numericUpDown2.Value.ToString());
            tutar = kursunsuz97 * litre;
            txtKursunsuz97Fiyat.Text = tutar.ToString();


        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double eurodizel, litre, tutar;
            eurodizel = double.Parse(lblEuroDizel.Text);
            litre = double.Parse(numericUpDown3.Value.ToString());
            tutar = eurodizel * litre;
            txtEuroDizel10Fiyat.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double prodizel, litre, tutar;
            prodizel = double.Parse(lblYeniProDize.Text);
            litre = double.Parse(numericUpDown4.Value.ToString());
            tutar = prodizel * litre;
            txtYeniProDizelFiyat.Text = tutar.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = double.Parse(lblGaz.Text);
            litre = double.Parse(numericUpDown5.Value.ToString());
            tutar = gaz * litre;
            txtGazFiyat.Text = tutar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value!=0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Hareket (plaka,Benzinturu,Litre,fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kurşunsuz95");
                komut.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtKursunsuz95Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Kasa set miktar=miktar+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtKursunsuz95Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();
                
              

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update benzin set stok=stok-@p1 where petroltur='Kurşunsuz95'",baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown1.Value);
                komut3.ExecuteNonQuery();
                MessageBox.Show("Satış Yapıldı");
                baglanti.Close();
                Listele();
                
            }

            if (numericUpDown2.Value!=0)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Hareket (plaka,Benzinturu,Litre,fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kurşunsuz97");
                komut.Parameters.AddWithValue("@p3", numericUpDown2.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtKursunsuz97Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();


                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Kasa set miktar=miktar+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtKursunsuz97Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();



                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update benzin set stok=stok-@p1 where petroltur='Kurşunsuz97'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown2.Value);
                komut3.ExecuteNonQuery();
                MessageBox.Show("Satış Yapıldı");
                baglanti.Close();
                Listele();
            }

            if (numericUpDown3.Value!=0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Hareket (plaka,Benzinturu,Litre,fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "EuroDizel10");
                komut.Parameters.AddWithValue("@p3", numericUpDown3.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtEuroDizel10Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();


                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Kasa set miktar=miktar+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtEuroDizel10Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();



                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update benzin set stok=stok-@p1 where petroltur='EuroDizel10'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown3.Value);
                komut3.ExecuteNonQuery();
                MessageBox.Show("Satış Yapıldı");
                baglanti.Close();
                Listele();
            }
            if (numericUpDown4.Value!=0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Hareket (plaka,Benzinturu,Litre,fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "YeniProDizel");
                komut.Parameters.AddWithValue("@p3", numericUpDown4.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtYeniProDizelFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();


                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Kasa set miktar=miktar+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtYeniProDizelFiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();



                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update benzin set stok=stok-@p1 where petroltur='YeniProDizel'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown4.Value);
                komut3.ExecuteNonQuery();
                MessageBox.Show("Satış Yapıldı");
                baglanti.Close();
                Listele();
            }

            if (numericUpDown5.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Hareket (plaka,Benzinturu,Litre,fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Gaz");
                komut.Parameters.AddWithValue("@p3", numericUpDown5.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtGazFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();


                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Kasa set miktar=miktar+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtGazFiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();



                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update benzin set stok=stok-@p1 where petroltur='Gaz'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown5.Value);
                komut3.ExecuteNonQuery();
                MessageBox.Show("Satış Yapıldı");
                baglanti.Close();
                Listele();
            }
        }
    }
}