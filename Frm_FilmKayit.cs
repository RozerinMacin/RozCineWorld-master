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
    }
}
