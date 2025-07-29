using Microsoft.Data.SqlClient;// SqlConnection sınıfını kullanmak için gerekli kütüphane
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        void BiletNoSorgula()
        {
            try
            {
                string sorgu = "SELECT * FROM Tbl_Biletler WHERE BKOD = @BiletNo";
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@BiletNo",txtBiletno.Text);
                SqlDataReader oku = command.ExecuteReader();
                if(!oku.Read())
                {
                    oku.Close();
                    KaydetMetodu();// Bilet numarası veritabanında yoksa KaydetMetodu metodunu çağırır
                }
                else
                {
                    BiletOlusturma();
                    connection.Close(); // Veritabanı bağlantısını kapatır
                    BiletNoSorgula();
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
        void KaydetMetodu()
        {
            try
            {
                string sorgu = "insert into Tbl_Biletler (BKOD, ADSOYAD, TELNO, KOLTUKNO, FİLMADI, TARİH, SEANS, SALON, TUR, İSLEMSAATİ) values (@bkod, @adsoyad, @telno, @koltuno, @filmadi, @tarih, @seans, @salon, @tur, @islemsaati)";
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@bkod", txtBiletno.Text);
                command.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                command.Parameters.AddWithValue("@telno", txtTelNo.Text);
                command.Parameters.AddWithValue("@koltuno", txtKoltuk.Text);
                command.Parameters.AddWithValue("@filmadi", cBFilmAdi.Text);
                command.Parameters.AddWithValue("@tarih", cBTarih.Text);
                command.Parameters.AddWithValue("@seans", lblseanssec.Text);
                command.Parameters.AddWithValue("@salon", cBSalonAdi.Text);
                command.Parameters.AddWithValue("@tur", cBBiletTuru.Text);
                command.Parameters.AddWithValue("@islemsaati", DateTime.Now.ToString()); // İşlem saatini alır
                command.ExecuteNonQuery(); // Sorguyu çalıştırır
                MessageBox.Show("BİLET BAŞARILI BİR ŞEKİLDE OLUŞTURULDU!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdSoyad.Text != "" && txtBiletno.Text != "" && txtKoltuk.Text != "" && txtTelNo.Text != "" && cBBiletTuru.Text != "" && cBFilmAdi.Text != "" && cBSalonAdi.Text != "" && cBTarih.Text !="")
                {
                    BiletNoSorgula();
                }
                else
                {
                    MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }   
        void SecilenKoltuklar()
        {
            txtKoltuk.Text = "";
            foreach (string item in lbBelirlenen.Items)
            {
                txtKoltuk.Text += " ," + item;
            }
            if (txtKoltuk.Text.Length > 2)
            {
                txtKoltuk.Text = txtKoltuk.Text.Substring(2); // İlk iki karakteri atar
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // Gönderilen nesneyi Button tipine dönüştürür
            if (btn.ForeColor == Color.Black)
            {
                MessageBox.Show("BU KOLTUK DAHA ÖNCE SATIN ALINMIŞTIR!");
            }
            else
            {
                if (btn.ForeColor == Color.White)
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.sari); // Butonun arka plan resmini kırmızı yapar
                    btn.ForeColor = Color.FromArgb(225, 68, 52); // Butonun metin rengini siyah yapar
                    lbBelirlenen.Items.Add(btn.Text); // Seçilen koltukları listeye ekler
                    SecilenKoltuklar(); // Seçilen koltukları günceller
                }
                else
    {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.Mavi); // Butonun arka plan resmini mavi yapar
                    btn.ForeColor = Color.White;
                    lbBelirlenen.Items.Remove(btn.Text); // Seçilen koltukları listeden kaldırır
                    SecilenKoltuklar();
                }
            }
        }
        private void cBTarih_SelectedIndexChanged(object sender, EventArgs e)
        {// Tarih combobox'ında seçim yapıldığında çalışır
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
                oku.Close(); // Okuyucu nesnesini kapatır
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
        {// Seans saatleri radio butonunun CheckedChanged olayında çalışır
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
                        oku.Close(); // Okuyucu nesnesini kapatır
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
        {// Salon adları combobox'ında seçim yapıldığında çalışır
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
                    label2.Text = oku["SalonAdı"]?.ToString() ?? "HATALI";
                }
                oku.Close(); // Okuyucu nesnesini kapatır
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
            KoltukGetir(); // Koltukları getirir
            koltukislemleri();
        }
        void koltukislemleri()
        {
            KoltukPaneli.Controls.Clear();
            int sayi = Convert.ToInt32(lblkoltuksayisi.Text);
            for (int i = 1; i <= sayi; i++)// Koltuk sayısı kadar döngü oluşturur
            {
                Button btn = new Button();// Yeni bir Button nesnesi oluşturur
                if (i <= 8)// Koltuk numaralarını A1, A2, ..., H8 şeklinde ayarlar
                {
                    btn.Text = "A" + i.ToString();
                    btn.Name = "A" + i.ToString();
                }
                else if (i <= 16)
                {
                    btn.Text = "B" + i.ToString();
                    btn.Name = "B" + i.ToString();
                }
                else if (i <= 24)
                {
                    btn.Text = "C" + i.ToString();
                    btn.Name = "C" + i.ToString();
                }
                else if (i <= 32)
                {
                    btn.Text = "D" + i.ToString();
                    btn.Name = "D" + i.ToString();
                }
                else if (i <= 40)
                {
                    btn.Text = "E" + i.ToString();
                    btn.Name = "E" + i.ToString();
                }
                else if (i <= 48)
                {
                    btn.Text = "F" + i.ToString();
                    btn.Name = "F " + i.ToString();
                }
                else if (i <= 56)
                {
                    btn.Text = "G" + i.ToString();
                    btn.Name = "G" + i.ToString();
                }
                else if (i <= 64)
                {
                    btn.Text = "H" + i.ToString();
                    btn.Name = "H" + i.ToString();
                }
                btn.Width = 50;// Butonun genişliğini ayarlar
                btn.Height = 50;// Butonun yüksekliğini ayarlar
                btn.FlatStyle = FlatStyle.Flat; // Düğmenin stilini düz yapar
                btn.FlatAppearance.BorderSize = 0;// Düğmenin kenarlık boyutunu sıfırlar
                btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10); // butonun fontunu ayarlar
                btn.ForeColor = Color.White; // butonun metin rengini beyaz yapar
                btn.Cursor = Cursors.Hand; // butonun imlecini el yapar
                btn.Click += btn_Click; // Butonun Click olayına btn_Click metodunu bağlar

                if (Koltuklistesi.Items.Contains(btn.Text))
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.kirmizi);
                    btn.ForeColor = Color.Black; // Düğmenin metin rengini siyah yapar
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.Mavi);
                }
                KoltukPaneli.Controls.Add(btn);
            }
        }
        void KoltukGetir()
        {
            try
            {
                lblgelenkoltuk.Text = ""; // Gelen koltukları temizler
                string sorgu = "SELECT * FROM Tbl_Kontrol WHERE FILMADI = @filmadi AND TARIH = @tarih AND SEANS = @seans AND SALONADI = @salonadi";
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); // Veritabanı bağlantısını açar
                }
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@filmadi", cBFilmAdi.Text);// Seçilen film adını parametre olarak ekler
                command.Parameters.AddWithValue("@tarih", cBTarih.Text);// Seçilen tarihi parametre olarak ekler
                command.Parameters.AddWithValue("@seans", lblseanssec.Text);// Seçilen seansı parametre olarak ekler
                command.Parameters.AddWithValue("@salonadi", cBSalonAdi.Text);// Seçilen salon adını parametre olarak ekler
                SqlDataReader oku = command.ExecuteReader();
                while (oku.Read())
                {
                    lblgelenkoltuk.Text += " \n" + oku["KOLTUKLAR"]?.ToString() ?? "HATALI";
                    if(lblgelenkoltuk.Text.Length > 2)
                    {
                        lblgelenkoltuk.Text = lblgelenkoltuk.Text.Substring(2); // İlk iki karakteri atar
                    }
                }
                oku.Close(); // Okuyucu nesnesini kapatır
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
            Koltukayirma();
        }
        void Koltukayirma()
        {
            Koltuklistesi.Items.Clear();
            string no = "";
            string[] secilen;
            no = lblgelenkoltuk.Text.ToString();
            secilen  = no.Split(',');// Seçilen koltukları virgülle ayırır
            foreach (string bulunan in secilen)
            {
                Koltuklistesi.Items.Add(bulunan); // Seçilen koltukları listeye ekler
            }
        }
    }
}
