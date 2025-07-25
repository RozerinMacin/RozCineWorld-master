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
            nYil = new NumericUpDown();
            nGun = new NumericUpDown();
            nAy = new NumericUpDown();
            groupBox5 = new GroupBox();
            label7 = new Label();
            groupBox6 = new GroupBox();
            cBDakika = new ComboBox();
            cBSaat = new ComboBox();
            groupBox7 = new GroupBox();
            cBSalonAdi = new ComboBox();
            groupBox8 = new GroupBox();
            cBBiletTuru = new ComboBox();
            groupBox9 = new GroupBox();
            txtKoltuk = new TextBox();
            BtnOlustur = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nAy).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
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
            panel1.Size = new Size(749, 37);
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
            btnkapat.Location = new Point(711, 0);
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
            label1.Size = new Size(341, 32);
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
            cBFilmAdi.Location = new Point(10, 25);
            cBFilmAdi.Name = "cBFilmAdi";
            cBFilmAdi.Size = new Size(240, 31);
            cBFilmAdi.TabIndex = 2;
            // 
            // nYil
            // 
            nYil.BorderStyle = BorderStyle.None;
            nYil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nYil.ForeColor = Color.FromArgb(16, 46, 80);
            nYil.Location = new Point(156, 26);
            nYil.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            nYil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nYil.Name = "nYil";
            nYil.Size = new Size(75, 26);
            nYil.TabIndex = 25;
            nYil.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // nGun
            // 
            nGun.BorderStyle = BorderStyle.None;
            nGun.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nGun.ForeColor = Color.FromArgb(16, 46, 80);
            nGun.Location = new Point(14, 26);
            nGun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nGun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nGun.Name = "nGun";
            nGun.Size = new Size(64, 26);
            nGun.TabIndex = 23;
            nGun.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nAy
            // 
            nAy.BorderStyle = BorderStyle.None;
            nAy.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nAy.ForeColor = Color.FromArgb(16, 46, 80);
            nAy.Location = new Point(84, 26);
            nAy.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nAy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nAy.Name = "nAy";
            nAy.Size = new Size(66, 26);
            nAy.TabIndex = 24;
            nAy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(nGun);
            groupBox5.Controls.Add(nYil);
            groupBox5.Controls.Add(nAy);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(16, 46, 80);
            label7.Location = new Point(166, 3);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 27;
            label7.Text = "GG/AA/YY";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cBDakika);
            groupBox6.Controls.Add(cBSaat);
            groupBox6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox6.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox6.Location = new Point(6, 343);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(10, 3, 3, 3);
            groupBox6.Size = new Size(253, 59);
            groupBox6.TabIndex = 27;
            groupBox6.TabStop = false;
            groupBox6.Text = "Seans";
            // 
            // cBDakika
            // 
            cBDakika.BackColor = Color.FromArgb(79, 149, 157);
            cBDakika.Dock = DockStyle.Left;
            cBDakika.DropDownStyle = ComboBoxStyle.DropDownList;
            cBDakika.DropDownWidth = 240;
            cBDakika.FlatStyle = FlatStyle.Flat;
            cBDakika.ForeColor = Color.FromArgb(16, 46, 80);
            cBDakika.FormattingEnabled = true;
            cBDakika.IntegralHeight = false;
            cBDakika.Items.AddRange(new object[] { "00", "25", "45" });
            cBDakika.Location = new Point(125, 26);
            cBDakika.Name = "cBDakika";
            cBDakika.Size = new Size(115, 31);
            cBDakika.TabIndex = 1;
            // 
            // cBSaat
            // 
            cBSaat.BackColor = Color.FromArgb(79, 149, 157);
            cBSaat.Dock = DockStyle.Left;
            cBSaat.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSaat.DropDownWidth = 240;
            cBSaat.FlatStyle = FlatStyle.Flat;
            cBSaat.ForeColor = Color.FromArgb(16, 46, 80);
            cBSaat.FormattingEnabled = true;
            cBSaat.IntegralHeight = false;
            cBSaat.Items.AddRange(new object[] { "10", "11", "12", "13" });
            cBSaat.Location = new Point(10, 26);
            cBSaat.Name = "cBSaat";
            cBSaat.Size = new Size(115, 31);
            cBSaat.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cBSalonAdi);
            groupBox7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox7.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox7.Location = new Point(6, 401);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(10, 3, 3, 3);
            groupBox7.Size = new Size(253, 59);
            groupBox7.TabIndex = 28;
            groupBox7.TabStop = false;
            groupBox7.Text = "Salon Adı";
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
            cBSalonAdi.Location = new Point(10, 25);
            cBSalonAdi.Name = "cBSalonAdi";
            cBSalonAdi.Size = new Size(240, 31);
            cBSalonAdi.TabIndex = 2;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(cBBiletTuru);
            groupBox8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox8.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox8.Location = new Point(6, 461);
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
            cBBiletTuru.Location = new Point(10, 25);
            cBBiletTuru.Name = "cBBiletTuru";
            cBBiletTuru.Size = new Size(240, 31);
            cBBiletTuru.TabIndex = 2;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtKoltuk);
            groupBox9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox9.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox9.Location = new Point(6, 524);
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
            BtnOlustur.Location = new Point(6, 587);
            BtnOlustur.Name = "BtnOlustur";
            BtnOlustur.Size = new Size(252, 41);
            BtnOlustur.TabIndex = 31;
            BtnOlustur.Text = "OLUŞTUR";
            BtnOlustur.UseVisualStyleBackColor = false;
            // 
            // FrmBiletOlusturma
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            ClientSize = new Size(749, 647);
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
            Location = new Point(425, 100);
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
            ((System.ComponentModel.ISupportInitialize)nYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nGun).EndInit();
            ((System.ComponentModel.ISupportInitialize)nAy).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ResumeLayout(false);
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
        private NumericUpDown nYil;
        private NumericUpDown nGun;
        private NumericUpDown nAy;
        private GroupBox groupBox5;
        private Label label7;
        private GroupBox groupBox6;
        private ComboBox cBDakika;
        private ComboBox cBSaat;
        private ComboBox cBFilmAdi;
        private GroupBox groupBox7;
        private ComboBox cBSalonAdi;
        private GroupBox groupBox8;
        private ComboBox cBBiletTuru;
        private GroupBox groupBox9;
        private TextBox txtKoltuk;
        private Button BtnOlustur;
    }
}