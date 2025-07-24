namespace RozCineWorld
{
    partial class Frmacilis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnkapat = new Button();
            label1 = new Label();
            label2 = new Label();
            txtkullaniciadi = new TextBox();
            txtsifre = new TextBox();
            label3 = new Label();
            btngiris = new Button();
            panel1.SuspendLayout();
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
            panel1.Size = new Size(391, 38);
            panel1.TabIndex = 0;
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
            btnkapat.Location = new Point(353, 0);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(38, 38);
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
            label1.Location = new Point(4, 8);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 1;
            label1.Text = "RozCineWorld";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(16, 46, 80);
            label2.Location = new Point(66, 87);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "YETKİLİ KİŞİ:";
            // 
            // txtkullaniciadi
            // 
            txtkullaniciadi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtkullaniciadi.ForeColor = Color.FromArgb(16, 46, 80);
            txtkullaniciadi.Location = new Point(191, 87);
            txtkullaniciadi.Name = "txtkullaniciadi";
            txtkullaniciadi.Size = new Size(170, 27);
            txtkullaniciadi.TabIndex = 3;
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtsifre.ForeColor = Color.FromArgb(16, 46, 80);
            txtsifre.Location = new Point(191, 121);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(170, 27);
            txtsifre.TabIndex = 5;
            txtsifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(16, 46, 80);
            label3.Location = new Point(124, 122);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 4;
            label3.Text = "ŞİFRE:";
            // 
            // btngiris
            // 
            btngiris.BackColor = Color.FromArgb(190, 61, 42);
            btngiris.Cursor = Cursors.Hand;
            btngiris.FlatAppearance.BorderSize = 0;
            btngiris.FlatStyle = FlatStyle.Flat;
            btngiris.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btngiris.ForeColor = Color.White;
            btngiris.Location = new Point(226, 160);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(136, 36);
            btngiris.TabIndex = 6;
            btngiris.Text = "GİRİŞ YAP";
            btngiris.UseVisualStyleBackColor = false;
            btngiris.Click += btngiris_Click;
            // 
            // Frmacilis
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            ClientSize = new Size(391, 250);
            Controls.Add(btngiris);
            Controls.Add(txtsifre);
            Controls.Add(label3);
            Controls.Add(txtkullaniciadi);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmacilis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnkapat;
        private Label label2;
        private TextBox txtkullaniciadi;
        private TextBox txtsifre;
        private Label label3;
        private Button btngiris;
    }
}
