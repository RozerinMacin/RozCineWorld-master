using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Microsoft.Data.SqlClient kütüphanesini kullanıyoruz.

namespace RozCineWorld
{
    public partial class FrmOyuncuKayit : Form
    {
        public FrmOyuncuKayit()
        {
            InitializeComponent();
        }
        //sqlconnection nesnesi oluşturuz.
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void btnkapat_Click(object sender, EventArgs e)// Kapatma butonuna tıklandığında çalışacak kod
        {
            this.Close();
        }
        public string resimyolu = "";
        private void BtnResimYukle_Click(object sender, EventArgs e)
        {
            // Resim yükleme işlemi için OpenFileDialog kullanıyoruz.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG | *.jpg | JPEG | *.jpeg | ALL Files | *.*";
            ofd.FilterIndex = 4;

            if (ofd.ShowDialog() == DialogResult.OK)// Eğer kullanıcı bir dosya seçerse
            {
                pBResim.Image = new Bitmap(ofd.FileName);
                resimyolu = ofd.FileName.ToString();
            }
        }
        // Cinsiyet değişkeni ve radyo butonları için olaylar
        public string cinsiyet = "E";
        private void rBErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "E";
        }
        private void rBKadin_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "K";
        }

        private void txtBiyografi_TextChanged(object sender, EventArgs e)
        {
            // Biyografi metni değiştiğinde karakter sayısını kontrol eder ve etiketin rengini ayarlar.
            int karaktersayisi = txtBiyografi.Text.Length;
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
        public string byas = "0";
        public bool YasHesaplama()
        {
            // Doğum tarihi bilgilerini alır ve yaş hesaplar.
            string Dogum = nGun.Value.ToString() + "-" + nAy.Value.ToString() + "-" + nYil.Value.ToString();
            DateTime DogumTarihi = Convert.ToDateTime(Dogum);// Doğum tarihini DateTime tipine çevirir.
            DateTime Bugun = DateTime.Today;// Bugünün tarihini alır.
            int yas = Bugun.Year - DogumTarihi.Year;// Yaşı hesaplar.
            if (DogumTarihi > Bugun)
            {
                MessageBox.Show("KAYIT YAPILAMADI! Lütfen geçerli bir tarih giriniz!");
                return false;
            }
            else if (yas < 5)
            {
                MessageBox.Show("Yaşınız 5'ten büyük olmalıdır!");
                return false;
            }
            else
            {

                byas = yas.ToString();
                return true;
            }
        }
        void AracTemizleme()// Formdaki tüm alanları temizler.
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtBiyografi.Text = "";
            nGun.Value = 1;
            nAy.Value = 1;
            nYil.Value = 2025;
            rBErkek.Checked = true;
            rBKadin.Checked = false;
            lblKarakter.Text = "300";
            cinsiyet = "E";
            byas = "0";
            txtAd.Focus();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // Oyuncu kaydı için gerekli bilgileri alır ve veritabanına kaydeder.
            try
            {
                if (txtAd.Text != "" && txtSoyad.Text != "" && txtBiyografi.Text != "" && resimyolu != "")
                {
                    if (YasHesaplama())
                    {
                        string AdSoyad = txtAd.Text.ToUpper() + " " + txtSoyad.Text.ToUpper();
                        // Bağlantı kapalıysa aç
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        SqlCommand command = new SqlCommand("INSERT INTO Tbl_Oyuncular (AdSoyad, Yas, Cinsiyet, Biyografi, Resim) VALUES (@adsoyad, @yas, @cinsiyet, @biyografi, @resim)", connection);
                        command.Parameters.AddWithValue("@adsoyad", AdSoyad);
                        command.Parameters.AddWithValue("@yas", byas);
                        command.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        command.Parameters.AddWithValue("@biyografi", txtBiyografi.Text);
                        command.Parameters.AddWithValue("@resim", resimyolu);
                        command.ExecuteNonQuery();
                        MessageBox.Show("OYUNCU KAYIT İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ.");
                        AracTemizleme();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz bir şekilde doldurunuz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantı açıksa kapat
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
