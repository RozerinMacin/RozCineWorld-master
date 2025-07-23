using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//sql bağlantısı için gerekli olacak kütüphane.
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
        // SqlConnection sınıfından bir bağlantı nesnesi oluşturuyoruz.
        SqlConnection baglanti = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();//bulunduğumuz formu kapatıyoruz.
            // Seçilen oyuncu ve yönetmenleri temizliyoruz forum kapandıktan sonra.
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // Bu metodlar, radyo düğmesi seçildiğinde çağrılır.
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
        // Resim yükleme butonuna tıklandığında çalışacak kod.
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
        // Film detay metni değiştiğinde karakter sayısını kontrol eden kod.
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
            // Form yüklendiğinde gerekli verileri getiriyoruz.
            // Oyuncu ve yönetmen listelerini getiriyoruz.
            // Ayrıca bugünün tarihini de ayarlıyoruz.

            oListeGetir();
            yListeGetir();
            bugununtarihi();

        }
        void bugununtarihi()// Bugünün tarihini alır ve ilgili numeric up down kontrollerine atar.
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;
        }
        void oListeGetir()// Oyuncu listesini veritabanından alır ve panelde gösterir.
        {
            try// Bağlantı açılır ve oyuncu verileri çekilir.hata yakalamak için try-catch bloğu kullanıyoruz.
            {
                string sorgu = "select * from Tbl_Oyuncular ORDER BY AdSoyad ASC";
                FoyuncuPaneli.Controls.Clear();
                if (baglanti.State == ConnectionState.Closed)// Bağlantı kapalıysa açıyoruz.
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    OListeAraci arac = new OListeAraci();
                    arac.lbladi.Text = oku["AdSoyad"].ToString();
                    FoyuncuPaneli.Controls.Add(arac);
                }
            }
            catch (Exception ex)// Hata oluşursa kullanıcıya mesaj gösteriyoruz.
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally// Bağlantı açık ise kapatıyoruz.
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void txtOyuncuara_MouseMove(object sender, MouseEventArgs e)// Oyuncu arama kutusuna fare ile gelindiğinde etiket görünür hale gelir.
        {
            lblOyuncuAra.Visible = true;
        }

        private void txtOyuncuara_MouseLeave(object sender, EventArgs e)// Oyuncu arama kutusundan fare ayrıldığında etiket gizlenir.
        {
            lblOyuncuAra.Visible = false;
        }
        private void txtOyuncuara_TextChanged(object sender, EventArgs e)// Oyuncu arama kutusundaki metin değiştiğinde OyuncuAra metodunu çağırır.
        {
            OyuncuAra();
        }
        void OyuncuAra()// Oyuncu arama işlemini gerçekleştirir.veritabanından oyuncu adını arar ve sonuçları panelde gösterir.
        {
            try
            {
                string sorgu = "select * from Tbl_Oyuncular where AdSoyad LIKE '%" + txtOyuncuara.Text + "%' collate Turkish_CI_AS ORDER BY AdSoyad ASC";
                FoyuncuPaneli.Controls.Clear();
                if (baglanti.State == ConnectionState.Closed)// Bağlantı kapalıysa açıyoruz.
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    OListeAraci arac = new OListeAraci();
                    arac.lbladi.Text = oku["AdSoyad"].ToString();
                    FoyuncuPaneli.Controls.Add(arac);
                }
            }
            catch (Exception ex)// Hata oluşursa kullanıcıya mesaj gösteriyoruz.
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally// Bağlantı açık ise kapatıyoruz.
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
        void yListeGetir()// Yönetmen listesini veritabanından alır ve panelde gösterir.
        {
            try
            {
                string sorgu = "select * from Tbl_Yonetmenler ORDER BY AdSoyad ASC";
                FYonetmenPaneli.Controls.Clear();
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    YListeAraci arac = new YListeAraci();
                    arac.lbladi.Text = oku["AdSoyad"].ToString();
                    FYonetmenPaneli.Controls.Add(arac);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
        private void txtYonetmenara_MouseMove(object sender, MouseEventArgs e)// Yönetmen arama kutusuna fare ile gelindiğinde etiket görünür hale gelir.
        {
            lblyonetmenara.Visible = true;
        }
        private void txtYonetmenara_MouseLeave(object sender, EventArgs e)// Yönetmen arama kutusundan fare ayrıldığında etiket gizlenir.
        {
            lblyonetmenara.Visible = false;
        }
        private void txtYonetmenara_TextChanged(object sender, EventArgs e)// Yönetmen arama kutusundaki metin değiştiğinde YonetmenAra metodunu çağırır.
        {
            YonetmenAra();
        }
        void YonetmenAra()// Yönetmen arama işlemini gerçekleştirir.veritabanından yönetmen adını arar ve sonuçları panelde gösterir.
        {
            try
            {
                string sorgu = "select * from Tbl_Yonetmenler where AdSoyad LIKE '%" + txtYonetmenara.Text + "%'collate Turkish_CI_AS ORDER BY AdSoyad ASC";
                FYonetmenPaneli.Controls.Clear();
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    YListeAraci arac = new YListeAraci();
                    arac.lbladi.Text = oku["AdSoyad"].ToString();
                    FYonetmenPaneli.Controls.Add(arac);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
        void EtiketRenginiDegistir(Label Etiket)// Etiket rengini değiştirir. Eğer etiketin rengi varsayılan mavi ise, seçilen renge (kırmızı) değiştirir, aksi halde varsayılan renge geri döner.
        {
            Color varsayilanrenk = Color.FromArgb(16, 46, 80);
            Color secilenrenk = Color.FromArgb(190, 61, 42);
            if (Etiket.ForeColor == varsayilanrenk)
            {
                Etiket.ForeColor = secilenrenk;
            }
            else
            {
                Etiket.ForeColor = varsayilanrenk;
            }
        }
        // Etiketlere tıklandığında rengini değiştiren olaylar.
        private void lblAksiyon_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblAksiyon);
        }
        private void lblromantik_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblromantik);
        }
        private void lblFantastik_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblFantastik);
        }
        private void lblBilimKurgu_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblBilimKurgu);
        }
        private void lblDrama_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblDrama);
        }
        private void lblkomedi_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblkomedi);
        }
        private void lblsuc_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblsuc);
        }
        private void lblturkce_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblturkce);
        }
        private void lblaltyazi_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblaltyazi);
        }
        private void lblingilizce_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblingilizce);
        }
        private void lblkorkusiddet_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblkorkusiddet);
        }
        private void lblolumsuzicerik_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblolumsuzicerik);
        }
        private void lblgenelizleyici_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lblgenelizleyici);
        }
        private void lbl_7_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lbl_7);
        }
        private void lbl_13_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lbl_13);
        }
        private void lbl_18_Click(object sender, EventArgs e)
        {
            EtiketRenginiDegistir(lbl_18);
        }
        private void btntarihsec_Click(object sender, EventArgs e)// Vizyon tarihi seçme butonuna tıklandığında çalışacak kod.
        {
            // NumericUpDown kontrollerinden vizyon tarihini alır ve kontrol eder.
            // Eğer tarih geçmişte ise kullanıcıya uyarı verir.
            // Eğer tarih bugünün tarihi ise film vizyonda olarak kabul edilir.
            // Aksi halde film vizyona girmemiş olarak kabul edilir.
            Vizyontarihi();
        }
        string vTarih = "";
        string durum = "0";
        void Vizyontarihi()// Vizyon tarihini kontrol eder.
        {
            vTarih = nGun.Value + "." + nAy.Value + "." + nYil.Value;
            DateTime dVTarih = Convert.ToDateTime(vTarih);
            DateTime bugun = DateTime.Today;

            TimeSpan TSpan = dVTarih - bugun;
            if (TSpan.TotalDays < 0)// Eğer vizyon tarihi geçmişte ise kullanıcıya uyarı verir.
            {
                MessageBox.Show("Geçmiş tarihlere ait film eklenmesi yapılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bugununtarihi();
            }
            else if (TSpan.TotalDays == 0)// Eğer vizyon tarihi bugünün tarihi ise film vizyonda olarak kabul edilir.
            {
                MessageBox.Show(txtfilmAdi.Text + " :Filmi şuan vizyonda.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                durum = "1"; // film vizyonda.
            }
            else// Eğer vizyon tarihi gelecekte ise film vizyona girmemiş olarak kabul edilir.
            {
                MessageBox.Show("Vizyon tarihi: " + vTarih, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                durum = "0"; // film vizyona girmedi.
            }
        }
        private void timer1_Tick(object sender, EventArgs e)// Timer her saniye çalışır ve lbltarih etiketine bugünün tarihini atar.
        {
            lbltarih.Text = DateTime.Now.ToShortDateString();
        }
        string yonetmen = "";
        string oyuncu = "";
        void Soyuncu()// Oyuncu listesini veritabanından alır ve oyuncu değişkenine atar.
        {
            try
            {
                oyuncu = "";
                string sorgu = "select * from Tbl_Secilenler where Tur = 'OYUNCU'";
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    oyuncu += " ," + oku["Kisi"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
        void Syonetmen()// Yönetmen listesini veritabanından alır ve yonetmen değişkenine atar.
        {
            try
            {
                yonetmen = "";
                string sorgu = "select * from Tbl_Secilenler where Tur = 'YÖNETMEN'";
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    yonetmen += " ," + oku["Kisi"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
        private void BtnKaydet_Click(object sender, EventArgs e)// Film kaydetme butonuna tıklandığında çalışacak kod.
        {
            //insert into deyimini kullanarak veritabanına film bilgilerini ekleyeceğiz.
            //input kontrolleri yapacağız.
            Syonetmen();
            Soyuncu();
            TurleriAl();
            BicimleriAl();
            OzellikleriAl();
            // Film adı, detay, yönetmen, oyuncu, resim yolu, vizyon tarihi, tür, özellik ve biçim bilgilerini kontrol ediyoruz.
            if (txtfilmAdi.Text != "" && txtFilmDetay.Text != "" && yonetmen != "" && oyuncu != "" && resimyolu != "" && vTarih != "" && secilenTur != "" && secilenOzellik != "" && secilenBicim != "")
            {
                try// Bağlantı açılır ve film verileri eklenir.hata yakalamak için try-catch bloğu kullanıyoruz.
                {
                    // Film bilgilerini veritabanına eklemek için sorgu hazırlıyoruz.
                    string sorgu = "INSERT INTO Tbl_Filmler (Film_Adi,Film_Türü,Film_Ozellikleri,Film_Bicimi,Film_Yonetmeni,Film_Oyuncuları,Film_VizyonTarihi,Film_IMDB_Puanı,Film_Detayi,Film_Afisi,Film_Durumu) VALUES (@adi,@turu,@ozellikleri,@bicimi,@yonetmen,@oyuncu,@vizyontarihi,@puan,@detay,@afis,@durum)";
                    if (baglanti.State == ConnectionState.Closed)// Bağlantı kapalıysa açıyoruz.
                    {
                        baglanti.Open();
                    }
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);// SqlCommand sınıfından bir komut nesnesi oluşturuyoruz.
                    komut.Parameters.AddWithValue("@adi", txtfilmAdi.Text.ToUpper());
                    if (secilenTur.Length > 2)
                    {
                        komut.Parameters.AddWithValue("@turu", secilenTur);
                    }
                    if (secilenOzellik.Length > 2)
                    {
                        komut.Parameters.AddWithValue("@ozellikleri", secilenOzellik);
                    }
                    if (secilenBicim.Length > 2)
                    {
                        komut.Parameters.AddWithValue("@bicimi", secilenBicim);
                    }
                    if (yonetmen.Length > 2)
                    {
                        komut.Parameters.AddWithValue("@yonetmen", yonetmen.Substring(2));
                    }
                    else
                    {
                        komut.Parameters.AddWithValue("@yonetmen", yonetmen);
                    }
                    if (oyuncu.Length > 2)
                    {
                        komut.Parameters.AddWithValue("@oyuncu", oyuncu.Substring(2));
                    }
                    else
                    {
                        komut.Parameters.AddWithValue("@oyuncu", oyuncu);
                    }
                    komut.Parameters.AddWithValue("@vizyontarihi", vTarih);
                    komut.Parameters.AddWithValue("@puan", lblReyting.Text);
                    komut.Parameters.AddWithValue("@detay", txtFilmDetay.Text.ToUpper());
                    komut.Parameters.AddWithValue("@afis", resimyolu);
                    komut.Parameters.AddWithValue("@durum", durum);
                    komut.ExecuteNonQuery();
                }
                catch (Exception ex)// Hata oluşursa kullanıcıya mesaj gösteriyoruz.
                {
                    MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)// Bağlantı açık ise kapatıyoruz.
                    {
                        baglanti.Close();
                    }
                    // Film kaydı başarılı ise kullanıcıya bilgi mesajı gösteriyoruz.
                    MessageBox.Show(txtfilmAdi.Text + ":Film kaydı başarılı bir şekilde gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else// Eğer gerekli alanlar doldurulmamışsa kullanıcıya uyarı mesajı gösteriyoruz.
            {
                MessageBox.Show("Lütfen ilgili Alanları doldurunuz!");
            }
        }
        // Seçilen tür, biçim ve özellikleri tutacak değişkenler
        public string secilenTur = "";
        public string secilenBicim = "";
        public string secilenOzellik = "";
        string EtiketleriAl(GroupBox grupKutusu)// Ortak işlemi yapan fonksiyon: GroupBox içindeki etiketleri (Label) kontrol eder
        {
            List<string> secilenEtiketler = new List<string>();
            foreach (Control kontrol in grupKutusu.Controls)// GroupBox içindeki tüm kontrolleri kontrol et
            {
                if (kontrol is Label etiket)// Sadece Label olanlara bak
                {
                    if (etiket.ForeColor != Color.FromArgb(16, 46, 80)) // Eğer rengi özel mavi değilse, seçilenler listesine ekle
                    {
                        secilenEtiketler.Add(etiket.Text);
                    }
                }
            }
            return string.Join(", ", secilenEtiketler);// Etiketleri virgül ile birleştirip döndür
        }
        // Her grup için ayrı ayrı çağırılan fonksiyonlar
        void TurleriAl()
        {
            secilenTur = EtiketleriAl(gBFilm_turleri);
        }
        void BicimleriAl()
        {
            secilenBicim = EtiketleriAl(gBFilm_bicimi);
        }
        void OzellikleriAl()
        {
            secilenOzellik = EtiketleriAl(gBFilm_ozellik);
        }
    }
}
