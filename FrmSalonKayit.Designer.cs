﻿namespace RozCineWorld
{
    partial class FrmSalonKayit
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
            groupBox1 = new GroupBox();
            BtnSalonKaydet = new Button();
            cBkoltukSayisi = new ComboBox();
            label3 = new Label();
            txtSalonAdi = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            Panelsalon = new FlowLayoutPanel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.Size = new Size(571, 36);
            panel1.TabIndex = 2;
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
            btnkapat.Location = new Point(533, 0);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(38, 36);
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
            label1.Location = new Point(2, 2);
            label1.Name = "label1";
            label1.Size = new Size(283, 32);
            label1.TabIndex = 1;
            label1.Text = "[SALON KAYIT EKRANI]";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnSalonKaydet);
            groupBox1.Controls.Add(cBkoltukSayisi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSalonAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox1.Location = new Point(1, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(568, 151);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // BtnSalonKaydet
            // 
            BtnSalonKaydet.BackColor = Color.FromArgb(190, 61, 42);
            BtnSalonKaydet.Cursor = Cursors.Hand;
            BtnSalonKaydet.FlatAppearance.BorderSize = 0;
            BtnSalonKaydet.FlatStyle = FlatStyle.Flat;
            BtnSalonKaydet.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSalonKaydet.ForeColor = Color.White;
            BtnSalonKaydet.Location = new Point(352, 90);
            BtnSalonKaydet.Name = "BtnSalonKaydet";
            BtnSalonKaydet.Size = new Size(191, 32);
            BtnSalonKaydet.TabIndex = 5;
            BtnSalonKaydet.Text = "KAYDET";
            BtnSalonKaydet.UseVisualStyleBackColor = false;
            BtnSalonKaydet.Click += BtnSalonKaydet_Click;
            // 
            // cBkoltukSayisi
            // 
            cBkoltukSayisi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cBkoltukSayisi.ForeColor = Color.FromArgb(16, 46, 80);
            cBkoltukSayisi.FormattingEnabled = true;
            cBkoltukSayisi.Location = new Point(291, 46);
            cBkoltukSayisi.Name = "cBkoltukSayisi";
            cBkoltukSayisi.Size = new Size(254, 31);
            cBkoltukSayisi.TabIndex = 3;
            cBkoltukSayisi.TextChanged += cBkoltukSayisi_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 15);
            label3.Name = "label3";
            label3.Size = new Size(152, 28);
            label3.TabIndex = 2;
            label3.Text = "KOLTUK SAYISI:";
            // 
            // txtSalonAdi
            // 
            txtSalonAdi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSalonAdi.ForeColor = Color.FromArgb(16, 46, 80);
            txtSalonAdi.Location = new Point(22, 47);
            txtSalonAdi.Name = "txtSalonAdi";
            txtSalonAdi.Size = new Size(238, 30);
            txtSalonAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 14);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 0;
            label2.Text = "SALON ADI:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Panelsalon);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(16, 46, 80);
            groupBox2.Location = new Point(1, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(567, 527);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // Panelsalon
            // 
            Panelsalon.AutoScroll = true;
            Panelsalon.Dock = DockStyle.Fill;
            Panelsalon.Location = new Point(3, 30);
            Panelsalon.Name = "Panelsalon";
            Panelsalon.Size = new Size(561, 494);
            Panelsalon.TabIndex = 0;
            // 
            // FrmSalonKayit
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            ClientSize = new Size(571, 723);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(550, 100);
            Margin = new Padding(5);
            Name = "FrmSalonKayit";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmSalonKayit";
            Load += FrmSalonKayit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnkapat;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtSalonAdi;
        private Label label2;
        private ComboBox cBkoltukSayisi;
        private Button BtnSalonKaydet;
        private GroupBox groupBox2;
        private FlowLayoutPanel Panelsalon;
    }
}