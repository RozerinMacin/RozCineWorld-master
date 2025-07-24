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
    public partial class OListeAraci : UserControl
    {
        public OListeAraci()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
        private void lbladi_Click(object sender, EventArgs e)//adı label'ına tıklandığında çalışacak kod
        {
            if (lbladi.ForeColor == Color.FromArgb(16, 46, 80))
            {
                try
                {
                    // Labelin yazı rengini beyaza ayarla
                    lbladi.ForeColor = Color.White;
                    // Bağlantı kapalıysa aç
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open(); 
                    }
                    // SQL komutunu hazırla ve parametreleri ekle
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Secilenler (Kisi, tur) VALUES (@kisi, @tur)", connection);
                    komut.Parameters.AddWithValue("@kisi", lbladi.Text);
                    komut.Parameters.AddWithValue("@tur", "OYUNCU");
                    // Komutu çalıştır (veritabanına ekleme yap)
                    komut.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıya mesaj göster
                    MessageBox.Show("Kayıt eklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                try
                {
                    // Labelin yazı rengini ayarla
                    lbladi.ForeColor = Color.FromArgb(16, 46, 80);
                    // Bağlantı kapalıysa aç
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    // Silme komutunu hazırla ve parametreleri ekle
                    SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Secilenler WHERE Kisi = @kisi AND Tur = @tur", connection);
                    komut.Parameters.AddWithValue("@kisi", lbladi.Text);
                    komut.Parameters.AddWithValue("@tur", "OYUNCU");
                    // Komutu çalıştır (veritabanından kayıt sil)
                    komut.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıya mesaj göster
                    MessageBox.Show("Kayıt silinirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void lbladi_MouseMove(object sender, MouseEventArgs e)
        {
            lbladi.Font = new Font(lbladi.Font.Name, 10, FontStyle.Underline);
        }

        private void lbladi_MouseLeave(object sender, EventArgs e)
        {
            lbladi.Font = new Font(lbladi.Font.Name, 10, FontStyle.Regular);
        }

        private void OListeAraci_Load(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı kapalıysa aç
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                // Kayıt sorgusu hazırla ve parametreleri ekle
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Secilenler WHERE Kisi=@kisi AND Tur=@tur", connection);
                komut.Parameters.AddWithValue("@kisi", lbladi.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                // Sorguyu çalıştır ve oku
                SqlDataReader oku = komut.ExecuteReader();
                // Kayıt varsa label rengini beyaz yap, yoksa farklı renk yap
                if (oku.Read()) lbladi.ForeColor = Color.White; else lbladi.ForeColor = Color.FromArgb(16, 46, 80);
                oku.Close();// DataReader'ı kapat
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Kayıt kontrolü yapılırken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
