using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;// SqlConnection sınıfını kullanmak için gerekli kütüphane

namespace RozCineWorld
{
    public partial class FrmBiletOlusturma : Form
    {
        public FrmBiletOlusturma()
        {
            InitializeComponent();
        }
        // SqlConnection sınıfından bir bağlantı nesnesi oluşturuyoruz.
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close(); // Bilet oluşturma formunu kapatır
        }

        private void FrmBiletOlusturma_Load(object sender, EventArgs e)
        {
            FilmAdiGetir();
            BiletOlusturma();
        }
        void BiletOlusturma()
        {
            Random rastgele = new Random(); // Rastgele sayı üretmek için Random sınıfından bir nesne oluşturur
            string karakterler = "1234567899876543210ABCDEFGHIJKLMNOPRSTUVYZZYVUTSRPONMLKJIHGFEDCBA98765432100123456789";
            string biletNo = "";

            for (int i = 1; i < 11; i++) // 5 karakterli rastgele bilet numarası oluşturur
            {
                biletNo += karakterler[rastgele.Next(karakterler.Length)]; // Rastgele karakter seçer
            }
            txtBiletno.Text = biletNo.ToString(); // Oluşturulan bilet numarasını textbox'a atar
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

        private void cBFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {// Film adları combobox'ında seçim yapıldığında çalışır
            try
            {
                cBTarih.Items.Clear(); // Tarih combobox'ını temizler
                string sorgu = "SELECT DISTINCT TARIH FROM Tbl_Kontrol WHERE FILMADI = @filmadi";// Seçilen film adının tarihlerini almak için sorgu ve aynı zamanda tarihleri tekrarsız olarak getirir
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); // Veritabanı bağlantısını açar
                }
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@filmadi", cBFilmAdi.Text);// Seçilen film adını parametre olarak ekler
                SqlDataReader oku = command.ExecuteReader();
                while (oku.Read())
                {// Okunan tarihleri combobox'a ekler
                    cBTarih.Items.Add(oku["TARIH"]?.ToString() ?? " ");
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

        }

        private void cBTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PanelSEANS.Controls.Clear(); // Seans panelini temizler
                string seans = "";
                string sorgu = "SELECT DISTINCT SEANS FROM Tbl_Kontrol WHERE FILMADI = @filmadi AND TARIH = @tarih";// Seçilen film adının tarihlerini almak için sorgu ve aynı zamanda tarihleri tekrarsız olarak getirir
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); // Veritabanı bağlantısını açar
                }
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@filmadi", cBFilmAdi.Text);// Seçilen film adını parametre olarak ekler
                command.Parameters.AddWithValue("@tarih", cBTarih.Text);// Seçilen tarihi parametre olarak ekler
                SqlDataReader oku = command.ExecuteReader();
                while (oku.Read())
                {
                    seans = oku["SEANS"]?.ToString() ?? "HATALI";
                    RadioButton radio = new RadioButton();
                    radio.Text = seans; // Okunan seansı radio butonun metni olarak ayarlar
                    radio.FlatStyle = FlatStyle.Flat; // Radio butonun stilini düz yapar
                    radio.Cursor = Cursors.Hand; // Radio butonun imlecini el yapar
                    radio.Width = 90; // Radio butonun genişliğini ayarlar
                    radio.Font = new System.Drawing.Font("Segoe UI Semibold", 10); // Radio butonun fontunu ayarlar
                    radio.CheckedChanged += new EventHandler(SeansSaatleri); // Radio butonun CheckedChanged olayına SeansSaatleri metodunu bağlar
                    PanelSEANS.Controls.Add(radio); // Radio butonu panelin içine ekler
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
        private void SeansSaatleri(object sender, EventArgs e)
        {
            foreach (RadioButton item in PanelSEANS.Controls)
            {
                if (item.Checked == true)
                {
                    lblseanssec.Text = item.Text;
                    cBSalonAdi.Items.Clear(); // Salon adlarını temizler

                    try
                    {
                        string sorgu = "SELECT DISTINCT SALONADI FROM Tbl_Kontrol WHERE FILMADI = @filmadi AND TARIH = @tarih AND SEANS = @seans";
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open(); // Veritabanı bağlantısını açar
                        }
                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@filmadi", cBFilmAdi.Text);// Seçilen film adını parametre olarak ekler
                        command.Parameters.AddWithValue("@tarih", cBTarih.Text);// Seçilen tarihi parametre olarak ekler
                        command.Parameters.AddWithValue("@seans", lblseanssec.Text);// Seçilen seansı parametre olarak ekler
                        SqlDataReader oku = command.ExecuteReader();
                        while (oku.Read())
                        {
                            cBSalonAdi.Items.Add(oku["SALONADI"]?.ToString() ?? "HATALI");
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
            }
        }

        private void cBSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT *  FROM Tbl_Salonlar WHERE SalonAdı = @salonadi";
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); // Veritabanı bağlantısını açar
                }
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@salonadi", cBSalonAdi.Text);// Seçilen salon adını parametre olarak ekler
                SqlDataReader oku = command.ExecuteReader();
                while (oku.Read())
                {
                    lblkoltuksayisi.Text = oku["KoltukSayısı"]?.ToString() ?? "HATALI";
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
    }
}
