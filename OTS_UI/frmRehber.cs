using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTS_BLL;
using OTS_ENTITIES;

namespace OTS_UI
{
    public partial class frmRehber : Form
    {
        public frmRehber()
        {
            InitializeComponent();
        }
        DilController dilController = new DilController();
        RehberController controller = new RehberController();
        YerController yerController = new YerController();
        private void frmRehber_Load(object sender, EventArgs e)
        {
            Listele();
            cbDiller.DataSource = dilController.GetAll();
            cbDiller.DisplayMember = "Ad";
            cbDiller.ValueMember = "DilId";
            cbYer.DataSource = yerController.GetAll();
            cbYer.DisplayMember = "Ad";
            cbYer.ValueMember = "YerId";
        }

        private void btnYerEkle_Click(object sender, EventArgs e)
        {
            int dilId = (int)cbDiller.SelectedValue;
            int rehberId = (int)dvRehber.CurrentRow.Cells[0].Value;
            dilController.RehberDilAdd(new RehberDil {RehberId=rehberId,DilId=dilId });
            lstDiller.DataSource = dilController.RehberinDilleriniGetir(rehberId);


        }
        void Listele()
        {
            dvRehber.DataSource = controller.GetAll();
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (!KontrolEt())
            {
                Rehberler rehber = new Rehberler()
                {
                    AdSoyad = txtAd.Text,
                    Cinsiyet = cbCinsiyet.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Mail = txtMail.Text,
                    Telefon = txtTel.Text,
                    Uyruk = txtUyruk.Text
                };

                controller.Add(rehber);
                Listele();
                txtAd.Text = string.Empty;
                txtMail.Text = string.Empty;
                txtTel.Text = string.Empty;
                txtUyruk.Text = string.Empty;
                dtpDogumTarihi.Value = DateTime.Now;
                lstDiller.Items.Clear();
                lstYer.Items.Clear();
            }
            else MessageBox.Show("Lütfen boş alanları doldurunuz.");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = (int)dvRehber.CurrentRow.Cells[0].Value;
            Rehberler rehber = controller.GetById(id);
            rehber.AdSoyad = txtAd.Text;
            rehber.Cinsiyet = cbCinsiyet.Text;
            rehber.DogumTarihi = dtpDogumTarihi.Value;
            rehber.Mail = txtMail.Text;
            rehber.Telefon = txtTel.Text;
            rehber.Uyruk = txtUyruk.Text;
            controller.Update(rehber);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dvRehber.CurrentRow.Cells[0].Value;
            Rehberler rehber = controller.GetById(id);
            dilController.RehberDilDelete(id);
            yerController.RehberYerDelete(id);
            controller.Delete(rehber);
            Listele();
        }

        private void dvRehber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dvRehber.CurrentRow.Cells[1].Value.ToString();
            cbCinsiyet.Text = dvRehber.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text= dvRehber.CurrentRow.Cells[3].Value.ToString();
            txtMail.Text = dvRehber.CurrentRow.Cells[4].Value.ToString();
            txtUyruk.Text = dvRehber.CurrentRow.Cells[5].Value.ToString();
            dtpDogumTarihi.Value = Convert.ToDateTime(dvRehber.CurrentRow.Cells[6].Value);
            int id = (int)dvRehber.CurrentRow.Cells[0].Value;
            lstDiller.DataSource = dilController.RehberinDilleriniGetir(id);
            lstYer.DataSource = yerController.RehberinYerleriniGetir(id);


        }

        private void btnYerEkle_Click_1(object sender, EventArgs e)
        {
            int yerId = (int)cbYer.SelectedValue;
            int rehberId = (int)dvRehber.CurrentRow.Cells[0].Value;
            yerController.RehberYerAdd(new RehberYer { RehberId = rehberId, YerId = yerId });
            lstYer.DataSource = yerController.RehberinYerleriniGetir(rehberId);
        }
    }
}
