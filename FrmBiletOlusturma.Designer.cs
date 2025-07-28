namespace RozCineWorld
{
    partial class FrmBiletOlusturma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiletOlusturma));
            panel1 = new Panel();
            btnkapat = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtBiletno = new TextBox();
            groupBox2 = new GroupBox();
            txtAdSoyad = new TextBox();
            groupBox3 = new GroupBox();
            txtTelNo = new TextBox();
            groupBox4 = new GroupBox();
            cBFilmAdi = new ComboBox();
            groupBox5 = new GroupBox();
            cBTarih = new ComboBox();
            label7 = new Label();
            groupBox6 = new GroupBox();
            lblseanssec = new Label();
            PanelSEANS = new FlowLayoutPanel();
            groupBox7 = new GroupBox();
            lblkoltuksayisi = new Label();
            cBSalonAdi = new ComboBox();
            groupBox8 = new GroupBox();
            cBBiletTuru = new ComboBox();
            groupBox9 = new GroupBox();
            txtKoltuk = new TextBox();
            BtnOlustur = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            KoltukPaneli = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 46, 80);
            panel1.Controls.Add(btnkapat);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 37);
            panel1.TabIndex = 9;
            // 
            // btnkapat
            // 
            btnkapat.BackColor = Color.FromArgb(190, 61, 42);
            btnkapat.Cursor = Cursors.Hand;
            btnkapat.Dock = DockStyle.Right;
            btnkapat.FlatAppearance.BorderSize = 0;
            btnkapat.FlatStyle = FlatStyle.Flat;
            btnkapat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnkapat.ForeColor = Color.White;
            btnkapat.Location = new Point(725, 0);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(38, 37);
            btnkapat.TabIndex = 1;
            btnkapat.Text = "X";
            btnkapat.UseVisualStyleBackColor = false;
            btnkapat.Click += btnkapat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, 1);
            label1.Name = "label1";
            label1.Size = new Size(268, 25);
            label1.TabIndex = 1;
            label1.Text = "[BİLET OLUŞTURMA EKRANI]";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBiletno);
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox1.Location = new Point(5, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 3, 3);
            groupBox1.Size = new Size(253, 59);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bilet Numarası";
            // 
            // txtBiletno
            // 
            txtBiletno.BackColor = Color.FromArgb(79, 149, 157);
            txtBiletno.BorderStyle = BorderStyle.None;
            txtBiletno.Dock = DockStyle.Bottom;
            txtBiletno.ForeColor = Color.FromArgb(16, 46, 80);
            txtBiletno.Location = new Point(10, 24);
            txtBiletno.Multiline = true;
            txtBiletno.Name = "txtBiletno";
            txtBiletno.Size = new Size(240, 32);
            txtBiletno.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAdSoyad);
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox2.Location = new Point(5, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 3, 3, 3);
            groupBox2.Size = new Size(253, 59);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = Color.FromArgb(79, 149, 157);
            txtAdSoyad.BorderStyle = BorderStyle.None;
            txtAdSoyad.Dock = DockStyle.Bottom;
            txtAdSoyad.ForeColor = Color.FromArgb(16, 46, 80);
            txtAdSoyad.Location = new Point(10, 24);
            txtAdSoyad.Multiline = true;
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(240, 32);
            txtAdSoyad.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTelNo);
            groupBox3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox3.Location = new Point(5, 161);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 3, 3, 3);
            groupBox3.Size = new Size(253, 59);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Telefon Numarası";
            // 
            // txtTelNo
            // 
            txtTelNo.BackColor = Color.FromArgb(79, 149, 157);
            txtTelNo.BorderStyle = BorderStyle.None;
            txtTelNo.Dock = DockStyle.Bottom;
            txtTelNo.ForeColor = Color.FromArgb(16, 46, 80);
            txtTelNo.Location = new Point(10, 24);
            txtTelNo.Multiline = true;
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(240, 32);
            txtTelNo.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cBFilmAdi);
            groupBox4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox4.Location = new Point(5, 221);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10, 3, 3, 3);
            groupBox4.Size = new Size(253, 59);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Film Adı";
            // 
            // cBFilmAdi
            // 
            cBFilmAdi.BackColor = Color.FromArgb(79, 149, 157);
            cBFilmAdi.Dock = DockStyle.Bottom;
            cBFilmAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cBFilmAdi.DropDownWidth = 240;
            cBFilmAdi.FlatStyle = FlatStyle.Flat;
            cBFilmAdi.ForeColor = Color.FromArgb(16, 46, 80);
            cBFilmAdi.FormattingEnabled = true;
            cBFilmAdi.IntegralHeight = false;
            cBFilmAdi.Location = new Point(10, 31);
            cBFilmAdi.Name = "cBFilmAdi";
            cBFilmAdi.Size = new Size(240, 25);
            cBFilmAdi.TabIndex = 2;
            cBFilmAdi.SelectedIndexChanged += cBFilmAdi_SelectedIndexChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cBTarih);
            groupBox5.Controls.Add(label7);
            groupBox5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox5.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox5.Location = new Point(6, 282);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10, 3, 3, 3);
            groupBox5.Size = new Size(253, 59);
            groupBox5.TabIndex = 26;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tarih";
            // 
            // cBTarih
            // 
            cBTarih.BackColor = Color.FromArgb(79, 149, 157);
            cBTarih.Dock = DockStyle.Bottom;
            cBTarih.DropDownStyle = ComboBoxStyle.DropDownList;
            cBTarih.DropDownWidth = 240;
            cBTarih.FlatStyle = FlatStyle.Flat;
            cBTarih.ForeColor = Color.FromArgb(16, 46, 80);
            cBTarih.FormattingEnabled = true;
            cBTarih.IntegralHeight = false;
            cBTarih.Location = new Point(10, 31);
            cBTarih.Name = "cBTarih";
            cBTarih.Size = new Size(240, 25);
            cBTarih.TabIndex = 28;
            cBTarih.SelectedIndexChanged += cBTarih_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(16, 46, 80);
            label7.Location = new Point(166, 3);
            label7.Name = "label7";
            label7.Size = new Size(59, 13);
            label7.TabIndex = 27;
            label7.Text = "GG/AA/YY";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblseanssec);
            groupBox6.Controls.Add(PanelSEANS);
            groupBox6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox6.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox6.Location = new Point(6, 348);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(10, 3, 3, 3);
            groupBox6.Size = new Size(253, 81);
            groupBox6.TabIndex = 27;
            groupBox6.TabStop = false;
            groupBox6.Text = "Seans";
            // 
            // lblseanssec
            // 
            lblseanssec.AutoSize = true;
            lblseanssec.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblseanssec.ForeColor = Color.FromArgb(16, 46, 80);
            lblseanssec.Location = new Point(184, 3);
            lblseanssec.Name = "lblseanssec";
            lblseanssec.Size = new Size(48, 13);
            lblseanssec.TabIndex = 32;
            lblseanssec.Text = "lblseans";
            lblseanssec.Visible = false;
            // 
            // PanelSEANS
            // 
            PanelSEANS.AutoScroll = true;
            PanelSEANS.Dock = DockStyle.Fill;
            PanelSEANS.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            PanelSEANS.Location = new Point(10, 21);
            PanelSEANS.Name = "PanelSEANS";
            PanelSEANS.Size = new Size(240, 57);
            PanelSEANS.TabIndex = 32;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lblkoltuksayisi);
            groupBox7.Controls.Add(cBSalonAdi);
            groupBox7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox7.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox7.Location = new Point(6, 435);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(10, 3, 3, 3);
            groupBox7.Size = new Size(253, 54);
            groupBox7.TabIndex = 28;
            groupBox7.TabStop = false;
            groupBox7.Text = "Salon Adı";
            // 
            // lblkoltuksayisi
            // 
            lblkoltuksayisi.AutoSize = true;
            lblkoltuksayisi.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblkoltuksayisi.ForeColor = Color.FromArgb(16, 46, 80);
            lblkoltuksayisi.Location = new Point(158, 3);
            lblkoltuksayisi.Name = "lblkoltuksayisi";
            lblkoltuksayisi.Size = new Size(80, 13);
            lblkoltuksayisi.TabIndex = 33;
            lblkoltuksayisi.Text = "lblkoltuksayisi";
            // 
            // cBSalonAdi
            // 
            cBSalonAdi.BackColor = Color.FromArgb(79, 149, 157);
            cBSalonAdi.Dock = DockStyle.Bottom;
            cBSalonAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSalonAdi.DropDownWidth = 240;
            cBSalonAdi.FlatStyle = FlatStyle.Flat;
            cBSalonAdi.ForeColor = Color.FromArgb(16, 46, 80);
            cBSalonAdi.FormattingEnabled = true;
            cBSalonAdi.IntegralHeight = false;
            cBSalonAdi.Location = new Point(10, 26);
            cBSalonAdi.Name = "cBSalonAdi";
            cBSalonAdi.Size = new Size(240, 25);
            cBSalonAdi.TabIndex = 2;
            cBSalonAdi.SelectedIndexChanged += cBSalonAdi_SelectedIndexChanged;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(cBBiletTuru);
            groupBox8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox8.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox8.Location = new Point(6, 493);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(10, 3, 3, 3);
            groupBox8.Size = new Size(253, 59);
            groupBox8.TabIndex = 29;
            groupBox8.TabStop = false;
            groupBox8.Text = "Bilet Türü";
            // 
            // cBBiletTuru
            // 
            cBBiletTuru.BackColor = Color.FromArgb(79, 149, 157);
            cBBiletTuru.Dock = DockStyle.Bottom;
            cBBiletTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cBBiletTuru.DropDownWidth = 240;
            cBBiletTuru.FlatStyle = FlatStyle.Flat;
            cBBiletTuru.ForeColor = Color.FromArgb(16, 46, 80);
            cBBiletTuru.FormattingEnabled = true;
            cBBiletTuru.IntegralHeight = false;
            cBBiletTuru.Items.AddRange(new object[] { "YETİŞKİN", "ÖĞRENCİ" });
            cBBiletTuru.Location = new Point(10, 31);
            cBBiletTuru.Name = "cBBiletTuru";
            cBBiletTuru.Size = new Size(240, 25);
            cBBiletTuru.TabIndex = 2;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtKoltuk);
            groupBox9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox9.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox9.Location = new Point(6, 555);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(10, 3, 3, 3);
            groupBox9.Size = new Size(253, 59);
            groupBox9.TabIndex = 30;
            groupBox9.TabStop = false;
            groupBox9.Text = "Seçilen Koltuk(lar)";
            // 
            // txtKoltuk
            // 
            txtKoltuk.BackColor = Color.FromArgb(79, 149, 157);
            txtKoltuk.BorderStyle = BorderStyle.None;
            txtKoltuk.Dock = DockStyle.Bottom;
            txtKoltuk.ForeColor = Color.FromArgb(16, 46, 80);
            txtKoltuk.Location = new Point(10, 24);
            txtKoltuk.Multiline = true;
            txtKoltuk.Name = "txtKoltuk";
            txtKoltuk.Size = new Size(240, 32);
            txtKoltuk.TabIndex = 0;
            // 
            // BtnOlustur
            // 
            BtnOlustur.BackColor = Color.FromArgb(190, 61, 42);
            BtnOlustur.Cursor = Cursors.Hand;
            BtnOlustur.FlatAppearance.BorderSize = 0;
            BtnOlustur.FlatStyle = FlatStyle.Flat;
            BtnOlustur.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnOlustur.ForeColor = Color.White;
            BtnOlustur.Location = new Point(6, 618);
            BtnOlustur.Name = "BtnOlustur";
            BtnOlustur.Size = new Size(253, 41);
            BtnOlustur.TabIndex = 31;
            BtnOlustur.Text = "OLUŞTUR";
            BtnOlustur.UseVisualStyleBackColor = false;
            BtnOlustur.Click += BtnOlustur_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(261, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(485, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(262, 69);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 33;
            label2.Text = "Perde";
            // 
            // KoltukPaneli
            // 
            KoltukPaneli.AutoScroll = true;
            KoltukPaneli.Location = new Point(275, 106);
            KoltukPaneli.Name = "KoltukPaneli";
            KoltukPaneli.Size = new Size(460, 470);
            KoltukPaneli.TabIndex = 34;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.kirmizi;
            pictureBox2.Location = new Point(410, 584);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Mavi;
            pictureBox3.Location = new Point(503, 584);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.sari;
            pictureBox4.Location = new Point(594, 582);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 37;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(401, 642);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 38;
            label3.Text = "Dolu koltuk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(585, 641);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 39;
            label4.Text = "Seçili koltuk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(498, 641);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 40;
            label5.Text = "Boş koltuk";
            // 
            // FrmBiletOlusturma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            ClientSize = new Size(763, 671);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(KoltukPaneli);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnOlustur);
            Controls.Add(groupBox9);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(425, 40);
            Margin = new Padding(5);
            Name = "FrmBiletOlusturma";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmBiletOlusturma";
            Load += FrmBiletOlusturma_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnkapat;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtBiletno;
        private GroupBox groupBox2;
        private TextBox txtAdSoyad;
        private GroupBox groupBox3;
        private TextBox txtTelNo;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label7;
        private GroupBox groupBox6;
        private ComboBox cBFilmAdi;
        private GroupBox groupBox7;
        private ComboBox cBSalonAdi;
        private GroupBox groupBox8;
        private ComboBox cBBiletTuru;
        private GroupBox groupBox9;
        private TextBox txtKoltuk;
        private Button BtnOlustur;
        private ComboBox cBTarih;
        private FlowLayoutPanel PanelSEANS;
        private Label lblseanssec;
        private Label lblkoltuksayisi;
        private PictureBox pictureBox1;
        private Label label2;
        private FlowLayoutPanel KoltukPaneli;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private object nYil;
    }
}