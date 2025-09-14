namespace RozCineWorld
{
    partial class FrmBiletSorgulama
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
            label2 = new Label();
            txtBiletNo = new TextBox();
            BtnSorgula = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
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
            panel1.Size = new Size(457, 31);
            panel1.TabIndex = 10;
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
            btnkapat.Location = new Point(419, 0);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(38, 31);
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
            label1.Location = new Point(1, 1);
            label1.Name = "label1";
            label1.Size = new Size(269, 25);
            label1.TabIndex = 1;
            label1.Text = "[BİLET SORGULAMA EKRANI]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(21, 53);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 11;
            label2.Text = "Bilet Numarası:";
            // 
            // txtBiletNo
            // 
            txtBiletNo.BorderStyle = BorderStyle.FixedSingle;
            txtBiletNo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBiletNo.ForeColor = Color.FromArgb(16, 46, 80);
            txtBiletNo.Location = new Point(140, 54);
            txtBiletNo.MaxLength = 10;
            txtBiletNo.Name = "txtBiletNo";
            txtBiletNo.Size = new Size(303, 25);
            txtBiletNo.TabIndex = 12;
            // 
            // BtnSorgula
            // 
            BtnSorgula.BackColor = Color.FromArgb(190, 61, 42);
            BtnSorgula.Cursor = Cursors.Hand;
            BtnSorgula.FlatAppearance.BorderSize = 0;
            BtnSorgula.FlatStyle = FlatStyle.Flat;
            BtnSorgula.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSorgula.ForeColor = Color.White;
            BtnSorgula.Location = new Point(256, 85);
            BtnSorgula.Name = "BtnSorgula";
            BtnSorgula.Size = new Size(187, 30);
            BtnSorgula.TabIndex = 13;
            BtnSorgula.Text = "SORGULA";
            BtnSorgula.UseVisualStyleBackColor = false;
            BtnSorgula.Click += BtnSorgula_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 46, 80);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(4, 131);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 46, 80);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(4, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 4);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(16, 46, 80);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(453, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(4, 127);
            panel4.TabIndex = 16;
            // 
            // FrmBiletSorgulama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            ClientSize = new Size(457, 162);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(BtnSorgula);
            Controls.Add(txtBiletNo);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.FromArgb(16, 46, 80);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(550, 250);
            Margin = new Padding(5);
            Name = "FrmBiletSorgulama";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmBiletSorgulama";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnkapat;
        private Label label1;
        private Label label2;
        private TextBox txtBiletNo;
        private Button BtnSorgula;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}