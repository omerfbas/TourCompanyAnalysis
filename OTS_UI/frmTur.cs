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

namespace OTS_UI
{
    public partial class frmTur : Form
    { 
        public frmTur()
        {
            InitializeComponent();
        }

        DilController dilController = new DilController();
        RehberController rehberController = new RehberController();
        YerController yerController = new YerController();
        TurController controller = new TurController();

        private void frmTur_Load(object sender, EventArgs e)
        {
            Listele();

            cbDiller.DataSource = dilController.GetAll();
            cbDiller.DisplayMember = "Ad";
            cbDiller.ValueMember = "DilId";

            cbYer.DataSource = yerController.GetAll();
            cbYer.DisplayMember = "Ad";
            cbYer.ValueMember = "YerId";

        }

        void Listele()
        {
            dvTurlar.DataSource = controller.GetAll();
        }

        List<Rehberler> rehberlerCb=new List<Rehberler>();
        private void cbDiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbDiller.SelectedValue.ToString(), out int dilId))
                cbRehberler.Text = string.Empty;
            List<Rehberler> rehberler = rehberController.GetByDilId(dilId);
            cbRehberler.Items.Clear();
            rehberlerCb.Clear();
            yerler.Clear();
            lstYer.DataSource = null;
            foreach (Rehberler rehber in rehberler)
            {
                cbRehberler.Items.Add(rehber);
                rehberlerCb.Add(rehber);
            }
            
            cbRehberler.DisplayMember = "AdSoyad";
            cbRehberler.ValueMember = "Id";
            


        }
       private bool KontrolEt()
        {
            bool bosVarMi = false;
            foreach (Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {

                        bosVarMi = true;
                    }
                    
                }
            }
            return bosVarMi;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!KontrolEt())
            {
                Turlar turlar = new Turlar()
                {
                    Ad = txtAd.Text,
                    Aciklama = txtAciklama.Text,
                    Kapasite = Convert.ToInt32(txtKapasite.Text),
                    Fiyat = nmrFiyat.Value,
                    Tarihi = dtpTarih.Value,
                    DilId = (int)cbDiller.SelectedValue,
                    RehberId = ((Rehberler)cbRehberler.SelectedItem).Id,
                };
                controller.Add(turlar);
                Turlar tur = controller.GetLast();
                foreach (Yer yer in yerler)
                {
                    controller.TurYerAdd(new TurYer { TurId = tur.TurId, YerId = yer.YerId });
                }
                Listele();

                txtAciklama.Text = string.Empty;
                txtAd.Text = string.Empty;
                txtKapasite.Text = string.Empty;
                nmrFiyat.Value = 0;
                dtpTarih.Value = DateTime.Now;
            }
            else MessageBox.Show("Lütfen boş alanları doldurun.");


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = (int)dvTurlar.CurrentRow.Cells[0].Value;
            Turlar tur = controller.GetById(id);
            tur.Ad = txtAd.Text;
            tur.Aciklama = txtAciklama.Text;
            tur.Kapasite = Convert.ToInt32(txtKapasite.Text);
            tur.Fiyat = nmrFiyat.Value;
            tur.Tarihi = dtpTarih.Value;
            tur.DilId = (int)cbDiller.SelectedValue;
            tur.RehberId = (int)cbRehberler.SelectedValue;
            controller.Update(tur);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dvTurlar.CurrentRow.Cells[0].Value;
            Turlar tur = controller.GetById(id);
            yerController.TurYerDelete(id);
            controller.Delete(tur);
            Listele();
        }
        List<Yer> yerler = new List<Yer>();

        private void btnYerEkle_Click(object sender, EventArgs e)
        {
           // int yerId = (int)cbYer.SelectedValue;
            //int turId = (int)dvTurlar.CurrentRow.Cells[0].Value;
            //controller.TurYerAdd(new TurYer { TurId = turId, YerId = yerId });
            //lstYer.DataSource = controller.TurunYerleriniGetir(turId);
            yerler.Add((Yer)cbYer.SelectedItem);
            lstYer.DataSource = null;
            lstYer.DataSource = yerler;
            lstYer.DisplayMember = "Ad";
            foreach (Rehberler rehber in rehberlerCb)
            {
                List<string> rehberinYerleri = rehberController.RehberinYerleriniGetir(rehber.Id);
                int sayac = 0;
                foreach (string yerAdi in rehberinYerleri)
                {
                    foreach (Yer item in yerler)
                    {
                        if (item.Ad == yerAdi)
                        {
                            sayac++;
                        }
                    }
                }
                if(sayac!=yerler.Count)
                cbRehberler.Items.Remove(rehber);
            }

        }

        private void dvTurlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dvTurlar.CurrentRow.Cells[0].Value;
            lstYer.DataSource = controller.TurunYerleriniGetir(id);
            txtAciklama.Text = controller.GetById(id).Aciklama;
            txtAd.Text = controller.GetById(id).Ad;
            txtKapasite.Text = controller.GetById(id).Kapasite.ToString();
            nmrFiyat.Value = controller.GetById(id).Fiyat;
            dtpTarih.Value = controller.GetById(id).Tarihi;            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstYer.DataSource = null;
            yerler.Clear();
        }

        private void dvTurlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
