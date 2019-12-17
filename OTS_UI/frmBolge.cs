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
    public partial class frmBolge : Form
    {
        public frmBolge()
        {
            InitializeComponent();
        }
        BolgeController controller = new BolgeController();
        private void frmBolge_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            dvBolgeler.DataSource = controller.GetAll();
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
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!KontrolEt())
            {
                Bolge bolge = new Bolge() { Ad = txtAd.Text, UlasimGideri = nmrGider.Value };
                controller.Add(bolge);
                Listele();

                txtAd.Text = string.Empty;
                nmrGider.Value = 0;
            }
            else MessageBox.Show("Lütfen boş alanları doldurunuz.");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = (int)dvBolgeler.CurrentRow.Cells[0].Value;
            Bolge bolge = controller.GetById(id);
            bolge.Ad = txtAd.Text;
            bolge.UlasimGideri = nmrGider.Value;
           controller.Update(bolge);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dvBolgeler.CurrentRow.Cells[0].Value;
            Bolge bolge = controller.GetById(id);
            controller.Delete(bolge);
            Listele();
        }

        private void dvBolgeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dvBolgeler.CurrentRow.Cells[1].Value.ToString();
            nmrGider.Value = (decimal)dvBolgeler.CurrentRow.Cells[2].Value;
        }
    }
}
