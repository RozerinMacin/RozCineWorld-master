namespace RozCineWorld
{
    partial class FrmYonetmenListesi
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
            panel2 = new Panel();
            txtarama = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            ListePaneli = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 46, 80);
            panel1.Controls.Add(btnkapat);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(16, 46, 80);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 37);
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
            btnkapat.Location = new Point(462, 0);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(38, 37);
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
            label1.Location = new Point(2, 5);
            label1.Name = "label1";
            label1.Size = new Size(255, 25);
            label1.TabIndex = 1;
            label1.Text = "[YÖNETMEN LİSTE EKRANI]";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(txtarama);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.FromArgb(16, 46, 80);
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 37);
            panel2.TabIndex = 3;
            // 
            // txtarama
            // 
            txtarama.BorderStyle = BorderStyle.None;
            txtarama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtarama.ForeColor = Color.FromArgb(16, 46, 80);
            txtarama.Location = new Point(135, 4);
            txtarama.Name = "txtarama";
            txtarama.Size = new Size(334, 22);
            txtarama.TabIndex = 1;
            txtarama.TextChanged += txtarama_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(16, 46, 80);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 0;
            label2.Text = "Ad ve Soyad: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(79, 149, 157);
            panel3.Controls.Add(ListePaneli);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 468);
            panel3.TabIndex = 4;
            // 
            // ListePaneli
            // 
            ListePaneli.AutoScroll = true;
            ListePaneli.Dock = DockStyle.Fill;
            ListePaneli.Location = new Point(0, 0);
            ListePaneli.Name = "ListePaneli";
            ListePaneli.Size = new Size(500, 468);
            ListePaneli.TabIndex = 0;
            // 
            // FrmYonetmenListesi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            ClientSize = new Size(500, 542);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(550, 100);
            Margin = new Padding(5);
            Name = "FrmYonetmenListesi";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmYonetmenListesi";
            Load += FrmYonetmenListesi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnkapat;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel ListePaneli;
        private Label label2;
        private TextBox txtarama;
    }
}