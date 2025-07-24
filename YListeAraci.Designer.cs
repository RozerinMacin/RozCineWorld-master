namespace RozCineWorld
{
    partial class YListeAraci
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
            lbladi = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbladi
            // 
            lbladi.AutoSize = true;
            lbladi.Cursor = Cursors.Hand;
            lbladi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbladi.ForeColor = Color.FromArgb(16, 46, 80);
            lbladi.Location = new Point(28, 0);
            lbladi.Name = "lbladi";
            lbladi.Size = new Size(61, 25);
            lbladi.TabIndex = 3;
            lbladi.Text = "label1";
            lbladi.Click += lbladi_Click;
            lbladi.MouseLeave += lbladi_MouseLeave;
            lbladi.MouseMove += lbladi_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.artı1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // YListeAraci
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            Controls.Add(lbladi);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "YListeAraci";
            Size = new Size(210, 27);
            Load += YListeAraci_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbladi;
        private PictureBox pictureBox1;
    }
}
