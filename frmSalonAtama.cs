using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Microsoft.Data.SqlClient kütüphanesini kullanarak SQL Server veritabanı ile etkileşimde bulunur.

namespace RozCineWorld
{
    public partial class frmSalonAtama : Form
    {
        public frmSalonAtama()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close(); // Bu butona tıklandığında formu kapatır.
        }

        private void frmSalonAtama_Load(object sender, EventArgs e)
        {
            bugununtarihi();
            FilmAdiGetir();
            SalonAdiGetir();
        }
        void bugununtarihi()// Bugünün tarihini alır ve ilgili numeric up down kontrollerine atar.
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;
        }
        void FilmAdiGetir()// Film adlarını veritabanından alır ve combobox'a eklemek için kullanılan metot
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); // Veritabanı bağlantısını açar
                }
                string sorgu = "select * from Tbl_Filmler ORDER BY Film_Adi ASC";// Film adlarını alfabetik sıraya göre sıralar
                SqlCommand command = new SqlCommand(sorgu, connection);// Sorgu komutunu oluşturur
                SqlDataReader oku = command.ExecuteReader(); // Sorguyu çalıştırır ve verileri okur
                while (oku.Read())
                {
                    // Film vizyon tarihini kontrol eder ve bugünden önceki filmleri combobox'a ekler
                    string Gelentarih = oku["Film_VizyonTarihi"]?.ToString() ?? "eksik";
                    DateTime fTarih = Convert.ToDateTime(Gelentarih);
                    DateTime bugun = DateTime.Today;
                    TimeSpan timeSpan = fTarih - bugun; // Film vizyon tarihini bugünün tarihi ile karşılaştırır
                    if (timeSpan.TotalDays <= 0)
                    {
                        cBFilmAdi.Items.Add(oku["Film_Adi"]?.ToString() ?? "Film Adı hatalı."); // Film adlarını combobox'a ekler
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Veritabanı bağlantısını kapatır
                }
            }
        }
        void SalonAdiGetir()// Film adlarını veritabanından alır ve combobox'a eklemek için kullanılan metot
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); // Veritabanı bağlantısını açar
                }
                string sorgu = "select * from Tbl_Salonlar ORDER BY SalonAdı ASC";// Film adlarını alfabetik sıraya göre sıralar
                SqlCommand command = new SqlCommand(sorgu, connection);// Sorgu komutunu oluşturur
                SqlDataReader oku = command.ExecuteReader(); // Sorguyu çalıştırır ve verileri okur
                while (oku.Read())
                {
                    cBSalonAdi.Items.Add(oku["SalonAdı"]?.ToString() ?? "Film Adı hatalı."); // Film adlarını combobox'a ekler
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Veritabanı bağlantısını kapatır
                }
            }
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            if (BtnOlustur.Text == "TAMAMLA")
            {
                string tarih = nGun.Value.ToString("00") + "." + nAy.Value.ToString("00") + "." + nYil.Value; // Tarih bilgisini alır
                string sorgu = "select DISTINCT SEANS from Tbl_Kontrol where TARIH = @tarih AND SALONADI = @salonadi ";
                connection.Open(); // Veritabanı bağlantısını açar
                SqlCommand command = new SqlCommand(sorgu, connection); // Sorgu komutunu oluşturur
                command.Parameters.AddWithValue("@tarih", tarih); // Tarih parametresini ekler
                command.Parameters.AddWithValue("@salonadi", cBSalonAdi.Text); // Salon adı parametresini ekler
                SqlDataReader oku = command.ExecuteReader(); // Sorguyu çalıştırır ve verileri okur
                while (oku.Read())
                {
                    cBDoluSaatler.Items.Add(oku["SEANS"]?.ToString() ?? ""); // Dolu saatleri combobox'a ekler

                }
                BtnOlustur.Text = "OLUŞTUR";
                BtnOlustur.BackColor = Color.FromArgb(16, 46, 80); // Butonun arka plan rengini yeşil yapar
                connection.Close(); // Veritabanı bağlantısını kapatır
                SeansKontrol();
            }
            else
            {
                BtnOlustur.Text = "TAMAMLA";
                BtnOlustur.BackColor = Color.FromArgb(190, 61, 42); // Butonun arka plan rengini yeşil yapar
                Kaydet(); // Salon atama işlemini kaydeder
                temizle(); // Temizleme işlemini yapar
            }

        }
        void Kaydet()
        {
            try
            {
                string tarih = nGun.Value.ToString("00") + "." + nAy.Value.ToString("00") + "." + nYil.Value; // Tarih bilgisini alır
                string sorgu = "insert into Tbl_Kontrol(FILMADI,TARIH,SEANS,SALONADI) VALUES(@filmadi, @tarih, @seans, @salonadi)";
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand ekle = new SqlCommand(sorgu, connection);
                ekle.Parameters.AddWithValue("@filmadi", cBFilmAdi.Text);
                ekle.Parameters.AddWithValue("@tarih",tarih);
                ekle.Parameters.AddWithValue("@seans", lblsecilen.Text);
                ekle.Parameters.AddWithValue("@salonadi", cBSalonAdi.Text);
                ekle.ExecuteNonQuery(); // Sorguyu çalıştırır
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            MessageBox.Show("SALON ATAMA İŞLEMİMİZ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİ.");
        }
        void SeansSaatleri(object sender , EventArgs e)
        {
            foreach (RadioButton item in PanelSEANS.Controls)
            {
                if (item.Checked)
                {
                    lblsecilen.Text = item.Text.ToString();
                }
            }
        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void temizle()
        {
            cBFilmAdi.Items.Clear(); // Film adları combobox'ını temizler
            cBSalonAdi.Items.Clear(); // Salon adları combobox'ını temizler
            cBDoluSaatler.Items.Clear(); // Dolu saatler combobox'ını temizler
            lblsecilen.Text = "";
            bugununtarihi(); // Bugünün tarihini günceller
            FilmAdiGetir(); // Film adlarını tekrar getirir
            SalonAdiGetir(); // Salon adlarını tekrar getirir
            PanelSEANS.Controls.Clear(); // Seans panelini temizler
            BtnOlustur.Text = "TAMAMLA"; // Butonun metnini "TAMAMLA" olarak ayarlar
        }
        void SeansKontrol()
        {
            PanelSEANS.Controls.Clear();
            for (int i = 10; i <= 22; i++)
            {
                for (int j = 0; j <= 30; j += 30)
                {
                    string saat = i.ToString("00") + "." + j.ToString("00");
                    RadioButton radio = new RadioButton
                    {
                        Text = saat,
                        FlatStyle = FlatStyle.Flat,
                        Cursor = Cursors.Hand,
                        Font = new Font("Segoe UI Semibold", 10)
                    };
                    // Dolu saatleri kontrol et
                    bool saatDoluMu = false;
                    foreach (var item in cBDoluSaatler.Items)
                    {
                        if (item.ToString().Trim() == saat)
                        {
                            saatDoluMu = true;
                            break;
                        }
                    }
                    if (saatDoluMu)
                    {
                        radio.Enabled = false;
                    }
                    radio.CheckedChanged += new EventHandler(SeansSaatleri);
                    PanelSEANS.Controls.Add(radio);
                }
            }
        }
    }
}
