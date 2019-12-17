using OTS_BLL;
using OTS_ENTITIES;
using System;
using System.Windows.Forms;
using System.Xml;

namespace OTS_UI
{
    public partial class frmBiletBilgileri : Form
    {
        int kisiSayisi;
        Fatura fatura;
        Turlar tur;
        public frmBiletBilgileri(Fatura fatura, int kisiSayisi,Turlar tur)
        {
            this.fatura = fatura;
            this.kisiSayisi = kisiSayisi;
            this.tur = tur;
            InitializeComponent();
        }
        FaturaContoller faturaContoller = new FaturaContoller();
        TuristlerContoller turistlerContoller = new TuristlerContoller();
        BolgeController bolgeController = new BolgeController();
        TurBileti bilet = new TurBileti();
        TurController turController = new TurController();
        TurBiletiController turBiletiController = new TurBiletiController();
        
        private void frmBiletBilgileri_Load(object sender, EventArgs e)
        {
            faturaContoller.Add(fatura);
            lblAd.Text = fatura.AdSoyad;
            lblAdres.Text = fatura.Adres;
            lblMail.Text = fatura.Mail;
            lblTelefon.Text = fatura.Telefon;
            lblOdemeTipi.Text = fatura.OdemeTipi;
            cbBolge.DataSource = bolgeController.GetAll();
            cbBolge.DisplayMember = "Ad";
            cbBolge.ValueMember = "BolgeId";
            bilet.FaturaId = faturaContoller.GetLast().FaturaId;
            bilet.TurId = tur.TurId;
            turBiletiController.Add(bilet);
        }
        int sayac = 1;
        decimal fiyat = 0;
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (!KontrolEt())
            {
                Turistler turistler = new Turistler();
                turistler.AdSoyad = txtAdSoyad.Text;
                turistler.Cinsiyet = cbCinsiyet.Text;
                turistler.Telefon = txtTelefon.Text;
                turistler.Mail = txtMail.Text;
                turistler.Uyruk = txtUyruk.Text;
                turistler.DogumTarihi = dtpDogumTarihi.Value;
                turistler.BolgeId = Convert.ToInt32(cbBolge.SelectedValue);
                turistler.FaturaId = faturaContoller.GetLast().FaturaId;
                turistler.TurBiletiId = turBiletiController.GetLast().Id;

                if ((DateTime.Now.Year - turistler.DogumTarihi.Year) <= 10) fiyat += tur.Fiyat * 0.5m;
                else if ((DateTime.Now.Year - turistler.DogumTarihi.Year) > 60) fiyat += tur.Fiyat * 0.75m;
                else fiyat += tur.Fiyat;
                fiyat += turController.TurunYerlerininFiyatlariGetir(tur);

                Bolge bolge = new Bolge();
                bolge = (Bolge)cbBolge.SelectedItem;
                fiyat += bolge.UlasimGideri;
                turistlerContoller.Add(turistler);
                sayac++;
                lblKisi.Text = $"{sayac.ToString()}. Kişi";

                if (sayac > kisiSayisi)
                {
                    lblKisi.Text = $"{kisiSayisi.ToString()}. Kişi";
                    fatura.Tutar = fiyat;
                    btnKaydet.Enabled = false;

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(frmBiletAl.today);
                    string Dolar = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
                    string Euro = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
                    decimal DolarFiyat = fiyat / Convert.ToDecimal(Dolar);
                    decimal EuroFiyat = fiyat / Convert.ToDecimal(Euro);
                    lblFiyat.Text = string.Format("{0}₺ - {1}$ - {2}€", fiyat, Decimal.Round(DolarFiyat, 2), Decimal.Round(EuroFiyat, 2));
                    MessageBox.Show($"İşlem başarıyla tamamlanmıştır. Bilet Numaranız:{bilet.Id}");


                }
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox) control.Text = string.Empty;
                }
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
