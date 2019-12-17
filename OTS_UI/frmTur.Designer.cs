namespace OTS_UI
{
    partial class frmTur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTur));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKapasite = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.nmrFiyat = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbYer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDiller = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRehberler = new System.Windows.Forms.ComboBox();
            this.lstYer = new System.Windows.Forms.ListBox();
            this.btnYerEkle = new System.Windows.Forms.Button();
            this.dvTurlar = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvTurlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tur Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kapasite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarihi";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(131, 42);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 20);
            this.txtAd.TabIndex = 4;
            // 
            // txtKapasite
            // 
            this.txtKapasite.Location = new System.Drawing.Point(131, 144);
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.Size = new System.Drawing.Size(200, 20);
            this.txtKapasite.TabIndex = 5;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(131, 92);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 20);
            this.txtAciklama.TabIndex = 6;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(131, 247);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyatı";
            // 
            // nmrFiyat
            // 
            this.nmrFiyat.Location = new System.Drawing.Point(131, 196);
            this.nmrFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrFiyat.Name = "nmrFiyat";
            this.nmrFiyat.Size = new System.Drawing.Size(200, 20);
            this.nmrFiyat.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Yerler:";
            // 
            // cbYer
            // 
            this.cbYer.FormattingEnabled = true;
            this.cbYer.Location = new System.Drawing.Point(435, 96);
            this.cbYer.Name = "cbYer";
            this.cbYer.Size = new System.Drawing.Size(121, 21);
            this.cbYer.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Diller:";
            // 
            // cbDiller
            // 
            this.cbDiller.FormattingEnabled = true;
            this.cbDiller.Location = new System.Drawing.Point(433, 37);
            this.cbDiller.Name = "cbDiller";
            this.cbDiller.Size = new System.Drawing.Size(121, 21);
            this.cbDiller.TabIndex = 24;
            this.cbDiller.SelectedIndexChanged += new System.EventHandler(this.cbDiller_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Rehberler:";
            // 
            // cbRehberler
            // 
            this.cbRehberler.FormattingEnabled = true;
            this.cbRehberler.Location = new System.Drawing.Point(433, 293);
            this.cbRehberler.Name = "cbRehberler";
            this.cbRehberler.Size = new System.Drawing.Size(121, 21);
            this.cbRehberler.TabIndex = 28;
            // 
            // lstYer
            // 
            this.lstYer.FormattingEnabled = true;
            this.lstYer.Location = new System.Drawing.Point(385, 177);
            this.lstYer.Name = "lstYer";
            this.lstYer.Size = new System.Drawing.Size(171, 69);
            this.lstYer.TabIndex = 32;
            // 
            // btnYerEkle
            // 
            this.btnYerEkle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnYerEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYerEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYerEkle.ForeColor = System.Drawing.Color.White;
            this.btnYerEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnYerEkle.Image")));
            this.btnYerEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYerEkle.Location = new System.Drawing.Point(468, 129);
            this.btnYerEkle.Name = "btnYerEkle";
            this.btnYerEkle.Size = new System.Drawing.Size(88, 37);
            this.btnYerEkle.TabIndex = 33;
            this.btnYerEkle.Text = "Ekle";
            this.btnYerEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYerEkle.UseVisualStyleBackColor = false;
            this.btnYerEkle.Click += new System.EventHandler(this.btnYerEkle_Click);
            // 
            // dvTurlar
            // 
            this.dvTurlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvTurlar.Location = new System.Drawing.Point(615, 42);
            this.dvTurlar.Name = "dvTurlar";
            this.dvTurlar.Size = new System.Drawing.Size(495, 277);
            this.dvTurlar.TabIndex = 36;
            this.dvTurlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvTurlar_CellClick);
            this.dvTurlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvTurlar_CellContentClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(237, 293);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 26);
            this.btnSil.TabIndex = 39;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.Location = new System.Drawing.Point(132, 293);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(99, 25);
            this.btnGuncelle.TabIndex = 38;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.Location = new System.Drawing.Point(31, 293);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(95, 25);
            this.btnEkle.TabIndex = 37;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(370, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 40;
            this.button1.Text = "Sil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1122, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dvTurlar);
            this.Controls.Add(this.btnYerEkle);
            this.Controls.Add(this.lstYer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbRehberler);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbYer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbDiller);
            this.Controls.Add(this.nmrFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKapasite);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTur";
            this.Text = "frmTur";
            this.Load += new System.EventHandler(this.frmTur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvTurlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtKapasite;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmrFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbYer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDiller;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRehberler;
        private System.Windows.Forms.ListBox lstYer;
        private System.Windows.Forms.Button btnYerEkle;
        private System.Windows.Forms.DataGridView dvTurlar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button button1;
    }
}