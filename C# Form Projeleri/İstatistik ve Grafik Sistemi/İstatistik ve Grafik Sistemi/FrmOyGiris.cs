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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=DbSecimProje;Integrated Security=True");

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_ilce (ad,Aparti,Bparti,Cparti,Dparti,Eparti) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtA.Text);
            komut.Parameters.AddWithValue("@p3", txtB.Text);
            komut.Parameters.AddWithValue("@p4", txtC.Text);
            komut.Parameters.AddWithValue("@p5", txtD.Text);
            komut.Parameters.AddWithValue("@p6", txtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti.", "Bilgi");
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
