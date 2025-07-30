using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // SQL Server veritabanı işlemleri için gerekli kütüphane

namespace RozCineWorld
{
    public partial class FrmBiletDetay : Form
    {
        public FrmBiletDetay()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close(); // Kapatma butonuna tıklandığında formu kapatır.
        }
        public string biletNo = "";
        private void FrmBiletDetay_Load(object sender, EventArgs e)
        {
            lblBiletNo.Text = biletNo; // Bilet numarasını label kontrolüne atar.
            lblBiletNo2.Text = biletNo; // Bilet numarasını label kontrolüne atar.
            BarKodOlusturma();
            BilgiGetir(); // Bilet bilgilerini getirir.
        }
        void BilgiGetir()
        {
            try
            {
                string sorgu = "select * from Tbl_Biletler where BKOD = @Kod"; // Bilet numarasına göre bilet bilgilerini getirir.
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(sorgu,connection);
                command.Parameters.AddWithValue("@Kod", biletNo); // Parametre olarak bilet numarasını ekler.
                SqlDataReader oku = command.ExecuteReader(); // Sorguyu çalıştırır ve verileri okur.
                if (oku.Read())
                {
                    lblFilmADI1.Text = oku["FİLMADI"].ToString(); // Film adını label kontrolüne atar.
                    lblFilmADI2.Text = oku["FİLMADI"].ToString(); 
                    lblTelNo.Text = oku["TELNO"].ToString(); // Telefon numarasını label kontrolüne atar.
                    lblAdSoyad.Text = oku["ADSOYAD"].ToString(); // Ad ve soyad bilgisini label kontrolüne atar.
                    lblBiletturu.Text = oku["TUR"].ToString(); // Bilet türünü label kontrolüne atar.
                    lblSalonADI1.Text = oku["SALON"].ToString() + "/" + oku["SEANS"].ToString(); // Salon adını label kontrolüne atar.
                    lblSalonADI2.Text = oku["SALON"].ToString() + "/" + oku["SEANS"].ToString();
                    lblTarihSaat1.Text = oku["TARİH"].ToString(); // Tarih ve saat bilgisini label kontrolüne atar.
                    lblTarihSaat2.Text = oku["TARİH"].ToString();
                    lblislemTarih.Text = oku["İSLEMSAATİ"].ToString(); // İşlem tarihini label kontrolüne atar.
                    lblKoltuklar1.Text = oku["KOLTUKNO"].ToString(); // Koltuk numarasını label kontrolüne atar.
                    lblKoltuklar2.Text = oku["KOLTUKNO"].ToString();
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
        void BarKodOlusturma()
        {
            Random rastgele = new Random(); 
            string karakterler = "1234567899876543210ABCDEFGHIJKLMNOPRSTUVYZZYVUTSRPONMLKJIHGFEDCBA98765432100123456789";
            string biletNo = "";

            for (int i = 1; i < 11; i++) 
            {
                biletNo += karakterler[rastgele.Next(karakterler.Length)]; // Rastgele karakter seçer
            }
            lblBarKod1.Text = biletNo.ToString(); 
            lblBarKod2.Text = biletNo.ToString();
        }
    }
}
