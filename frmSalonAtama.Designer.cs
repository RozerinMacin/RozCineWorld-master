namespace RozCineWorld
{
    partial class frmSalonAtama
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
            label1 = new Label();
            btntemizle = new Button();
            BtnOlustur = new Button();
            groupBox7 = new GroupBox();
            cBSalonAdi = new ComboBox();
            lblsecilen = new Label();
            groupBox6 = new GroupBox();
            PanelSEANS = new FlowLayoutPanel();
            groupBox5 = new GroupBox();
            nYil = new NumericUpDown();
            nGun = new NumericUpDown();
            nAy = new NumericUpDown();
            lblgun = new Label();
            groupBox4 = new GroupBox();
            cBFilmAdi = new ComboBox();
            groupBox1 = new GroupBox();
            cBDoluSaatler = new ComboBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nAy).BeginInit();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 46, 80);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnkapat);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 32);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(918, 12);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
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
            btnkapat.Location = new Point(689, 0);
            btnkapat.Margin = new Padding(5);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(41, 32);
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
            label1.Location = new Point(2, 3);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 25);
            label1.TabIndex = 1;
            label1.Text = "[SALON ATAMA EKRANI]";
            // 
            // btntemizle
            // 
            btntemizle.BackColor = Color.FromArgb(190, 61, 42);
            btntemizle.Cursor = Cursors.Hand;
            btntemizle.FlatAppearance.BorderSize = 0;
            btntemizle.FlatStyle = FlatStyle.Flat;
            btntemizle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btntemizle.ForeColor = Color.White;
            btntemizle.Location = new Point(5, 220);
            btntemizle.Name = "btntemizle";
            btntemizle.Size = new Size(241, 30);
            btntemizle.TabIndex = 50;
            btntemizle.Text = "TEMİZLE";
            btntemizle.UseVisualStyleBackColor = false;
            btntemizle.Click += btntemizle_Click;
            // 
            // BtnOlustur
            // 
            BtnOlustur.BackColor = Color.FromArgb(190, 61, 42);
            BtnOlustur.Cursor = Cursors.Hand;
            BtnOlustur.FlatAppearance.BorderSize = 0;
            BtnOlustur.FlatStyle = FlatStyle.Flat;
            BtnOlustur.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnOlustur.ForeColor = Color.White;
            BtnOlustur.Location = new Point(6, 186);
            BtnOlustur.Name = "BtnOlustur";
            BtnOlustur.Size = new Size(240, 30);
            BtnOlustur.TabIndex = 49;
            BtnOlustur.Text = "TAMAMLA";
            BtnOlustur.UseVisualStyleBackColor = false;
            BtnOlustur.Click += BtnOlustur_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cBSalonAdi);
            groupBox7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox7.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox7.Location = new Point(7, 85);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(10, 3, 3, 3);
            groupBox7.Size = new Size(239, 48);
            groupBox7.TabIndex = 48;
            groupBox7.TabStop = false;
            groupBox7.Text = "Salon Adı";
            // 
            // cBSalonAdi
            // 
            cBSalonAdi.BackColor = Color.FromArgb(79, 149, 157);
            cBSalonAdi.Dock = DockStyle.Bottom;
            cBSalonAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSalonAdi.DropDownWidth = 240;
            cBSalonAdi.FlatStyle = FlatStyle.Flat;
            cBSalonAdi.ForeColor = Color.FromArgb(16, 46, 80);
            cBSalonAdi.FormattingEnabled = true;
            cBSalonAdi.IntegralHeight = false;
            cBSalonAdi.Location = new Point(10, 20);
            cBSalonAdi.Name = "cBSalonAdi";
            cBSalonAdi.Size = new Size(226, 25);
            cBSalonAdi.TabIndex = 2;
            // 
            // lblsecilen
            // 
            lblsecilen.AutoSize = true;
            lblsecilen.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblsecilen.ForeColor = Color.FromArgb(16, 46, 80);
            lblsecilen.Location = new Point(443, 356);
            lblsecilen.Name = "lblsecilen";
            lblsecilen.Size = new Size(98, 19);
            lblsecilen.TabIndex = 33;
            lblsecilen.Text = "lblkoltuksayisi";
            lblsecilen.Visible = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(PanelSEANS);
            groupBox6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox6.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox6.Location = new Point(254, 33);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(10, 3, 3, 3);
            groupBox6.Size = new Size(470, 217);
            groupBox6.TabIndex = 47;
            groupBox6.TabStop = false;
            groupBox6.Text = "Seans";
            // 
            // PanelSEANS
            // 
            PanelSEANS.AutoScroll = true;
            PanelSEANS.Dock = DockStyle.Fill;
            PanelSEANS.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            PanelSEANS.Location = new Point(10, 21);
            PanelSEANS.Name = "PanelSEANS";
            PanelSEANS.Size = new Size(457, 193);
            PanelSEANS.TabIndex = 32;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(nYil);
            groupBox5.Controls.Add(nGun);
            groupBox5.Controls.Add(nAy);
            groupBox5.Controls.Add(lblgun);
            groupBox5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox5.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox5.Location = new Point(6, 134);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10, 3, 3, 3);
            groupBox5.Size = new Size(240, 48);
            groupBox5.TabIndex = 46;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tarih";
            // 
            // nYil
            // 
            nYil.BorderStyle = BorderStyle.None;
            nYil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nYil.ForeColor = Color.FromArgb(16, 46, 80);
            nYil.Location = new Point(155, 21);
            nYil.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            nYil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nYil.Name = "nYil";
            nYil.Size = new Size(75, 21);
            nYil.TabIndex = 30;
            nYil.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // nGun
            // 
            nGun.BorderStyle = BorderStyle.None;
            nGun.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nGun.ForeColor = Color.FromArgb(16, 46, 80);
            nGun.Location = new Point(12, 22);
            nGun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nGun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nGun.Name = "nGun";
            nGun.Size = new Size(64, 21);
            nGun.TabIndex = 28;
            nGun.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nAy
            // 
            nAy.BorderStyle = BorderStyle.None;
            nAy.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nAy.ForeColor = Color.FromArgb(16, 46, 80);
            nAy.Location = new Point(82, 22);
            nAy.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nAy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nAy.Name = "nAy";
            nAy.Size = new Size(66, 21);
            nAy.TabIndex = 29;
            nAy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblgun
            // 
            lblgun.AutoSize = true;
            lblgun.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblgun.ForeColor = Color.FromArgb(16, 46, 80);
            lblgun.Location = new Point(167, 3);
            lblgun.Name = "lblgun";
            lblgun.Size = new Size(59, 13);
            lblgun.TabIndex = 27;
            lblgun.Text = "GG/AA/YY";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cBFilmAdi);
            groupBox4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox4.Location = new Point(7, 34);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10, 3, 3, 3);
            groupBox4.Size = new Size(239, 48);
            groupBox4.TabIndex = 45;
            groupBox4.TabStop = false;
            groupBox4.Text = "Film Adı";
            // 
            // cBFilmAdi
            // 
            cBFilmAdi.BackColor = Color.FromArgb(79, 149, 157);
            cBFilmAdi.Dock = DockStyle.Bottom;
            cBFilmAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cBFilmAdi.DropDownWidth = 240;
            cBFilmAdi.FlatStyle = FlatStyle.Flat;
            cBFilmAdi.ForeColor = Color.FromArgb(16, 46, 80);
            cBFilmAdi.FormattingEnabled = true;
            cBFilmAdi.IntegralHeight = false;
            cBFilmAdi.Location = new Point(10, 20);
            cBFilmAdi.Name = "cBFilmAdi";
            cBFilmAdi.Size = new Size(226, 25);
            cBFilmAdi.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cBDoluSaatler);
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox1.Location = new Point(95, 328);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 3, 3);
            groupBox1.Size = new Size(253, 62);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "dolu saatler";
            groupBox1.Visible = false;
            // 
            // cBDoluSaatler
            // 
            cBDoluSaatler.BackColor = Color.FromArgb(79, 149, 157);
            cBDoluSaatler.Dock = DockStyle.Bottom;
            cBDoluSaatler.DropDownStyle = ComboBoxStyle.DropDownList;
            cBDoluSaatler.DropDownWidth = 240;
            cBDoluSaatler.FlatStyle = FlatStyle.Flat;
            cBDoluSaatler.ForeColor = Color.FromArgb(16, 46, 80);
            cBDoluSaatler.FormattingEnabled = true;
            cBDoluSaatler.IntegralHeight = false;
            cBDoluSaatler.Location = new Point(10, 34);
            cBDoluSaatler.Name = "cBDoluSaatler";
            cBDoluSaatler.Size = new Size(240, 25);
            cBDoluSaatler.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 46, 80);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(4, 223);
            panel2.TabIndex = 52;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 46, 80);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(4, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(726, 4);
            panel3.TabIndex = 53;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(16, 46, 80);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(726, 32);
            panel4.Name = "panel4";
            panel4.Size = new Size(4, 219);
            panel4.TabIndex = 54;
            // 
            // frmSalonAtama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            ClientSize = new Size(730, 255);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lblsecilen);
            Controls.Add(groupBox1);
            Controls.Add(btntemizle);
            Controls.Add(BtnOlustur);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.FromArgb(16, 46, 80);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 250);
            Margin = new Padding(5);
            Name = "frmSalonAtama";
            StartPosition = FormStartPosition.Manual;
            Text = "frmSalonAtama";
            Load += frmSalonAtama_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nGun).EndInit();
            ((System.ComponentModel.ISupportInitialize)nAy).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnkapat;
        private Label label1;
        private Button btntemizle;
        private Button BtnOlustur;
        private GroupBox groupBox7;
        private Label lblsecilen;
        private ComboBox cBSalonAdi;
        private GroupBox groupBox6;
        private FlowLayoutPanel PanelSEANS;
        private GroupBox groupBox5;
        private Label lblgun;
        private GroupBox groupBox4;
        private ComboBox cBFilmAdi;
        private NumericUpDown nYil;
        private NumericUpDown nGun;
        private NumericUpDown nAy;
        private GroupBox groupBox1;
        private ComboBox cBDoluSaatler;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}