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
    public partial class FrmFilmListe : Form
    {
        public FrmFilmListe()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();// Kapatma butonuna tıklandığında çalışacak kod
        }
        // SqlConnection nesnesi oluşturuyoruz.
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
        private void FrmFilmListe_Load(object sender, EventArgs e)
        {
            try//hata yakalamak için kodlarımızı try-catch bloğu içine alıyoruz.
            {
                ListePaneli.Controls.Clear();// ListePaneli içeriğini temizliyoruz.
                string sorgu = "select * from Tbl_Filmler ORDER BY Film_Adi ASC";
                if (connection.State == ConnectionState.Closed)// Bağlantı kapalıysa açması için if bloğu içinde kontrol ediyoruz.
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(sorgu, connection);
                SqlDataReader oku = command.ExecuteReader();
                while (oku.Read())// DataReader ile verileri oku ve listeye ekle
                {
                    FilmListesi arac = new FilmListesi();
                    arac.lblFilmAdi.Text = oku["Film_Adi"].ToString();
                    arac.pBResim.ImageLocation = oku["Film_Afisi"].ToString();
                    arac.lblIdNo.Text = oku["ID"].ToString();
                    ListePaneli.Controls.Add(arac);
                }
                oku.Close(); // DataReader'ı kapatma işlemini yapıyoruz.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Film listesi yüklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally// Son olarak finally bloğu ile bağlantıyı kapatıyoruz.
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            // Arama metni değiştiğinde oyuncu listesini filtrele işlemi yapmaya yarayan kod bloğu
            try
            {
                ListePaneli.Controls.Clear();
                // Bağlantı kapalıysa aç
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                string sorgu = "SELECT * FROM Tbl_Filmler WHERE Film_Adi LIKE @arama COLLATE Turkish_CI_AS ORDER BY Film_Adi ASC";
                SqlCommand arama = new SqlCommand(sorgu, connection);
                arama.Parameters.AddWithValue("@arama", "%" + txtarama.Text + "%");
                SqlDataReader oku = arama.ExecuteReader();
                while (oku.Read())
                {
                    FilmListesi arac = new FilmListesi();
                    arac.lblIdNo.Text = oku["ID"].ToString();
                    arac.lblFilmAdi.Text = oku["Film_Adi"].ToString();
                    arac.pBResim.ImageLocation = oku["Film_Afisi"].ToString();
                    ListePaneli.Controls.Add(arac);
                }
                oku.Close(); // DataReader'ı mutlaka kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama yapılırken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantı hâlâ açıksa kapat
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
