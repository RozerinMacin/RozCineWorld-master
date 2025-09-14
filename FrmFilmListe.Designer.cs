namespace RozCineWorld
{
    partial class FrmFilmListe
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
            panel5 = new Panel();
            panel4 = new Panel();
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
            panel1.Size = new Size(490, 28);
            panel1.TabIndex = 3;
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
            btnkapat.Location = new Point(452, 0);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(38, 28);
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
            label1.Location = new Point(0, 1);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 1;
            label1.Text = "[FİLM LİSTE EKRANI]";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 46, 80);
            panel2.Controls.Add(txtarama);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.FromArgb(16, 46, 80);
            panel2.Location = new Point(0, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 37);
            panel2.TabIndex = 5;
            // 
            // txtarama
            // 
            txtarama.BorderStyle = BorderStyle.None;
            txtarama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtarama.ForeColor = Color.FromArgb(16, 46, 80);
            txtarama.Location = new Point(74, 6);
            txtarama.Name = "txtarama";
            txtarama.Size = new Size(372, 22);
            txtarama.TabIndex = 1;
            txtarama.TextChanged += txtarama_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 3);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 0;
            label2.Text = "Film Adı:";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(ListePaneli);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(490, 489);
            panel3.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(16, 46, 80);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(4, 485);
            panel5.Name = "panel5";
            panel5.Size = new Size(486, 4);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(16, 46, 80);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(4, 489);
            panel4.TabIndex = 2;
            // 
            // ListePaneli
            // 
            ListePaneli.AutoScroll = true;
            ListePaneli.Dock = DockStyle.Fill;
            ListePaneli.Location = new Point(0, 0);
            ListePaneli.Name = "ListePaneli";
            ListePaneli.Size = new Size(490, 489);
            ListePaneli.TabIndex = 1;
            // 
            // FrmFilmListe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            ClientSize = new Size(490, 554);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.FromArgb(16, 46, 80);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(600, 100);
            Margin = new Padding(5);
            Name = "FrmFilmListe";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmFilmListe";
            Load += FrmFilmListe_Load;
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
        private TextBox txtarama;
        private Label label2;
        private Panel panel3;
        private FlowLayoutPanel ListePaneli;
        private Panel panel5;
        private Panel panel4;
    }
}