namespace RozCineWorld
{
    partial class FrmYonetmenkayit
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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            rBKadin = new RadioButton();
            rBErkek = new RadioButton();
            label5 = new Label();
            nYil = new NumericUpDown();
            nAy = new NumericUpDown();
            nGun = new NumericUpDown();
            label4 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            BtnResimYukle = new Button();
            pBResim = new PictureBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lblKarakter = new Label();
            label7 = new Label();
            txtBiyografi = new TextBox();
            label10 = new Label();
            BtnKaydet = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nAy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nGun).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBResim).BeginInit();
            groupBox3.SuspendLayout();
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
            panel1.Size = new Size(575, 35);
            panel1.TabIndex = 1;
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
            btnkapat.Location = new Point(537, 0);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(38, 35);
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
            label1.Location = new Point(2, 1);
            label1.Name = "label1";
            label1.Size = new Size(336, 32);
            label1.TabIndex = 1;
            label1.Text = "[YÖNETMEN KAYIT EKRANI]";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(rBKadin);
            groupBox1.Controls.Add(rBErkek);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nYil);
            groupBox1.Controls.Add(nAy);
            groupBox1.Controls.Add(nGun);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox1.Location = new Point(4, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 299);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.depositphotos_181131144_stock_illustration_female_gender_symbol;
            pictureBox3.Location = new Point(245, 245);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.png_clipart_gender_symbol_male_computer_icons_symbol_design_miscellaneous_blue;
            pictureBox2.Location = new Point(104, 245);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // rBKadin
            // 
            rBKadin.AutoSize = true;
            rBKadin.FlatStyle = FlatStyle.Flat;
            rBKadin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            rBKadin.Location = new Point(151, 248);
            rBKadin.Name = "rBKadin";
            rBKadin.Size = new Size(92, 29);
            rBKadin.TabIndex = 10;
            rBKadin.Text = "KADIN";
            rBKadin.UseVisualStyleBackColor = true;
            rBKadin.CheckedChanged += rBKadin_CheckedChanged;
            // 
            // rBErkek
            // 
            rBErkek.AutoSize = true;
            rBErkek.Checked = true;
            rBErkek.FlatStyle = FlatStyle.Flat;
            rBErkek.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            rBErkek.Location = new Point(18, 245);
            rBErkek.Name = "rBErkek";
            rBErkek.Size = new Size(88, 29);
            rBErkek.TabIndex = 9;
            rBErkek.TabStop = true;
            rBErkek.Text = "ERKEK";
            rBErkek.UseVisualStyleBackColor = true;
            rBErkek.CheckedChanged += rBErkek_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 212);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 7;
            label5.Text = "CİNSİYET:";
            // 
            // nYil
            // 
            nYil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nYil.ForeColor = Color.FromArgb(16, 46, 80);
            nYil.Location = new Point(180, 172);
            nYil.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            nYil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nYil.Name = "nYil";
            nYil.Size = new Size(92, 30);
            nYil.TabIndex = 6;
            nYil.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // nAy
            // 
            nAy.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nAy.ForeColor = Color.FromArgb(16, 46, 80);
            nAy.Location = new Point(98, 172);
            nAy.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nAy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nAy.Name = "nAy";
            nAy.Size = new Size(77, 30);
            nAy.TabIndex = 5;
            nAy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nGun
            // 
            nGun.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nGun.ForeColor = Color.FromArgb(16, 46, 80);
            nGun.Location = new Point(21, 172);
            nGun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nGun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nGun.Name = "nGun";
            nGun.Size = new Size(69, 30);
            nGun.TabIndex = 4;
            nGun.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 140);
            label4.Name = "label4";
            label4.Size = new Size(160, 28);
            label4.TabIndex = 4;
            label4.Text = "DOĞUM TARİHİ:";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSoyad.ForeColor = Color.FromArgb(16, 46, 80);
            txtSoyad.Location = new Point(22, 108);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(250, 30);
            txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 77);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 2;
            label3.Text = "SOYAD:";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAd.ForeColor = Color.FromArgb(16, 46, 80);
            txtAd.Location = new Point(21, 46);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(251, 30);
            txtAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 14);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 0;
            label2.Text = "AD:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnResimYukle);
            groupBox2.Controls.Add(pBResim);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox2.Location = new Point(301, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 301);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // BtnResimYukle
            // 
            BtnResimYukle.BackColor = Color.FromArgb(190, 61, 42);
            BtnResimYukle.Cursor = Cursors.Hand;
            BtnResimYukle.FlatAppearance.BorderSize = 0;
            BtnResimYukle.FlatStyle = FlatStyle.Flat;
            BtnResimYukle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnResimYukle.ForeColor = Color.White;
            BtnResimYukle.Location = new Point(6, 256);
            BtnResimYukle.Name = "BtnResimYukle";
            BtnResimYukle.Size = new Size(252, 36);
            BtnResimYukle.TabIndex = 4;
            BtnResimYukle.Text = "YÜKLE";
            BtnResimYukle.UseVisualStyleBackColor = false;
            BtnResimYukle.Click += BtnResimYukle_Click;
            // 
            // pBResim
            // 
            pBResim.BackColor = Color.FromArgb(79, 149, 157);
            pBResim.Image = Properties.Resources._10234;
            pBResim.Location = new Point(9, 45);
            pBResim.Name = "pBResim";
            pBResim.Size = new Size(249, 196);
            pBResim.SizeMode = PictureBoxSizeMode.Zoom;
            pBResim.TabIndex = 3;
            pBResim.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 14);
            label6.Name = "label6";
            label6.Size = new Size(74, 28);
            label6.TabIndex = 2;
            label6.Text = "RESİM:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblKarakter);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtBiyografi);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox3.Location = new Point(3, 342);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(567, 243);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // lblKarakter
            // 
            lblKarakter.BackColor = Color.White;
            lblKarakter.Location = new Point(435, 198);
            lblKarakter.Name = "lblKarakter";
            lblKarakter.RightToLeft = RightToLeft.Yes;
            lblKarakter.Size = new Size(47, 28);
            lblKarakter.TabIndex = 3;
            lblKarakter.Text = "300";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(346, 0);
            label7.Name = "label7";
            label7.Size = new Size(155, 23);
            label7.TabIndex = 2;
            label7.Text = "(max 300 karakter)";
            // 
            // txtBiyografi
            // 
            txtBiyografi.Dock = DockStyle.Fill;
            txtBiyografi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBiyografi.ForeColor = Color.FromArgb(16, 46, 80);
            txtBiyografi.Location = new Point(3, 30);
            txtBiyografi.MaxLength = 300;
            txtBiyografi.Multiline = true;
            txtBiyografi.Name = "txtBiyografi";
            txtBiyografi.Size = new Size(561, 210);
            txtBiyografi.TabIndex = 1;
            txtBiyografi.TextChanged += txtBiyografi_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 1);
            label10.Name = "label10";
            label10.Size = new Size(117, 28);
            label10.TabIndex = 0;
            label10.Text = "BİYOGRAFİ:";
            // 
            // BtnKaydet
            // 
            BtnKaydet.BackColor = Color.FromArgb(190, 61, 42);
            BtnKaydet.Cursor = Cursors.Hand;
            BtnKaydet.Dock = DockStyle.Bottom;
            BtnKaydet.FlatAppearance.BorderSize = 0;
            BtnKaydet.FlatStyle = FlatStyle.Flat;
            BtnKaydet.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnKaydet.ForeColor = Color.White;
            BtnKaydet.Location = new Point(0, 585);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(575, 43);
            BtnKaydet.TabIndex = 5;
            BtnKaydet.Text = "KAYIT TAMAMLA";
            BtnKaydet.UseVisualStyleBackColor = false;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // FrmYonetmenkayit
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            ClientSize = new Size(575, 628);
            Controls.Add(BtnKaydet);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(550, 100);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmYonetmenkayit";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmYonetmenkayit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nAy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nGun).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBResim).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnkapat;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtAd;
        private Label label2;
        private NumericUpDown nGun;
        private Label label4;
        private NumericUpDown nYil;
        private NumericUpDown nAy;
        private Label label5;
        private RadioButton rBKadin;
        private RadioButton rBErkek;
        private Label label6;
        private Button BtnResimYukle;
        private PictureBox pBResim;
        private GroupBox groupBox3;
        private TextBox txtBiyografi;
        private Label label10;
        private Label label7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lblKarakter;
        private Button BtnKaydet;
    }
}