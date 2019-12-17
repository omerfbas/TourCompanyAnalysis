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
    public partial class frmYer : Form
    {
        public frmYer()
        {
            InitializeComponent();
        }
        YerController controller = new YerController();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!KontrolEt())
            {
                Yer yer = new Yer() { Ad = txtAd.Text, Aciklama = txtAciklama.Text, Ucret = nmrUcret.Value };
                controller.Add(yer);
                Listele();
                txtAciklama.Text = string.Empty;
                txtAd.Text = string.Empty;
                nmrUcret.Value = 0;
            }
            else MessageBox.Show("Lütfen boş alanları doldurunuz.");

        }
        void Listele()
        {
            dvYerler.DataSource = controller.GetAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = (int)dvYerler.CurrentRow.Cells[0].Value;
            Yer yer = controller.GetById(id);
            yer.Ad = txtAd.Text;
            yer.Ucret = nmrUcret.Value;
            yer.Aciklama = txtAciklama.Text;
            controller.Update(yer);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dvYerler.CurrentRow.Cells[0].Value;
            Yer yer = controller.GetById(id);
            controller.Delete(yer);
            Listele();
        }

        private void dvYerler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dvYerler.CurrentRow.Cells[1].Value.ToString();
            txtAciklama.Text = dvYerler.CurrentRow.Cells[2].Value.ToString();
            nmrUcret.Value = (decimal)dvYerler.CurrentRow.Cells[3].Value;
        }

        private void frmYer_Load(object sender, EventArgs e)
        {
            Listele();
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
