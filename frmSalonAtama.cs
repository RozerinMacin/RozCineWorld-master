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
                string tarih = nGun.Value + "." + nAy.Value + "." + nYil.Value; // Tarih bilgisini alır
                string sorgu = "select DISTINCT SEANS from Tbl_Kontrol where TARIH = @tarih AND SALONADI = @salonadi ";
                connection.Open(); // Veritabanı bağlantısını açar
                SqlCommand command = new SqlCommand(sorgu, connection); // Sorgu komutunu oluşturur
                command.Parameters.AddWithValue("@tarih",tarih); // Tarih parametresini ekler
                command.Parameters.AddWithValue("@salonadi", cBSalonAdi.Text); // Salon adı parametresini ekler
                SqlDataReader oku = command.ExecuteReader(); // Sorguyu çalıştırır ve verileri okur
                while(oku.Read())
                {
                    cBDoluSaatler.Items.Add(oku["SEANS"]?.ToString() ?? "Seans bilgisi hatalı."); // Dolu saatleri combobox'a ekler

                }
                connection.Close(); // Veritabanı bağlantısını kapatır
                BtnOlustur.Text = "OLUŞTUR";
                BtnOlustur.BackColor = Color.FromArgb(16, 46, 80); // Butonun arka plan rengini yeşil yapar
            }
            else
            {
                cBDoluSaatler.Items.Clear(); // Dolu saatler combobox'ını temizler
                BtnOlustur.Text = "TAMAMLA";
                BtnOlustur.BackColor = Color.FromArgb(190, 61, 42); // Butonun arka plan rengini yeşil yapar
            }
        }
    }
}
