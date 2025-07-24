namespace RozCineWorld
{
    partial class OListeAraci
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
            pictureBox1 = new PictureBox();
            lbladi = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.artı1;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbladi
            // 
            lbladi.AutoSize = true;
            lbladi.Cursor = Cursors.Hand;
            lbladi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbladi.ForeColor = Color.FromArgb(16, 46, 80);
            lbladi.Location = new Point(28, 1);
            lbladi.Name = "lbladi";
            lbladi.Size = new Size(61, 25);
            lbladi.TabIndex = 1;
            lbladi.Text = "label1";
            lbladi.Click += lbladi_Click;
            lbladi.MouseLeave += lbladi_MouseLeave;
            lbladi.MouseMove += lbladi_MouseMove;
            // 
            // OListeAraci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            Controls.Add(lbladi);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F);
            Name = "OListeAraci";
            Size = new Size(210, 27);
            Load += OListeAraci_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public Label lbladi;
    }
}
