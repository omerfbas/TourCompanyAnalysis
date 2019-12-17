namespace OTS_UI
{
    partial class frmRehber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRehber));
            this.dvRehber = new System.Windows.Forms.DataGridView();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtUyruk = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstDiller = new System.Windows.Forms.ListBox();
            this.cbDiller = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDilEkle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnYerEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbYer = new System.Windows.Forms.ComboBox();
            this.lstYer = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvRehber)).BeginInit();
            this.SuspendLayout();
            // 
            // dvRehber
            // 
            this.dvRehber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvRehber.Location = new System.Drawing.Point(16, 369);
            this.dvRehber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvRehber.Name = "dvRehber";
            this.dvRehber.Size = new System.Drawing.Size(1035, 245);
            this.dvRehber.TabIndex = 0;
            this.dvRehber.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvRehber_CellClick);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(132, 31);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(132, 95);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(132, 22);
            this.txtTel.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(132, 127);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(132, 22);
            this.txtMail.TabIndex = 4;
            // 
            // txtUyruk
            // 
            this.txtUyruk.Location = new System.Drawing.Point(132, 159);
            this.txtUyruk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUyruk.Name = "txtUyruk";
            this.txtUyruk.Size = new System.Drawing.Size(132, 22);
            this.txtUyruk.TabIndex = 5;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(132, 191);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(265, 22);
            this.dtpDogumTarihi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Uyruk:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // lstDiller
            // 
            this.lstDiller.FormattingEnabled = true;
            this.lstDiller.ItemHeight = 16;
            this.lstDiller.Location = new System.Drawing.Point(891, 31);
            this.lstDiller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDiller.Name = "lstDiller";
            this.lstDiller.Size = new System.Drawing.Size(159, 116);
            this.lstDiller.TabIndex = 13;
            // 
            // cbDiller
            // 
            this.cbDiller.FormattingEnabled = true;
            this.cbDiller.Location = new System.Drawing.Point(659, 78);
            this.cbDiller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDiller.Name = "cbDiller";
            this.cbDiller.Size = new System.Drawing.Size(160, 24);
            this.cbDiller.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Diller:";
            // 
            // btnDilEkle
            // 
            this.btnDilEkle.Location = new System.Drawing.Point(828, 31);
            this.btnDilEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDilEkle.Name = "btnDilEkle";
            this.btnDilEkle.Size = new System.Drawing.Size(55, 117);
            this.btnDilEkle.TabIndex = 16;
            this.btnDilEkle.Text = "Ekle";
            this.btnDilEkle.UseVisualStyleBackColor = true;
            this.btnDilEkle.Click += new System.EventHandler(this.btnYerEkle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.Location = new System.Drawing.Point(685, 323);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(115, 38);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.Location = new System.Drawing.Point(808, 324);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(115, 38);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(931, 323);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 39);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbCinsiyet.Location = new System.Drawing.Point(132, 62);
            this.cbCinsiyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(132, 24);
            this.cbCinsiyet.TabIndex = 20;
            // 
            // btnYerEkle
            // 
            this.btnYerEkle.Location = new System.Drawing.Point(828, 162);
            this.btnYerEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYerEkle.Name = "btnYerEkle";
            this.btnYerEkle.Size = new System.Drawing.Size(55, 117);
            this.btnYerEkle.TabIndex = 24;
            this.btnYerEkle.Text = "Ekle";
            this.btnYerEkle.UseVisualStyleBackColor = true;
            this.btnYerEkle.Click += new System.EventHandler(this.btnYerEkle_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Yerler:";
            // 
            // cbYer
            // 
            this.cbYer.FormattingEnabled = true;
            this.cbYer.Location = new System.Drawing.Point(659, 209);
            this.cbYer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbYer.Name = "cbYer";
            this.cbYer.Size = new System.Drawing.Size(160, 24);
            this.cbYer.TabIndex = 22;
            // 
            // lstYer
            // 
            this.lstYer.FormattingEnabled = true;
            this.lstYer.ItemHeight = 16;
            this.lstYer.Location = new System.Drawing.Point(891, 162);
            this.lstYer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstYer.Name = "lstYer";
            this.lstYer.Size = new System.Drawing.Size(159, 116);
            this.lstYer.TabIndex = 21;
            // 
            // frmRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 629);
            this.Controls.Add(this.btnYerEkle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbYer);
            this.Controls.Add(this.lstYer);
            this.Controls.Add(this.cbCinsiyet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnDilEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbDiller);
            this.Controls.Add(this.lstDiller);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtUyruk);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dvRehber);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRehber";
            this.Text = "frmRehber";
            this.Load += new System.EventHandler(this.frmRehber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvRehber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvRehber;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtUyruk;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstDiller;
        private System.Windows.Forms.ComboBox cbDiller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDilEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.Button btnYerEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbYer;
        private System.Windows.Forms.ListBox lstYer;
    }
}