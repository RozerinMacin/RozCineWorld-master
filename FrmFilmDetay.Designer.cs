namespace RozCineWorld
{
    partial class FrmFilmDetay
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
            groupBox9 = new GroupBox();
            pBResim = new PictureBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblFilmAdi = new Label();
            groupBox2 = new GroupBox();
            lblyonetmen = new Label();
            groupBox3 = new GroupBox();
            lbloyuncu = new Label();
            groupBox4 = new GroupBox();
            lblbicim = new Label();
            groupBox5 = new GroupBox();
            lblozellikler = new Label();
            groupBox6 = new GroupBox();
            lbltur = new Label();
            groupBox7 = new GroupBox();
            lbldurum = new Label();
            groupBox8 = new GroupBox();
            lblvizyontarihi = new Label();
            groupBox10 = new GroupBox();
            lblIMDB = new Label();
            groupBox11 = new GroupBox();
            lbldetay = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBResim).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
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
            panel1.Size = new Size(763, 32);
            panel1.TabIndex = 8;
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
            btnkapat.Size = new Size(38, 32);
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
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "[FİLM DETAY EKRANI]";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(pBResim);
            groupBox9.Controls.Add(label2);
            groupBox9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox9.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox9.Location = new Point(8, 35);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(10, 3, 3, 3);
            groupBox9.Size = new Size(159, 259);
            groupBox9.TabIndex = 17;
            groupBox9.TabStop = false;
            groupBox9.Text = "Film Afişi";
            // 
            // pBResim
            // 
            pBResim.BackColor = Color.FromArgb(79, 149, 157);
            pBResim.Image = Properties.Resources._10234;
            pBResim.Location = new Point(2, 23);
            pBResim.Name = "pBResim";
            pBResim.Size = new Size(151, 230);
            pBResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pBResim.TabIndex = 5;
            pBResim.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(529, 235);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(47, 28);
            label2.TabIndex = 6;
            label2.Text = "300";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFilmAdi);
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox1.Location = new Point(174, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 3, 3);
            groupBox1.Size = new Size(190, 70);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Film Adı";
            // 
            // lblFilmAdi
            // 
            lblFilmAdi.Location = new Point(4, 22);
            lblFilmAdi.Name = "lblFilmAdi";
            lblFilmAdi.Size = new Size(180, 44);
            lblFilmAdi.TabIndex = 0;
            lblFilmAdi.Text = "label3";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblyonetmen);
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox2.Location = new Point(371, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 3, 3, 3);
            groupBox2.Size = new Size(190, 187);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Film Yönetmeni";
            // 
            // lblyonetmen
            // 
            lblyonetmen.Location = new Point(7, 22);
            lblyonetmen.Name = "lblyonetmen";
            lblyonetmen.Size = new Size(182, 161);
            lblyonetmen.TabIndex = 0;
            lblyonetmen.Text = "label4";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbloyuncu);
            groupBox3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox3.Location = new Point(566, 33);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 3, 3, 3);
            groupBox3.Size = new Size(190, 261);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Film Oyuncuları";
            // 
            // lbloyuncu
            // 
            lbloyuncu.Location = new Point(6, 23);
            lbloyuncu.Name = "lbloyuncu";
            lbloyuncu.Size = new Size(178, 225);
            lbloyuncu.TabIndex = 0;
            lbloyuncu.Text = "label5";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblbicim);
            groupBox4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox4.Location = new Point(122, 294);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10, 3, 3, 3);
            groupBox4.Size = new Size(241, 81);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Film Biçimi";
            // 
            // lblbicim
            // 
            lblbicim.Location = new Point(7, 21);
            lblbicim.Name = "lblbicim";
            lblbicim.Size = new Size(228, 57);
            lblbicim.TabIndex = 0;
            lblbicim.Text = "label6";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblozellikler);
            groupBox5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox5.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox5.Location = new Point(369, 293);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10, 3, 3, 3);
            groupBox5.Size = new Size(387, 82);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "Film Özellikleri";
            // 
            // lblozellikler
            // 
            lblozellikler.Location = new Point(5, 21);
            lblozellikler.Name = "lblozellikler";
            lblozellikler.Size = new Size(376, 55);
            lblozellikler.TabIndex = 0;
            lblozellikler.Text = "label7";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lbltur);
            groupBox6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox6.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox6.Location = new Point(176, 220);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(10, 3, 3, 3);
            groupBox6.Size = new Size(385, 74);
            groupBox6.TabIndex = 20;
            groupBox6.TabStop = false;
            groupBox6.Text = "Filmin Türü";
            // 
            // lbltur
            // 
            lbltur.Location = new Point(5, 21);
            lbltur.Name = "lbltur";
            lbltur.Size = new Size(374, 44);
            lbltur.TabIndex = 0;
            lbltur.Text = "label8";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lbldurum);
            groupBox7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox7.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox7.Location = new Point(176, 104);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(10, 3, 3, 3);
            groupBox7.Size = new Size(190, 58);
            groupBox7.TabIndex = 25;
            groupBox7.TabStop = false;
            groupBox7.Text = "Film Durumu";
            // 
            // lbldurum
            // 
            lbldurum.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbldurum.Location = new Point(5, 21);
            lbldurum.Name = "lbldurum";
            lbldurum.Size = new Size(180, 34);
            lbldurum.TabIndex = 0;
            lbldurum.Text = "label9";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(lblvizyontarihi);
            groupBox8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox8.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox8.Location = new Point(174, 163);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(10, 3, 3, 3);
            groupBox8.Size = new Size(190, 58);
            groupBox8.TabIndex = 24;
            groupBox8.TabStop = false;
            groupBox8.Text = "Film Vizyon Tarihi";
            // 
            // lblvizyontarihi
            // 
            lblvizyontarihi.Location = new Point(5, 21);
            lblvizyontarihi.Name = "lblvizyontarihi";
            lblvizyontarihi.Size = new Size(179, 33);
            lblvizyontarihi.TabIndex = 0;
            lblvizyontarihi.Text = "label10";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(lblIMDB);
            groupBox10.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox10.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox10.Location = new Point(9, 295);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(10, 3, 3, 3);
            groupBox10.Size = new Size(107, 80);
            groupBox10.TabIndex = 23;
            groupBox10.TabStop = false;
            groupBox10.Text = "IMDB Puanı";
            // 
            // lblIMDB
            // 
            lblIMDB.Location = new Point(5, 20);
            lblIMDB.Name = "lblIMDB";
            lblIMDB.Size = new Size(96, 57);
            lblIMDB.TabIndex = 0;
            lblIMDB.Text = "label11";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(lbldetay);
            groupBox11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox11.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox11.Location = new Point(8, 375);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(10, 3, 3, 3);
            groupBox11.Size = new Size(747, 204);
            groupBox11.TabIndex = 26;
            groupBox11.TabStop = false;
            groupBox11.Text = "Film Detayı";
            // 
            // lbldetay
            // 
            lbldetay.Location = new Point(8, 25);
            lbldetay.Name = "lbldetay";
            lbldetay.Size = new Size(734, 176);
            lbldetay.TabIndex = 0;
            lbldetay.Text = "label12";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 46, 80);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(4, 554);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 46, 80);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(4, 582);
            panel3.Name = "panel3";
            panel3.Size = new Size(759, 4);
            panel3.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(16, 46, 80);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(759, 32);
            panel4.Name = "panel4";
            panel4.Size = new Size(4, 550);
            panel4.TabIndex = 29;
            // 
            // FrmFilmDetay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            ClientSize = new Size(763, 586);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(groupBox11);
            Controls.Add(groupBox5);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox10);
            Controls.Add(groupBox4);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox9);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(450, 80);
            Margin = new Padding(5);
            Name = "FrmFilmDetay";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmFilmDetay";
            Load += FrmFilmDetay_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBResim).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnkapat;
        private Label label1;
        private GroupBox groupBox9;
        private PictureBox pBResim;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblFilmAdi;
        private GroupBox groupBox2;
        private Label lblyonetmen;
        private GroupBox groupBox3;
        private Label lbloyuncu;
        private GroupBox groupBox4;
        private Label lblbicim;
        private GroupBox groupBox5;
        private Label lblozellikler;
        private GroupBox groupBox6;
        private Label lbltur;
        private GroupBox groupBox7;
        private Label lbldurum;
        private GroupBox groupBox8;
        private Label lblvizyontarihi;
        private GroupBox groupBox10;
        private Label lblIMDB;
        private GroupBox groupBox11;
        private Label lbldetay;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}