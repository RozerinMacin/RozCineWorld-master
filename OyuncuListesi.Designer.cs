namespace RozCineWorld
{
    partial class OyuncuListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuListesi));
            btnsil = new Button();
            label2 = new Label();
            label1 = new Label();
            lblID = new Label();
            lblCinsiyet = new Label();
            btndetay = new Button();
            pBResim = new PictureBox();
            lblAdSoyad = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pBResim).BeginInit();
            SuspendLayout();
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.FromArgb(190, 61, 42);
            btnsil.Cursor = Cursors.Hand;
            btnsil.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnsil, "btnsil");
            btnsil.ForeColor = Color.White;
            btnsil.Name = "btnsil";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(16, 46, 80);
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(16, 46, 80);
            label1.Name = "label1";
            // 
            // lblID
            // 
            resources.ApplyResources(lblID, "lblID");
            lblID.ForeColor = Color.FromArgb(16, 46, 80);
            lblID.Name = "lblID";
            // 
            // lblCinsiyet
            // 
            resources.ApplyResources(lblCinsiyet, "lblCinsiyet");
            lblCinsiyet.ForeColor = Color.FromArgb(16, 46, 80);
            lblCinsiyet.Name = "lblCinsiyet";
            // 
            // btndetay
            // 
            btndetay.BackColor = Color.FromArgb(190, 61, 42);
            btndetay.Cursor = Cursors.Hand;
            btndetay.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btndetay, "btndetay");
            btndetay.ForeColor = Color.White;
            btndetay.Name = "btndetay";
            btndetay.UseVisualStyleBackColor = false;
            btndetay.Click += btndetay_Click;
            // 
            // pBResim
            // 
            pBResim.Image = Properties.Resources.fotografyok;
            resources.ApplyResources(pBResim, "pBResim");
            pBResim.Name = "pBResim";
            pBResim.TabStop = false;
            // 
            // lblAdSoyad
            // 
            resources.ApplyResources(lblAdSoyad, "lblAdSoyad");
            lblAdSoyad.ForeColor = Color.FromArgb(16, 46, 80);
            lblAdSoyad.Name = "lblAdSoyad";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 46, 80);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // OyuncuListesi
            // 
            resources.ApplyResources(this, "$this");
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
            Name = "OyuncuListesi";
            Load += OyuncuListesi_Load;
            ((System.ComponentModel.ISupportInitialize)pBResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsil;
        public Label label2;
        public Label label1;
        public Label lblID;
        public Label lblCinsiyet;
        private Button btndetay;
        public PictureBox pBResim;
        public Label lblAdSoyad;
        private Panel panel1;
    }
}
