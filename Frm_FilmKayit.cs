using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozCineWorld
{
    public partial class Frm_FilmKayit : Form
    {
        public Frm_FilmKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler", connection);
            komut.ExecuteNonQuery();
            connection.Close();
        }

        private void rB1_CheckedChanged(object sender, EventArgs e)
        {
            lblReyting.Text = "1";
        }
        private void rB2_CheckedChanged(object sender, EventArgs e)
        {
            lblReyting.Text = "2";
        }
        private void rB3_CheckedChanged(object sender, EventArgs e)
        {
            lblReyting.Text = "3";
        }
        private void rB4_CheckedChanged(object sender, EventArgs e)
        {
            lblReyting.Text = "4";
        }
        private void rB5_CheckedChanged(object sender, EventArgs e)
        {
            lblReyting.Text = "5";
        }
        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            lblReyting.Text = "6";
        }
        private void rB7_CheckedChanged(object sender, EventArgs e)
        {
            lblReyting.Text = "7";
        }
        private void rB8_CheckedChanged(object sender, EventArgs e)
        {
            lblReyting.Text = "8";
        }
        private void rB9_CheckedChanged(object sender, EventArgs e)
        {
            lblReyting.Text = "9";
        }
        private void rB10_CheckedChanged(object sender, EventArgs e)
        {
            lblReyting.Text = "10";
        }
        public string resimyolu = "";
        private void BtnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG | *.jpg | JPEG | *.jpeg | ALL Files | *.*";
            ofd.FilterIndex = 4;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pBResim.Image = new Bitmap(ofd.FileName);
                resimyolu = ofd.FileName.ToString();
            }
        }
        private void txtFilmDetay_TextChanged(object sender, EventArgs e)
        {
            int karaktersayisi = txtFilmDetay.Text.Length;
            int geri = 300 - karaktersayisi;
            lblKarakter.Text = geri.ToString();
            if (geri > 50)
            {
                lblKarakter.ForeColor = Color.FromArgb(16, 46, 80);
            }
            if (geri <= 50)
            {
                lblKarakter.ForeColor = Color.Orange;
            }
            if (geri <= 25)
            {
                lblKarakter.ForeColor = Color.Red;
            }
        }
        private void Frm_FilmKayit_Load(object sender, EventArgs e)
        {
            oListeGetir();
            yListeGetir();
        }
        void oListeGetir()
        {
            string sorgu = "select * from Tbl_Oyuncular ORDER BY AdSoyad ASC";
            FoyuncuPaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                OListeAraci arac = new OListeAraci();
                arac.lbladi.Text = oku["AdSoyad"].ToString();
                FoyuncuPaneli.Controls.Add(arac);
            }
            connection.Close();
        }

        private void txtOyuncuara_MouseMove(object sender, MouseEventArgs e)
        {
            lblOyuncuAra.Visible = true;
        }

        private void txtOyuncuara_MouseLeave(object sender, EventArgs e)
        {
            lblOyuncuAra.Visible = false;
        }

        private void txtOyuncuara_TextChanged(object sender, EventArgs e)
        {
            OyuncuAra();
        }
        void OyuncuAra()
        {
            string sorgu = "select * from Tbl_Oyuncular where AdSoyad LIKE '%" + txtOyuncuara.Text + "%' collate Turkish_CI_AS ORDER BY AdSoyad ASC";
            FoyuncuPaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                OListeAraci arac = new OListeAraci();
                arac.lbladi.Text = oku["AdSoyad"].ToString();
                FoyuncuPaneli.Controls.Add(arac);
            }
            connection.Close();
        }
        void yListeGetir()
        {
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY AdSoyad ASC";
            FYonetmenPaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                YListeAraci arac = new YListeAraci();
                arac.lbladi.Text = oku["AdSoyad"].ToString();
                FYonetmenPaneli.Controls.Add(arac);
            }
            connection.Close();
        }

        private void txtYonetmenara_MouseMove(object sender, MouseEventArgs e)
        {
            lblyonetmenara.Visible = true;
        }
        private void txtYonetmenara_MouseLeave(object sender, EventArgs e)
        {
            lblyonetmenara.Visible = false;
        }
        private void txtYonetmenara_TextChanged(object sender, EventArgs e)
        {
            YonetmenAra();
        }
        void YonetmenAra()
        {
            string sorgu = "select * from Tbl_Yonetmenler where AdSoyad LIKE '%" + txtYonetmenara.Text + "%'collate Turkish_CI_AS ORDER BY AdSoyad ASC";
            FYonetmenPaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                YListeAraci arac = new YListeAraci();
                arac.lbladi.Text = oku["AdSoyad"].ToString();
                FYonetmenPaneli.Controls.Add(arac);
            }
            connection.Close();
        }
        private void lblAksiyon_Click(object sender, EventArgs e)
        {
            if (lblAksiyon.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblAksiyon.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblAksiyon.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }
        private void lblromantik_Click(object sender, EventArgs e)
        {
            if (lblromantik.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblromantik.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblromantik.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }
        private void lblFantastik_Click(object sender, EventArgs e)
        {
            if (lblFantastik.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblFantastik.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblFantastik.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }
        private void lblBilimKurgu_Click(object sender, EventArgs e)
        {
            if (lblBilimKurgu.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblBilimKurgu.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblBilimKurgu.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }
        private void lblDrama_Click(object sender, EventArgs e)
        {
            if (lblDrama.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblDrama.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblDrama.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }
        private void lblkomedi_Click(object sender, EventArgs e)
        {
            if (lblkomedi.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblkomedi.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblkomedi.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }
        private void lblsuc_Click(object sender, EventArgs e)
        {
            if (lblsuc.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblsuc.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblsuc.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string secilentur = "";
            foreach (Control arac in gBFilm_turleri.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(16, 46, 80))
                    {

                    }
                    else
                    {
                        secilentur += " ," + arac.Text.ToString();
                    }
                }
            }
            if (secilentur.Length > 2)
            {
                MessageBox.Show(secilentur = secilentur.Substring(2));
            }
            else
            {
                MessageBox.Show("Lütfen en az bir tür seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void lblturkce_Click(object sender, EventArgs e)
        {
            if (lblturkce.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblturkce.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblturkce.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }
        private void lblaltyazi_Click(object sender, EventArgs e)
        {
            if (lblaltyazi.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblaltyazi.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblaltyazi.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }
        private void lblingilizce_Click(object sender, EventArgs e)
        {
            if (lblingilizce.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblingilizce.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblingilizce.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string secilenBicim = "";
            foreach (Control arac in gBFilm_bicimi.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(16, 46, 80))
                    {

                    }
                    else
                    {
                        secilenBicim += " ," + arac.Text.ToString();
                    }
                }
            }
            if (secilenBicim.Length > 2)
            {
                MessageBox.Show(secilenBicim = secilenBicim.Substring(2));
            }
            else
            {
                MessageBox.Show("Lütfen en az bir tür seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void lblkorkusiddet_Click(object sender, EventArgs e)
        {
            if (lblkorkusiddet.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblkorkusiddet.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblkorkusiddet.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }

        private void lblolumsuzicerik_Click(object sender, EventArgs e)
        {
            if (lblolumsuzicerik.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblolumsuzicerik.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblolumsuzicerik.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }

        private void lblgenelizleyici_Click(object sender, EventArgs e)
        {
            if (lblgenelizleyici.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lblgenelizleyici.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lblgenelizleyici.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }

        private void lbl_7_Click(object sender, EventArgs e)
        {
            if (lbl_7.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lbl_7.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lbl_7.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }

        private void lbl_13_Click(object sender, EventArgs e)
        {
            if (lbl_13.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lbl_13.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lbl_13.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }

        private void lbl_18_Click(object sender, EventArgs e)
        {
            if (lbl_18.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lbl_18.ForeColor = Color.FromArgb(190, 61, 42);
            }
            else
            {
                lbl_18.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string secilenOzellik = "";
            foreach (Control arac in gBFilm_ozellik.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(16, 46, 80))
                    {

                    }
                    else
                    {
                        secilenOzellik += " ," + arac.Text.ToString();
                    }
                }
            }
            if (secilenOzellik.Length > 2)
            {
                MessageBox.Show(secilenOzellik = secilenOzellik.Substring(2));
            }
            else
            {
                MessageBox.Show("Lütfen en az bir tür seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
