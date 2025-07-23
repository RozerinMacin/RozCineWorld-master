namespace RozCineWorld
{
    partial class SalonListesi
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
            pictureBox1 = new PictureBox();
            lblsalonadi = new Label();
            label1 = new Label();
            lblkoltuksayisi = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 46, 80);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 109);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.koltukikonu;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblsalonadi
            // 
            lblsalonadi.AutoSize = true;
            lblsalonadi.Cursor = Cursors.Hand;
            lblsalonadi.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblsalonadi.ForeColor = Color.FromArgb(16, 46, 80);
            lblsalonadi.Location = new Point(102, 0);
            lblsalonadi.Name = "lblsalonadi";
            lblsalonadi.Size = new Size(70, 30);
            lblsalonadi.TabIndex = 2;
            lblsalonadi.Text = "label1";
            lblsalonadi.Click += lblsalonadi_Click;
            lblsalonadi.MouseLeave += ayrıl;
            lblsalonadi.MouseMove += gel;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(16, 46, 80);
            label1.Location = new Point(102, 75);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 3;
            label1.Text = "Koltuk Sayısı:";
            // 
            // lblkoltuksayisi
            // 
            lblkoltuksayisi.AutoSize = true;
            lblkoltuksayisi.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblkoltuksayisi.ForeColor = Color.FromArgb(16, 46, 80);
            lblkoltuksayisi.Location = new Point(207, 72);
            lblkoltuksayisi.Name = "lblkoltuksayisi";
            lblkoltuksayisi.Size = new Size(22, 30);
            lblkoltuksayisi.TabIndex = 4;
            lblkoltuksayisi.Text = "1";
            // 
            // SalonListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblkoltuksayisi);
            Controls.Add(label1);
            Controls.Add(lblsalonadi);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "SalonListesi";
            Size = new Size(257, 109);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        public Label lblsalonadi;
        private Label label1;
        public Label lblkoltuksayisi;
    }
}
