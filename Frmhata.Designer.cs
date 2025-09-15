namespace RozCineWorld
{
    partial class Frmhata
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
            label2 = new Label();
            btnkapat = new Button();
            lblhata = new Label();
            pbMESAJ = new PictureBox();
            lblhatamesaji = new Label();
            btntamam = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMESAJ).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 46, 80);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnkapat);
            panel1.Controls.Add(lblhata);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 29);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(504, 2);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
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
            btnkapat.Location = new Point(345, 0);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(47, 29);
            btnkapat.TabIndex = 1;
            btnkapat.Text = "X";
            btnkapat.UseVisualStyleBackColor = false;
            btnkapat.Click += btnkapat_Click;
            // 
            // lblhata
            // 
            lblhata.AutoSize = true;
            lblhata.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblhata.ForeColor = Color.White;
            lblhata.Location = new Point(3, 1);
            lblhata.Name = "lblhata";
            lblhata.Size = new Size(71, 25);
            lblhata.TabIndex = 1;
            lblhata.Text = "HATA!";
            // 
            // pbMESAJ
            // 
            pbMESAJ.Image = Properties.Resources.carpi;
            pbMESAJ.Location = new Point(150, 47);
            pbMESAJ.Name = "pbMESAJ";
            pbMESAJ.Size = new Size(80, 50);
            pbMESAJ.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMESAJ.TabIndex = 3;
            pbMESAJ.TabStop = false;
            // 
            // lblhatamesaji
            // 
            lblhatamesaji.BackColor = SystemColors.Control;
            lblhatamesaji.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblhatamesaji.ForeColor = Color.FromArgb(16, 46, 80);
            lblhatamesaji.Location = new Point(50, 103);
            lblhatamesaji.Name = "lblhatamesaji";
            lblhatamesaji.Size = new Size(285, 43);
            lblhatamesaji.TabIndex = 4;
            lblhatamesaji.Text = "lblhatamesaji";
            lblhatamesaji.TextAlign = ContentAlignment.TopCenter;
            // 
            // btntamam
            // 
            btntamam.BackColor = Color.FromArgb(190, 61, 42);
            btntamam.Cursor = Cursors.Hand;
            btntamam.FlatStyle = FlatStyle.Flat;
            btntamam.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btntamam.ForeColor = Color.White;
            btntamam.Location = new Point(137, 149);
            btntamam.Name = "btntamam";
            btntamam.Size = new Size(117, 28);
            btntamam.TabIndex = 5;
            btntamam.Text = "TAMAM";
            btntamam.UseVisualStyleBackColor = false;
            btntamam.Click += button1_Click;
            // 
            // Frmhata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 199);
            Controls.Add(btntamam);
            Controls.Add(lblhatamesaji);
            Controls.Add(pbMESAJ);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmhata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frmhata";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMESAJ).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnkapat;
        public Label lblhatamesaji;
        public Label lblhata;
        public PictureBox pbMESAJ;
        public Button btntamam;
    }
}