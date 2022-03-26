using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Döviz_Ofisi___XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDolarAlis.Text = dolaralis;
            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolarSatis.Text = dolarsatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleuroalis.Text = euroalis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleurosatis.Text = eurosatis;
        }

        private void btndolaral_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarAlis.Text;
        }

        private void btnDolarsat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarSatis.Text;

        }

        private void btnEuroal_Click(object sender, EventArgs e)
        {
            txtKur.Text = lbleuroalis.Text;

        }

        private void btnEurosat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lbleurosatis.Text;

        }

        private void txtKur_TextChanged(object sender, EventArgs e)
        {
            txtKur.Text = txtKur.Text.Replace(".",",");
        }

        private void btnSatisyap_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = miktar * kur;
            txtTutar.Text = tutar.ToString();
        }

        private void btnsatisyap2_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(txtKur.Text);
            int miktar = Convert.ToInt32(txtMiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            txtTutar.Text = tutar.ToString();
            double kalan;
            kalan = miktar % kur;
            txtKalan.Text = kalan.ToString();
        }
    }
}
