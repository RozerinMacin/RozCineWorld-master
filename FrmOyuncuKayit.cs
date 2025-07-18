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
    public partial class FrmOyuncuKayit : Form
    {
        public FrmOyuncuKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            string Dogum = nGun.Value.ToString() + "-" + nAy.Value.ToString() + "-" + nYil.Value.ToString();
            DateTime DogumTarihi = Convert.ToDateTime(Dogum);
            DateTime Bugun = DateTime.Today;
            int yas = Bugun.Year - DogumTarihi.Year;
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
        void AracTemizleme()
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
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtBiyografi.Text != "" && resimyolu != "")
            {
                if (YasHesaplama())
                {
                    String AdSoyad = txtAd.Text.ToString().ToUpper() + " " + txtSoyad.Text.ToString().ToUpper();

                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into Tbl_Oyuncular(AdSoyad,Yas,Cinsiyet,Biyografi,Resim) VALUES(@adsoyad, @yas, @cinsiyet, @biyografi, @resim)", connection);
                    command.Parameters.AddWithValue("@adsoyad", AdSoyad);
                    command.Parameters.AddWithValue("@yas", byas);
                    command.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                    command.Parameters.AddWithValue("@biyografi", txtBiyografi.Text.ToString());
                    command.Parameters.AddWithValue("@resim", resimyolu);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("OYUNCU KAYIT İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ.");
                    AracTemizleme();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz bir şekilde doldurunuz.");
            }
        }
    }
}
