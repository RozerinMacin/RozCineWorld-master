namespace RozCineWorld
{
    partial class FilmListesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox9 = new GroupBox();
            lblIdNo = new Label();
            lblFilmAdi = new Label();
            BtnDetay = new Button();
            pBResim = new PictureBox();
            label2 = new Label();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBResim).BeginInit();
            SuspendLayout();
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(lblIdNo);
            groupBox9.Controls.Add(lblFilmAdi);
            groupBox9.Controls.Add(BtnDetay);
            groupBox9.Controls.Add(pBResim);
            groupBox9.Controls.Add(label2);
            groupBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox9.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox9.Location = new Point(5, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(10, 3, 3, 3);
            groupBox9.Size = new Size(163, 249);
            groupBox9.TabIndex = 17;
            groupBox9.TabStop = false;
            // 
            // lblIdNo
            // 
            lblIdNo.AutoSize = true;
            lblIdNo.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblIdNo.Location = new Point(119, 11);
            lblIdNo.Name = "lblIdNo";
            lblIdNo.Size = new Size(37, 15);
            lblIdNo.TabIndex = 9;
            lblIdNo.Text = "label1";
            lblIdNo.Visible = false;
            // 
            // lblFilmAdi
            // 
            lblFilmAdi.AutoSize = true;
            lblFilmAdi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFilmAdi.Location = new Point(5, 0);
            lblFilmAdi.Name = "lblFilmAdi";
            lblFilmAdi.Size = new Size(53, 23);
            lblFilmAdi.TabIndex = 8;
            lblFilmAdi.Text = "label1";
            // 
            // BtnDetay
            // 
            BtnDetay.BackColor = Color.FromArgb(190, 61, 42);
            BtnDetay.Cursor = Cursors.Hand;
            BtnDetay.FlatAppearance.BorderSize = 0;
            BtnDetay.FlatStyle = FlatStyle.Flat;
            BtnDetay.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnDetay.ForeColor = Color.White;
            BtnDetay.Location = new Point(6, 196);
            BtnDetay.Name = "BtnDetay";
            BtnDetay.Size = new Size(150, 41);
            BtnDetay.TabIndex = 7;
            BtnDetay.Text = "DETAY";
            BtnDetay.UseVisualStyleBackColor = false;
            BtnDetay.Click += BtnDetay_Click;
            // 
            // pBResim
            // 
            pBResim.BackColor = Color.FromArgb(79, 149, 157);
            pBResim.Image = Properties.Resources._10234;
            pBResim.Location = new Point(7, 29);
            pBResim.Name = "pBResim";
            pBResim.Size = new Size(149, 161);
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
            // FilmListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            Controls.Add(groupBox9);
            Name = "FilmListesi";
            Size = new Size(173, 260);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox9;
        private Button BtnDetay;
        private Label label2;
        public PictureBox pBResim;
        public Label lblFilmAdi;
        public Label lblIdNo;
    }
}
