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
        SqlConnection baglanti = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
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
            bugununtarihi();

        }
        void bugununtarihi()
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;
        }
        void oListeGetir()
        {
            string sorgu = "select * from Tbl_Oyuncular ORDER BY AdSoyad ASC";
            FoyuncuPaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                OListeAraci arac = new OListeAraci();
                arac.lbladi.Text = oku["AdSoyad"].ToString();
                FoyuncuPaneli.Controls.Add(arac);
            }
            baglanti.Close();
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
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                OListeAraci arac = new OListeAraci();
                arac.lbladi.Text = oku["AdSoyad"].ToString();
                FoyuncuPaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }
        void yListeGetir()
        {
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY AdSoyad ASC";
            FYonetmenPaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                YListeAraci arac = new YListeAraci();
                arac.lbladi.Text = oku["AdSoyad"].ToString();
                FYonetmenPaneli.Controls.Add(arac);
            }
            baglanti.Close();
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
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                YListeAraci arac = new YListeAraci();
                arac.lbladi.Text = oku["AdSoyad"].ToString();
                FYonetmenPaneli.Controls.Add(arac);
            }
            baglanti.Close();
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
        private void btntarihsec_Click(object sender, EventArgs e)
        {
            Vizyontarihi();
        }
        string vTarih = "";
        string durum = "0";
        void Vizyontarihi()
        {
            vTarih = nGun.Value + "." + nAy.Value + "." + nYil.Value;
            DateTime dVTarih = Convert.ToDateTime(vTarih);
            DateTime bugun = DateTime.Today;

            TimeSpan TSpan = dVTarih - bugun;
            if (TSpan.TotalDays < 0)
            {
                MessageBox.Show("Geçmiş tarihlere ait film eklenmesi yapılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bugununtarihi();
            }
            else if (TSpan.TotalDays == 0)
            {
                MessageBox.Show(txtfilmAdi.Text + " :Filmi şuan vizyonda.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                durum = "1"; // film vizyonda.
            }
            else
            {
                MessageBox.Show("Vizyon tarihi: " + vTarih, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                durum = "0"; // film vizyona girmedi.
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToShortDateString();
        }
        string yonetmen = "";
        string oyuncu = "";
        void Soyuncu()
        {
            string sorgu = "select * from Tbl_Secilenler where Tur = 'OYUNCU'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oyuncu += " ," + oku["Kisi"].ToString();
            }
            baglanti.Close();
        }
        void Syonetmen() 
        {
            string sorgu = "select * from Tbl_Secilenler where Tur = 'YÖNETMEN'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu,baglanti);
            baglanti.Close();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yonetmen += " ," + oku["Kisi"].ToString();
            }
            baglanti.Close();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //insert into deyimini kullanarak veritabanına film bilgilerini ekleyeceğiz.
            //input kontrolleri yapacağız.
            Syonetmen();
            Soyuncu();
            Tur();
            bicim();
            ozellikler();

            string sorgu = "INSERT INTO Tbl_Filmler (Film_Adi,Film_Türü,Film_Ozellikleri,Film_Bicimi,Film_Yonetmeni,Film_Oyuncuları,Film_VizyonTarihi,Film_IMDB_Puanı,Film_Detayi,Film_Afisi,Film_Durumu) VALUES (@adi,@turu,@ozellikleri,@bicimi,@yonetmen,@oyuncu,@vizyontarihi,@puan,@detay,@afis,@durum)";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@adi",txtfilmAdi.Text.ToUpper());
            if (secilentur.Length > 2)
            {
                komut.Parameters.AddWithValue("@turu", secilentur.Substring(2));
            }
            else
            {
                MessageBox.Show("Lütfen en az bir tür seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (secilenOzellik.Length > 2)
            {
                komut.Parameters.AddWithValue("@ozellikleri", secilenOzellik.Substring(2));
            }
            else
            {
                MessageBox.Show("Lütfen en az bir özellik seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (secilenBicim.Length > 2)
            {
                komut.Parameters.AddWithValue("@bicimi", secilenBicim.Substring(2));
            }
            else
            {
                MessageBox.Show("Lütfen en az bir biçim seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (yonetmen.Length > 2)
            {
                komut.Parameters.AddWithValue("@yonetmen", yonetmen.Substring(2));
            }
            else
            {
                MessageBox.Show("Lütfen en az bir yönetmen seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (oyuncu.Length > 2)
            {
                komut.Parameters.AddWithValue("@oyuncu", oyuncu.Substring(2));
            }
            else
            {
                MessageBox.Show("Lütfen en az bir oyuncu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            komut.Parameters.AddWithValue("@vizyontarihi",vTarih);
            komut.Parameters.AddWithValue("@puan",lblReyting.Text);
            komut.Parameters.AddWithValue("@detay",txtFilmDetay.Text.ToUpper());
            komut.Parameters.AddWithValue("@afis",resimyolu);
            komut.Parameters.AddWithValue("@durum",durum);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(txtfilmAdi.Text + ":Film kaydı başarılı bir şekilde gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string secilentur = "";
        void Tur()
        {
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
        }
        string secilenBicim = "";
        void bicim() 
        {
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
        }
        string secilenOzellik = "";
        void ozellikler() 
        {
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
        }
    }
}
