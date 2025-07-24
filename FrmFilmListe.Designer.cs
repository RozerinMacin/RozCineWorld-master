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
            panel1.SuspendLayout();
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
            panel1.Size = new Size(571, 37);
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
            btnkapat.Location = new Point(533, 0);
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
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 1;
            label1.Text = "[FİLM LİSTE EKRANI]";
            // 
            // FrmFilmListe
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 149, 157);
            ClientSize = new Size(571, 723);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.FromArgb(16, 46, 80);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(550, 100);
            Margin = new Padding(5);
            Name = "FrmFilmListe";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmFilmListe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnkapat;
        private Label label1;
    }
}