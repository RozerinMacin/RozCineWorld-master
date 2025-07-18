namespace RozCineWorld
{
    partial class FrmOyuncuKayit
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
            BtnResimYukle = new Button();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lblKarakter = new Label();
            label7 = new Label();
            txtBiyografi = new TextBox();
            label10 = new Label();
            pBResim = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            rBKadin = new RadioButton();
            rBErkek = new RadioButton();
            label5 = new Label();
            nYil = new NumericUpDown();
            nAy = new NumericUpDown();
            nGun = new NumericUpDown();
            label4 = new Label();
            BtnKaydet = new Button();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnkapat = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nAy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nGun).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnResimYukle
            // 
            BtnResimYukle.BackColor = Color.FromArgb(190, 61, 42);
            BtnResimYukle.Cursor = Cursors.Hand;
            BtnResimYukle.FlatAppearance.BorderSize = 0;
            BtnResimYukle.FlatStyle = FlatStyle.Flat;
            BtnResimYukle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnResimYukle.ForeColor = Color.White;
            BtnResimYukle.Location = new Point(6, 181);
            BtnResimYukle.Name = "BtnResimYukle";
            BtnResimYukle.Size = new Size(226, 40);
            BtnResimYukle.TabIndex = 4;
            BtnResimYukle.Text = "YÜKLE";
            BtnResimYukle.UseVisualStyleBackColor = false;
            BtnResimYukle.Click += BtnResimYukle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 14);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
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
            groupBox3.Location = new Point(2, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(486, 245);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // lblKarakter
            // 
            lblKarakter.BackColor = Color.White;
            lblKarakter.Location = new Point(429, 198);
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
            label7.Location = new Point(352, 1);
            label7.Name = "label7";
            label7.Size = new Size(127, 19);
            label7.TabIndex = 2;
            label7.Text = "(max 300 karakter)";
            // 
            // txtBiyografi
            // 
            txtBiyografi.Dock = DockStyle.Fill;
            txtBiyografi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBiyografi.ForeColor = Color.FromArgb(16, 46, 80);
            txtBiyografi.Location = new Point(3, 25);
            txtBiyografi.MaxLength = 300;
            txtBiyografi.Multiline = true;
            txtBiyografi.Name = "txtBiyografi";
            txtBiyografi.Size = new Size(480, 217);
            txtBiyografi.TabIndex = 1;
            txtBiyografi.TextChanged += txtBiyografi_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, -1);
            label10.Name = "label10";
            label10.Size = new Size(95, 21);
            label10.TabIndex = 0;
            label10.Text = "BİYOGRAFİ:";
            // 
            // pBResim
            // 
            pBResim.BackColor = Color.FromArgb(79, 149, 157);
            pBResim.Image = Properties.Resources._10234;
            pBResim.Location = new Point(7, 34);
            pBResim.Name = "pBResim";
            pBResim.Size = new Size(226, 142);
            pBResim.SizeMode = PictureBoxSizeMode.Zoom;
            pBResim.TabIndex = 3;
            pBResim.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.depositphotos_181131144_stock_illustration_female_gender_symbol;
            pictureBox3.Location = new Point(201, 191);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.png_clipart_gender_symbol_male_computer_icons_symbol_design_miscellaneous_blue;
            pictureBox2.Location = new Point(81, 190);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // rBKadin
            // 
            rBKadin.AutoSize = true;
            rBKadin.FlatStyle = FlatStyle.Flat;
            rBKadin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            rBKadin.Location = new Point(132, 192);
            rBKadin.Name = "rBKadin";
            rBKadin.Size = new Size(72, 24);
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
            rBErkek.Location = new Point(13, 192);
            rBErkek.Name = "rBErkek";
            rBErkek.Size = new Size(69, 24);
            rBErkek.TabIndex = 9;
            rBErkek.TabStop = true;
            rBErkek.Text = "ERKEK";
            rBErkek.UseVisualStyleBackColor = true;
            rBErkek.CheckedChanged += rBErkek_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 172);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 7;
            label5.Text = "CİNSİYET:";
            // 
            // nYil
            // 
            nYil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nYil.ForeColor = Color.FromArgb(16, 46, 80);
            nYil.Location = new Point(159, 143);
            nYil.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            nYil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nYil.Name = "nYil";
            nYil.Size = new Size(75, 25);
            nYil.TabIndex = 6;
            nYil.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // nAy
            // 
            nAy.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nAy.ForeColor = Color.FromArgb(16, 46, 80);
            nAy.Location = new Point(86, 143);
            nAy.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nAy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nAy.Name = "nAy";
            nAy.Size = new Size(66, 25);
            nAy.TabIndex = 5;
            nAy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nGun
            // 
            nGun.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nGun.ForeColor = Color.FromArgb(16, 46, 80);
            nGun.Location = new Point(16, 143);
            nGun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nGun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nGun.Name = "nGun";
            nGun.Size = new Size(64, 25);
            nGun.TabIndex = 4;
            nGun.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 119);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 4;
            label4.Text = "DOĞUM TARİHİ:";
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
            BtnKaydet.Location = new Point(0, 509);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(496, 33);
            BtnKaydet.TabIndex = 10;
            BtnKaydet.Text = "KAYIT TAMAMLA";
            BtnKaydet.UseVisualStyleBackColor = false;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSoyad.ForeColor = Color.FromArgb(16, 46, 80);
            txtSoyad.Location = new Point(16, 91);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(220, 25);
            txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 67);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 2;
            label3.Text = "SOYAD:";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAd.ForeColor = Color.FromArgb(16, 46, 80);
            txtAd.Location = new Point(16, 38);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(220, 25);
            txtAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 0;
            label2.Text = "AD:";
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
            groupBox1.Location = new Point(2, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 226);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
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
            btnkapat.Location = new Point(458, 0);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(38, 33);
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
            label1.Location = new Point(2, 5);
            label1.Name = "label1";
            label1.Size = new Size(239, 25);
            label1.TabIndex = 1;
            label1.Text = "[OYUNCU KAYIT EKRANI]";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnResimYukle);
            groupBox2.Controls.Add(pBResim);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox2.Location = new Point(250, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 226);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 46, 80);
            panel1.Controls.Add(btnkapat);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 33);
            panel1.TabIndex = 6;
            // 
            // FrmOyuncuKayit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            ClientSize = new Size(496, 542);
            Controls.Add(groupBox3);
            Controls.Add(BtnKaydet);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(550, 100);
            Margin = new Padding(5);
            Name = "FrmOyuncuKayit";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmOyuncuKayit";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nAy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nGun).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnResimYukle;
        private Label label6;
        private GroupBox groupBox3;
        private Label lblKarakter;
        private Label label7;
        private TextBox txtBiyografi;
        private Label label10;
        private PictureBox pBResim;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private RadioButton rBKadin;
        private RadioButton rBErkek;
        private Label label5;
        private NumericUpDown nYil;
        private NumericUpDown nAy;
        private NumericUpDown nGun;
        private Label label4;
        private Button BtnKaydet;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtAd;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnkapat;
        private Label label1;
        private GroupBox groupBox2;
        private Panel panel1;
    }
}