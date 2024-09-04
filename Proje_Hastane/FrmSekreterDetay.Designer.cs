namespace Proje_Hastane
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnduyuruolustur = new System.Windows.Forms.Button();
            this.rchduyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.chkdurum = new System.Windows.Forms.CheckBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btndoktorgüncelle = new System.Windows.Forms.Button();
            this.btnbransgüncelle = new System.Windows.Forms.Button();
            this.btnduyurular = new System.Windows.Forms.Button();
            this.btnliste = new System.Windows.Forms.Button();
            this.btnbranspanel = new System.Windows.Forms.Button();
            this.btndoktorpanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(121, 75);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(88, 26);
            this.lbladsoyad.TabIndex = 3;
            this.lbladsoyad.Text = "Null Null";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(121, 32);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(133, 26);
            this.lbltc.TabIndex = 2;
            this.lbltc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnduyuruolustur);
            this.groupBox2.Controls.Add(this.rchduyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnduyuruolustur
            // 
            this.btnduyuruolustur.Location = new System.Drawing.Point(6, 228);
            this.btnduyuruolustur.Name = "btnduyuruolustur";
            this.btnduyuruolustur.Size = new System.Drawing.Size(264, 38);
            this.btnduyuruolustur.TabIndex = 1;
            this.btnduyuruolustur.Text = "Oluştur";
            this.btnduyuruolustur.UseVisualStyleBackColor = true;
            this.btnduyuruolustur.Click += new System.EventHandler(this.btnduyuruolustur_Click);
            // 
            // rchduyuru
            // 
            this.rchduyuru.Location = new System.Drawing.Point(6, 32);
            this.rchduyuru.Name = "rchduyuru";
            this.rchduyuru.Size = new System.Drawing.Size(264, 190);
            this.rchduyuru.TabIndex = 0;
            this.rchduyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnkaydet);
            this.groupBox3.Controls.Add(this.chkdurum);
            this.groupBox3.Controls.Add(this.msktc);
            this.groupBox3.Controls.Add(this.cmbdoktor);
            this.groupBox3.Controls.Add(this.cmbbrans);
            this.groupBox3.Controls.Add(this.msksaat);
            this.groupBox3.Controls.Add(this.msktarih);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(294, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 407);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(102, 351);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(174, 38);
            this.btnkaydet.TabIndex = 16;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // chkdurum
            // 
            this.chkdurum.AutoSize = true;
            this.chkdurum.Location = new System.Drawing.Point(104, 300);
            this.chkdurum.Name = "chkdurum";
            this.chkdurum.Size = new System.Drawing.Size(92, 30);
            this.chkdurum.TabIndex = 15;
            this.chkdurum.Text = "Durum";
            this.chkdurum.UseVisualStyleBackColor = true;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(92, 252);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(183, 33);
            this.msktc.TabIndex = 14;
            this.msktc.ValidatingType = typeof(int);
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(93, 212);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(182, 34);
            this.cmbdoktor.TabIndex = 13;
            // 
            // cmbbrans
            // 
            this.cmbbrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(94, 172);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(181, 34);
            this.cmbbrans.TabIndex = 12;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(93, 130);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(182, 33);
            this.msksaat.TabIndex = 11;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(94, 91);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(181, 33);
            this.msktarih.TabIndex = 10;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(94, 50);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(181, 33);
            this.txtid.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 26);
            this.label13.TabIndex = 8;
            this.label13.Text = "TC :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 26);
            this.label11.TabIndex = 6;
            this.label11.Text = "Doktor :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 26);
            this.label10.TabIndex = 5;
            this.label10.Text = "Branş :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 26);
            this.label9.TabIndex = 4;
            this.label9.Text = "Saat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tarih :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "id :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(582, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(588, 290);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(582, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(582, 312);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(588, 305);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(582, 273);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btndoktorgüncelle);
            this.groupBox6.Controls.Add(this.btnbransgüncelle);
            this.groupBox6.Controls.Add(this.btnduyurular);
            this.groupBox6.Controls.Add(this.btnliste);
            this.groupBox6.Controls.Add(this.btnbranspanel);
            this.groupBox6.Controls.Add(this.btndoktorpanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 425);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(564, 192);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btndoktorgüncelle
            // 
            this.btndoktorgüncelle.Location = new System.Drawing.Point(11, 112);
            this.btndoktorgüncelle.Name = "btndoktorgüncelle";
            this.btndoktorgüncelle.Size = new System.Drawing.Size(124, 69);
            this.btndoktorgüncelle.TabIndex = 22;
            this.btndoktorgüncelle.Text = "Doktor Güncelle";
            this.btndoktorgüncelle.UseVisualStyleBackColor = true;
            this.btndoktorgüncelle.Click += new System.EventHandler(this.btndoktorgüncelle_Click);
            // 
            // btnbransgüncelle
            // 
            this.btnbransgüncelle.Location = new System.Drawing.Point(146, 112);
            this.btnbransgüncelle.Name = "btnbransgüncelle";
            this.btnbransgüncelle.Size = new System.Drawing.Size(124, 69);
            this.btnbransgüncelle.TabIndex = 21;
            this.btnbransgüncelle.Text = "Branş Güncelle";
            this.btnbransgüncelle.UseVisualStyleBackColor = true;
            this.btnbransgüncelle.Click += new System.EventHandler(this.btnbransgüncelle_Click);
            // 
            // btnduyurular
            // 
            this.btnduyurular.Location = new System.Drawing.Point(282, 112);
            this.btnduyurular.Name = "btnduyurular";
            this.btnduyurular.Size = new System.Drawing.Size(124, 69);
            this.btnduyurular.TabIndex = 20;
            this.btnduyurular.Text = "Duyurular";
            this.btnduyurular.UseVisualStyleBackColor = true;
            this.btnduyurular.Click += new System.EventHandler(this.btnduyurular_Click);
            // 
            // btnliste
            // 
            this.btnliste.Location = new System.Drawing.Point(282, 33);
            this.btnliste.Name = "btnliste";
            this.btnliste.Size = new System.Drawing.Size(124, 69);
            this.btnliste.TabIndex = 19;
            this.btnliste.Text = "Randevu Listesi";
            this.btnliste.UseVisualStyleBackColor = true;
            this.btnliste.Click += new System.EventHandler(this.btnliste_Click);
            // 
            // btnbranspanel
            // 
            this.btnbranspanel.Location = new System.Drawing.Point(146, 32);
            this.btnbranspanel.Name = "btnbranspanel";
            this.btnbranspanel.Size = new System.Drawing.Size(124, 69);
            this.btnbranspanel.TabIndex = 18;
            this.btnbranspanel.Text = "Branş Paneli";
            this.btnbranspanel.UseVisualStyleBackColor = true;
            this.btnbranspanel.Click += new System.EventHandler(this.btnbranspanel_Click);
            // 
            // btndoktorpanel
            // 
            this.btndoktorpanel.Location = new System.Drawing.Point(11, 33);
            this.btndoktorpanel.Name = "btndoktorpanel";
            this.btndoktorpanel.Size = new System.Drawing.Size(124, 69);
            this.btndoktorpanel.TabIndex = 17;
            this.btndoktorpanel.Text = "Doktor Paneli";
            this.btndoktorpanel.UseVisualStyleBackColor = true;
            this.btndoktorpanel.Click += new System.EventHandler(this.btndoktorpanel_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1182, 618);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnduyuruolustur;
        private System.Windows.Forms.RichTextBox rchduyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnliste;
        private System.Windows.Forms.Button btnbranspanel;
        private System.Windows.Forms.Button btndoktorpanel;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.MaskedTextBox msktarih;
        public System.Windows.Forms.ComboBox cmbdoktor;
        public System.Windows.Forms.ComboBox cmbbrans;
        public System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.Button btnduyurular;
        private System.Windows.Forms.Button btndoktorgüncelle;
        private System.Windows.Forms.Button btnbransgüncelle;
        public System.Windows.Forms.MaskedTextBox msktc;
        public System.Windows.Forms.CheckBox chkdurum;
    }
}