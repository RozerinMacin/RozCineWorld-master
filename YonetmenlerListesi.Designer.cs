namespace RozCineWorld
{
    partial class YonetmenlerListesi
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
            panel1 = new Panel();
            lblAdSoyad = new Label();
            pBResim = new PictureBox();
            btndetay = new Button();
            lblCinsiyet = new Label();
            lblID = new Label();
            label1 = new Label();
            label2 = new Label();
            btnsil = new Button();
            ((System.ComponentModel.ISupportInitialize)pBResim).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 46, 80);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 103);
            panel1.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdSoyad.ForeColor = Color.FromArgb(16, 46, 80);
            lblAdSoyad.Location = new Point(243, 3);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(76, 32);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "label1";
            // 
            // pBResim
            // 
            pBResim.Image = Properties.Resources.fotografyok;
            pBResim.Location = new Point(9, 4);
            pBResim.Margin = new Padding(3, 4, 3, 4);
            pBResim.Name = "pBResim";
            pBResim.Size = new Size(114, 95);
            pBResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pBResim.TabIndex = 2;
            pBResim.TabStop = false;
            // 
            // btndetay
            // 
            btndetay.BackColor = Color.FromArgb(190, 61, 42);
            btndetay.Cursor = Cursors.Hand;
            btndetay.FlatAppearance.BorderSize = 0;
            btndetay.FlatStyle = FlatStyle.Flat;
            btndetay.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btndetay.ForeColor = Color.White;
            btndetay.Location = new Point(346, 57);
            btndetay.Margin = new Padding(3, 4, 3, 4);
            btndetay.Name = "btndetay";
            btndetay.Size = new Size(117, 41);
            btndetay.TabIndex = 5;
            btndetay.Text = "DETAY";
            btndetay.UseVisualStyleBackColor = false;
            btndetay.Click += btndetay_Click;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCinsiyet.ForeColor = Color.FromArgb(16, 46, 80);
            lblCinsiyet.Location = new Point(242, 36);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(76, 32);
            lblCinsiyet.TabIndex = 8;
            lblCinsiyet.Text = "label1";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblID.ForeColor = Color.FromArgb(16, 46, 80);
            lblID.Location = new Point(462, 3);
            lblID.Name = "lblID";
            lblID.Size = new Size(76, 32);
            lblID.TabIndex = 9;
            lblID.Text = "label1";
            lblID.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(16, 46, 80);
            label1.Location = new Point(126, 1);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 10;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(16, 46, 80);
            label2.Location = new Point(139, 35);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 11;
            label2.Text = "Cinsiyet:";
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.FromArgb(190, 61, 42);
            btnsil.Cursor = Cursors.Hand;
            btnsil.FlatAppearance.BorderSize = 0;
            btnsil.FlatStyle = FlatStyle.Flat;
            btnsil.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnsil.ForeColor = Color.White;
            btnsil.Location = new Point(468, 57);
            btnsil.Margin = new Padding(3, 4, 3, 4);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(69, 41);
            btnsil.TabIndex = 12;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // YonetmenlerListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnsil);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblID);
            Controls.Add(lblCinsiyet);
            Controls.Add(btndetay);
            Controls.Add(pBResim);
            Controls.Add(lblAdSoyad);
            Controls.Add(panel1);
            Name = "YonetmenlerListesi";
            Size = new Size(542, 103);
            Load += YonetmenlerListesi_Load;
            ((System.ComponentModel.ISupportInitialize)pBResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label lblAdSoyad;
        public PictureBox pBResim;
        private Button btndetay;
        public Label lblCinsiyet;
        public Label lblID;
        public Label label1;
        public Label label2;
        private Button btnsil;
    }
}
