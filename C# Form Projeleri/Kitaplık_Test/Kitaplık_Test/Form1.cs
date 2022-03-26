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

namespace Kitaplık_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KirapVT vtsinif = new KirapVT();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vtsinif.Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap ktpsinif = new Kitap();
            ktpsinif.ADI = txtKitapAd.Text;
            ktpsinif.YAZARI = txtYazar.Text;
            vtsinif.KitapEkle(ktpsinif);
            dataGridView1.DataSource = vtsinif.Liste();
        }
    }
}
