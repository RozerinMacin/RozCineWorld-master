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
            lbladi.Cursor = Cursors.Hand;
            lbladi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbladi.ForeColor = Color.FromArgb(16, 46, 80);
            lbladi.Location = new Point(20, -1);
            lbladi.Margin = new Padding(2, 0, 2, 0);
            lbladi.Name = "lbladi";
            lbladi.Size = new Size(180, 17);
            lbladi.TabIndex = 3;
            lbladi.Text = "label1";
            lbladi.Click += lbladi_Click;
            lbladi.MouseLeave += lbladi_MouseLeave;
            lbladi.MouseMove += lbladi_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.artı1;
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // YListeAraci
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            Controls.Add(lbladi);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(2);
            Name = "YListeAraci";
            Size = new Size(200, 17);
            Load += YListeAraci_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label lbladi;
        private PictureBox pictureBox1;
    }
}
