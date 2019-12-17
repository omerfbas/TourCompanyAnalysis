using OTS_BLL;
using OTS_ENTITIES;
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

namespace OTS_UI
{
    public partial class frmBiletAl : Form
    {
        public frmBiletAl()
        {
            InitializeComponent();
        }

        TurController controller = new TurController();

        private void frmBiletAl_Load(object sender, EventArgs e)
        {
            lblAciklama.Text = string.Empty;
            lblDil.Text = string.Empty;
            lblFiyat.Text = string.Empty;
            lblKapasite.Text = string.Empty;
            lblTarih.Text = string.Empty;

            comboBox1.Text = "1";
            cbTurlar.DataSource = controller.GetAll();
            cbTurlar.DisplayMember = "Ad";
            cbTurlar.ValueMember = "TurId";
            cbTurlar.SelectedIndex = 0;
        }
    public static string today = "http://www.tcmb.gov.tr/kurlar/today.xml";
        private void cbTurlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbTurlar.SelectedValue.ToString(), out int id))
            {
                lstYerler.DataSource = controller.TurunYerleriniGetir(id);
                tur = controller.GetById(id);
                lblAciklama.Text = tur.Aciklama;
                lblDil.Text = tur.Dil.Ad;
                lblTarih.Text = tur.Tarihi.ToString(); ;
                lblKapasite.Text = tur.Kapasite.ToString();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(today);
                string Dolar = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
                string Euro = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
                decimal DolarFiyat = tur.Fiyat/Convert.ToDecimal(Dolar) ;
                decimal EuroFiyat = tur.Fiyat / Convert.ToDecimal(Euro);
                lblFiyat.Text = string.Format("{0}₺ - {1}$ - {2}€",tur.Fiyat,Decimal.Round(DolarFiyat,2) , Decimal.Round(EuroFiyat, 2));

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left > this.Width) pictureBox1.Left = 0-pictureBox1.Width;

        }
        int kisiSayisi;
        Turlar tur;
        private void btnIlerle_Click(object sender, EventArgs e)
        {
            if (!KontrolEt())
            {
                kisiSayisi = Convert.ToInt32(comboBox1.Text);

                if (tur.MevcutKisiSayisi + kisiSayisi < tur.Kapasite)
                {
                    Fatura fatura = new Fatura();
                    fatura.AdSoyad = txtAdSoyad.Text;
                    fatura.Adres = txtAdres.Text;
                    fatura.FaturaTarihi = DateTime.Now;
                    fatura.Mail = txtMail.Text;
                    fatura.Telefon = txtTel.Text;
                    fatura.OdemeTipi = cbOdemiTipi.Text;
                    tur.MevcutKisiSayisi = tur.MevcutKisiSayisi + kisiSayisi;
                    controller.Update(tur);
                    tur = (Turlar)cbTurlar.SelectedItem;
                    frmBiletBilgileri frm = new frmBiletBilgileri(fatura, kisiSayisi, tur);
                    this.Hide();
                    frm.Show();
                }
                else MessageBox.Show($"Bu turun {tur.Kapasite - tur.MevcutKisiSayisi} kadar kapasitesi kalmıştır.");
            }
            else MessageBox.Show("Lütfen boş alanları doldurunuz.");




        }
        private bool KontrolEt()
        {
            bool bosVarMi = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {

                        bosVarMi = true;
                    }

                }
            }
            return bosVarMi;
        }


    }
}
