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

namespace İstatistik_ve_Grafik_Sistemi
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=DbSecimProje;Integrated Security=True");


        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // İlçe adlarını combobax'a çekme

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ad from tbl_ilce", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            baglanti.Close();

            // Grafiğe Toplam Sonuçları Getirme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Aparti),sum(Bparti),sum(Cparti),sum(Dparti),sum(Eparti) from tbl_ilce", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E Parti", dr2[4]);

            }
            baglanti.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_ilce where ad=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());
                lblA.Text = dr[2].ToString();
                lblB.Text = dr[3].ToString();
                lblC.Text = dr[4].ToString();
                lblD.Text = dr[5].ToString();
                lblE.Text = dr[6].ToString();
            }
            baglanti.Close();
        }
    }
}
