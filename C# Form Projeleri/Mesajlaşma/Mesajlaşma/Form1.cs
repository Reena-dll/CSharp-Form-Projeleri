using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Mesajlaşma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Mesaj;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Kisiler where Numara=@p1 And Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.numara = maskedTextBox1.Text;
                fr.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Girmiş Olduğunuz Numara veya Şifre Hatalı","Hata",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            baglanti.Close();
        }
    }
}
