using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Doviz_Alim_Satim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDos = new XmlDocument();
            xmlDos.Load(today);

            string DolarAlis = xmlDos.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDolarAlis.Text=DolarAlis.ToString();

            string DolarSatis = xmlDos.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolarSatis.Text=DolarSatis.ToString();

            string EuroAlis = xmlDos.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroAlis.Text = EuroAlis.ToString();

            string EuroSatis = xmlDos.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSatis.Text = EuroSatis.ToString();

            string GBPAlis = xmlDos.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            lblGBPAlis.Text = GBPAlis.ToString();

            string GBPSatis = xmlDos.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            lblGBPSatis.Text = GBPSatis.ToString();

            string RubAlis = xmlDos.SelectSingleNode("Tarih_Date/Currency[@Kod='RUB']/ForexBuying").InnerXml;
            lblRubleAlis.Text = RubAlis.ToString();

            string RubSatis = xmlDos.SelectSingleNode("Tarih_Date/Currency[@Kod='RUB']/ForexSelling").InnerXml;
            lblRubleSatis.Text = RubSatis.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDolarAl_Click(object sender, EventArgs e)
        {
            txtKur.Text=lblDolarAlis.Text;
        }

        private void btnDolarSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarSatis.Text;
        }

        private void btnEuroAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroAlis.Text;
        }

        private void btnEuroSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroSatis.Text;
        }

        private void btnGBPAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblGBPAlis.Text;
        }

        private void btnGBPSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblGBPSatis.Text;
        }

        private void btnRubleAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblRubleAlis.Text;
        }

        private void btnRubleSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblRubleSatis.Text;
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            double Kur, Miktar, Tutar;
            Kur = Convert.ToDouble(txtKur.Text);
            Miktar=Convert.ToDouble(txtMiktar.Text);
            Tutar = Miktar * Kur;
            txtTutar.Text = Tutar.ToString();
        }

        private void txtKur_TextChanged(object sender, EventArgs e)
        {
            txtKur.Text = txtKur.Text.Replace(".", ",");
        }

        private void btnDovizVer_Click(object sender, EventArgs e)
        {
            double Kur, Miktar, Tutar;
            Kur = Convert.ToDouble(txtKur.Text);
            Miktar = Convert.ToDouble(txtMiktar.Text);
            Tutar = Miktar / Kur;
            txtTutar.Text = Tutar.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKur.Clear();
            txtMiktar.Clear();
            txtTutar.Clear();
           
        }
    }
}
