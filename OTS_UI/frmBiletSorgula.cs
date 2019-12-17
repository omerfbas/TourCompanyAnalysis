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
    public partial class frmBiletSorgula : Form
    {
        public frmBiletSorgula()
        {
            InitializeComponent();
        }
        TurController turController = new TurController();
        TuristlerContoller turistlerContoller = new TuristlerContoller();
        TurBiletiController turBiletiController = new TurBiletiController();
        Turlar tur;
        private void frmBiletSorgula_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int turBiletId = (int)numericUpDown1.Value;
                int turId = turBiletiController.GetAll().Where(x => x.Id == turBiletId).Select(x => x.TurId).FirstOrDefault();
                tur = turController.GetById(turId);
                lblAciklama.Text = tur.Aciklama;
                lblAd.Text = tur.Ad;
                lblTarih.Text = tur.Tarihi.ToString();
                lstYerler.DataSource = turController.TurunYerleriniGetir(tur.TurId);
                lstKisiler.DataSource = turistlerContoller.GetAll().Where(x => x.TurBiletiId == turBiletId).Select(x => x.AdSoyad).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Böyle bir bilet bulunamadı");
            }
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left > this.Width) pictureBox1.Left = 0 - pictureBox1.Width;
        }
    }
}
