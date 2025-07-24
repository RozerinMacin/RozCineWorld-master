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
    public partial class YListeAraci : UserControl
    {
        public YListeAraci()
        {
            InitializeComponent();
        }
        // Sql bağlantısı için gerekli olan bağlantı dizesi.
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
        private void lbladi_MouseMove(object sender, MouseEventArgs e)// Fare imleci label üzerinde hareket ettiğinde yazı tipini altı çizili yapma işlemi için yazılan kod bloğu.
        {
            lbladi.Font = new Font(lbladi.Font.Name, 10, FontStyle.Underline);
        }
        private void lbladi_MouseLeave(object sender, EventArgs e)// Fare imleci label üzerinden ayrıldığında yazı tipini normal hale getirme işlemi için yazılan kod bloğu.
        {
            lbladi.Font = new Font(lbladi.Font.Name, 10, FontStyle.Regular);
        }
        // Label üzerine tıklandığında seçilen yönetmeni veritabanına ekleme veya kaldırma işlemi için yazılan kod bloğu.
        private void lbladi_Click(object sender, EventArgs e)
        {
            if (lbladi.ForeColor == Color.FromArgb(16, 46, 80))// Eğer label'ın rengi mavi ise, yani yönetmen henüz seçilmemişse, aşağıdaki işlemler yapılır.
            {
                lbladi.ForeColor = Color.White;
                connection.Open();
                // Seçilen yönetmeni veritabanına ekleme işlemi için gerekli olan SQL komutları.
                SqlCommand komut = new SqlCommand("insert into Tbl_Secilenler(Kisi, tur) values(@kisi, @tur)", connection);
                komut.Parameters.AddWithValue("@kisi", lbladi.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                komut.ExecuteNonQuery();
                connection.Close();
            }
            else// Eğer label'ın rengi beyaz ise, yani yönetmen zaten seçilmişse, aşağıdaki işlemler yapılır.
            {
                lbladi.ForeColor = Color.FromArgb(16, 46, 80);
                connection.Open();
                // Seçilen yönetmeni veritabanından silme işlemi için gerekli olan SQL komutları.
                SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler where Kisi = @kisi AND Tur = @tur", connection);
                komut.Parameters.AddWithValue("@kisi", lbladi.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                komut.ExecuteNonQuery();
                connection.Close();
            }
        }
        // Form yüklendiğinde yönetmen seçimi kontrolü yapma işlemi için yazılan kod bloğu.
        private void YListeAraci_Load(object sender, EventArgs e)
        {
            try// Bağlantı açma işlemi için gerekli olan kod bloğu.
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                // Seçilen yönetmenin veritabanında kayıtlı olup olmadığını kontrol etme işlemi için gerekli olan SQL komutları.
                SqlCommand komut = new SqlCommand("Select * from Tbl_Secilenler WHERE Kisi =@kisi AND Tur =@tur", connection);
                komut.Parameters.AddWithValue("@kisi", lbladi.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    lbladi.ForeColor = Color.White;
                }
                else
                {
                    lbladi.ForeColor = Color.FromArgb(16, 46, 80);
                }
            }
            catch (Exception ex)// Hata durumunda kullanıcıya uyarı mesajı gösterme işlemi için yazılan kod bloğu.
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally// Bağlantı kapatma işlemi için yazılan kod bloğu.
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
