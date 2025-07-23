using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//sql bağlantısı için gerekli kütüphane

namespace RozCineWorld
{
    public partial class FrmSalonKayit : Form
    {
        public FrmSalonKayit()
        {
            InitializeComponent();
        }
        // SqlConnection sınıfından bir bağlantı nesnesi oluşturuyoruz.
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void btnkapat_Click(object sender, EventArgs e)// Kapatma butonuna tıklandığında formu kapatır.
        {
            this.Close();
        }
        private void BtnSalonKaydet_Click(object sender, EventArgs e)// Salon kaydetme butonuna tıklandığında çalışır.
        {
            if (txtSalonAdi.Text != "" && cBkoltukSayisi.Text != "")// Eğer salon adı ve koltuk sayısı boş değilse
            {
                try
                {
                    // Bağlantı kapalı ise açar ve salon adı ve koltuk sayısını veritabanına kaydeder.
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand kaydet = new SqlCommand("INSERT INTO Tbl_Salonlar(SalonAdı,KoltukSayısı) VALUES(@salonadi,@koltuksayisi)", connection);
                    kaydet.Parameters.AddWithValue("@salonadi", txtSalonAdi.Text.ToUpper());
                    kaydet.Parameters.AddWithValue("@koltuksayisi", cBkoltukSayisi.Text);
                    kaydet.ExecuteNonQuery();
                    ListeGetir();
                    MessageBox.Show("SALON KAYDETME İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                finally
                {
                    // Bağlantı açık ise kapatır.kullanıcıya başarılı bir şekilde kaydedildiğini bildirir ve formu temizler.
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    txtSalonAdi.Text = "";
                    cBkoltukSayisi.Text = "";
                    txtSalonAdi.Focus();
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ!");
            }
        }
        void koltukolustur()// Koltuk sayısı combobox'ını doldurur.
        {
            for (int i = 1; i < 100; i++)// 1 ile 100 arasında koltuk sayısı oluşturur.
            {
                cBkoltukSayisi.Items.Add(i);// Combobox'a koltuk sayısını ekler.
            }
        }

        private void FrmSalonKayit_Load(object sender, EventArgs e)// Form yüklendiğinde çalışır.
        {
            // Form yüklendiğinde koltuk sayısı combobox'ını doldurur ve salon listesini getirir.
            koltukolustur();
            ListeGetir();
        }
        void ListeGetir()// Salon listesini getirir.paneli temizler ve veritabanından salon bilgilerini alarak her bir salon için SalonListesi kontrolünü oluşturur ve panelin içine ekler.
        {
            try
            {
                Panelsalon.Controls.Clear();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand komut = new SqlCommand("select * from Tbl_Salonlar ORDER BY SalonAdı ASC", connection);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    SalonListesi arac = new SalonListesi();
                    arac.lblsalonadi.Text = oku["SalonAdı"].ToString();
                    arac.lblkoltuksayisi.Text = oku["KoltukSayısı"].ToString();
                    Panelsalon.Controls.Add(arac);
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
                    connection.Close();
                }
            }
        }
        // Koltuk sayısı combobox'ındaki metin değiştiğinde çalışır.
        private void cBkoltukSayisi_TextChanged(object sender, EventArgs e)
        {
            try
            {

                int sayi = Convert.ToInt32(cBkoltukSayisi.Text);

                if (sayi < 1 || sayi > 100)// Eğer sayı 1 ile 100 arasında değilse
                {
                    MessageBox.Show("Lütfen 1 ile 100 arasında bir sayı girin!");// Kullanıcıya uyarı mesajı gösterir.
                    cBkoltukSayisi.Text = "";// Combobox'ı temizler.
                }
            }
            catch
            {
                // Sayı değilse kutuyu temizle (opsiyonel)
                cBkoltukSayisi.Text = "";
            }
        }
    }
}
