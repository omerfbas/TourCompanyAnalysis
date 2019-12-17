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
    public partial class frmDil : Form
    {
        DilController controller = new DilController();

        public frmDil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dvDiller.CurrentRow.Cells[0].Value;
            Dil dil = controller.GetById(id);
            controller.Delete(dil);
            Listele();
        }

        private void frmDil_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            dvDiller.DataSource = controller.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAd.Text))
            {
                Dil dil = new Dil() { Ad = txtAd.Text };
                if (!controller.Add(dil)) MessageBox.Show("Bir şey oldu.");
                Listele();
                txtAd.Text = string.Empty;
            }
            else MessageBox.Show("Lütfen alanları boş geçmeyin");

        }
    }
}
