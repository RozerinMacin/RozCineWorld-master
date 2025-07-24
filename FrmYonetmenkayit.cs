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
    public partial class FrmYonetmenkayit : Form
    {
        public FrmYonetmenkayit()
        {
            InitializeComponent();
        }
        // Sql bağlantısı için gerekli olan bağlantı dizesi.
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void btnkapat_Click(object sender, EventArgs e)// Kapatma butonuna tıklandığında formu kapatma işlemi için yazılan kod bloğu.
        {
            this.Close();
        }
        // Resim yükleme işlemi için gerekli olan kod bloğu.
        public string resimyolu = "";
        private void BtnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();// OpenFileDialog sınıfı, dosya seçme penceresi açmak için kullanılır.
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG | *.jpg | JPEG | *.jpeg | ALL Files | *.*";
            ofd.FilterIndex = 4;
            if (ofd.ShowDialog() == DialogResult.OK)// Eğer kullanıcı bir dosya seçerse, aşağıdaki işlemler yapılır.
            {
                pBResim.Image = new Bitmap(ofd.FileName);
                resimyolu = ofd.FileName.ToString();
            }
        }
        // Cinsiyet seçim işlemi için yazılan kod bloğu.
        private void rBErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "E";
        }
        private void rBKadin_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "K";
        }
        public string cinsiyet = "E";
        private void BtnKaydet_Click(object sender, EventArgs e)// Kaydet butonuna tıklandığında yönetmen kayıdını veritbanına ekleme işlemi için yazılan kod bloğu.
        {
            // Yönetmen kaydı için gerekli olan alanların doldurulup doldurulmadığını kontrol etme işlemi.
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtBiyografi.Text != "" && resimyolu != "")
            {
                if (YasHesaplama())// Yaş hesaplama işlemi başarılı ise, kayıt işlemi devam eder.
                {
                    try
                    {
                        // Yönetmen bilgilerini veritabanına ekleme işlemi için gerekli olan SQL komutları.
                        String AdSoyad = txtAd.Text.ToString().ToUpper() + " " + txtSoyad.Text.ToString().ToUpper();
                        if(connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        SqlCommand command = new SqlCommand("insert into Tbl_Yonetmenler(AdSoyad,Yas,Cinsiyet,Biyografi,Resim) VALUES(@adsoyad, @yas, @cinsiyet, @biyografi, @resim)", connection);
                        command.Parameters.AddWithValue("@adsoyad", AdSoyad);
                        command.Parameters.AddWithValue("@yas", byas);
                        command.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        command.Parameters.AddWithValue("@biyografi", txtBiyografi.Text.ToString());
                        command.Parameters.AddWithValue("@resim", resimyolu);
                        command.ExecuteNonQuery();
                        MessageBox.Show("YÖNETMEN KAYIT İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        // Bağlantı kapatılır ve kullanıcıya başarılı bir kayıt mesajı gösterilir.
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                        AracTemizleme();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz bir şekilde doldurunuz.");
            }
        }
        void AracTemizleme()// Form üzerindeki araçları temizleme işlemi için yazılan kod bloğu.
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
        // Yaş hesaplama işlemi için yazılan kod bloğu.
        public string byas = "0";
        public bool YasHesaplama()
        {
            // Doğum tarihi alanından alınan değerleri kullanarak yaş hesaplama işlemi.
            string Dogum = nGun.Value.ToString() + "-" + nAy.Value.ToString() + "-" + nYil.Value.ToString();
            DateTime DogumTarihi = Convert.ToDateTime(Dogum);// Doğum tarihini DateTime tipine çevirme işlemi.
            DateTime Bugun = DateTime.Today;// Bugünün tarihini alır.
            int yas = Bugun.Year - DogumTarihi.Year;// Yıl farkını hesaplar.
            if (DogumTarihi > Bugun)// Eğer doğum tarihi bugünden büyükse, yani gelecekteyse yaş hesaplaması geçersiz olur.
            {
                MessageBox.Show("KAYIT YAPILAMADI! Lütfen geçerli bir tarih giriniz!");
                return false;// Geçerli bir tarih girilmediğinde false döndürür.
            }
            else if (yas < 18)// Eğer hesaplanan yaş 18'den küçükse, kayıt işlemi yapılamaz.
            {
                MessageBox.Show("Yaşınız 18'den büyük olmalıdır!");
                return false;
            }
            else// Eğer yaş 18 veya daha büyükse, kayıt işlemi başarılı olur.
            {
                byas = yas.ToString();
                return true;
            }
        }
        private void txtBiyografi_TextChanged(object sender, EventArgs e)
        {
            //biyografi alanındaki karakter sayısını kontrol etme ve geri kalan karakter sayısını göstermek için yazılan kod bloğu.
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
    }
}
